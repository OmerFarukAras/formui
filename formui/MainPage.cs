using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace formui {
    public partial class MainPage : Form {
        private bool fileSelected = false;

        private string filePath = string.Empty;
        private string respond = string.Empty;

        private Network network;
        private Progress<int> progress;
        private User user = new User();
        public MainPage() {
            InitializeComponent();
            InitializeTopBar();

            progressBar.Value = 0;

            progress = new Progress<int>(percent => progressBar.Value = percent);
            network = new Network("http://vps.omerfarukaras.online:5000", progress);

        }

        private void InitializeTopBar() {
            TopBar topBar = new TopBar();
            this.Controls.Add(topBar);
        }
        private async void MainPage_Load(object sender, EventArgs e) {
            resetButton.PerformClick();
            await user.Load();
        }
        private void textInput_TextChanged(object sender, EventArgs e) {
            fileSelectButton.Enabled = string.IsNullOrWhiteSpace(textInput.Text);
        }

        private void fileSelectButton_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

                openFileDialog.Filter = "PDF Dosyaları (*.pdf*)|*.pdf*|Metin Dosyaları (*.txt)|*.txt";
                openFileDialog.Title = "Bir dosya seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    filePath = openFileDialog.FileName;
                    chaneCenterText(openFileDialog.FileName);

                    fileSelected = true;
                    textInput.Enabled = false;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e) {
            chaneCenterText("Özetlemek istediğiniz metni yazı olarak girebilir ve ya dosya yükleyebilirsin " + user.Username + ".");

            filePath = "";
            fileSelected = false;
            fileSelectButton.Enabled = true;

            textInput.Enabled = true;
            textInput.Text = "";
        }

        private void chaneCenterText(string text) {
            centerText.AutoSize = true;
            centerText.Text = text;
            centerText.Top = 338;
            centerText.Left = (this.ClientSize.Width - 44 - centerText.Width) / 2;

        }

        private async void analayzeButton_Click(object sender, EventArgs e) {
            if (fileSelected) {
                try {
                    dynamic res = await network.SendFile(filePath);
                    MessageBox.Show("Dosya başarıyla yüklendi!" + res);
                    chaneCenterText("Dosya başarıyla yüklendi!");
                } catch (Exception ex) {
                    MessageBox.Show($"Hata: {ex.Message}");
                    chaneCenterText($"Hata: {ex.Message}");
                }
            } else if (!string.IsNullOrWhiteSpace(textInput.Text)) {
                try {
                    dynamic res = await network.SendString(textInput.Text);
                    showResponse(res, user.Username);
                    chaneCenterText("Özetleme başlıyor.");
                } catch (Exception ex) {
                    MessageBox.Show($"Hata: {ex.Message}");
                    chaneCenterText($"Hata: {ex.Message}");
                }

            }
            resetButton.PerformClick();
        }

        private async Task updateProgressBar() {
            progressBar.Value = 0;

            for (int i = 0; i <= 100; i++) {
                await Task.Delay(5);
                progressBar.Value = i;
            }
            MessageBox.Show("İşlem tamamlandı!");
            progressBar.Visible = false;
        }

        private void showResponse(string text, string header) {
            ResponseText.Text = text;
            ResponseTopLeft.Text = "Çıktı :" + header;
            ResponseCard.BringToFront();
        }
        private void ResponseCloseButton_Click(object sender, EventArgs e) {
            mainPanel.BringToFront();
        }
    }

}
