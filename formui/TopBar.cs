using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace formui
{
    public class TopBar : Panel
    {
        private MaterialLabel topLeftTitle;
        private Button hideButton;
        private Button closeButton;

        public TopBar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Top barın görünümü ve boyutu
            this.BackColor = SystemColors.ActiveBorder;
            this.Dock = DockStyle.Top;
            this.Size = new Size(900, 45);

            // Başlık
            topLeftTitle = new MaterialLabel
            {
                Text = "DocAI",
                Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel),
                FontType = MaterialSkin.MaterialSkinManager.fontType.H4,
                Size = new Size(200, 50),
                Location = new Point(7, 2),
                ForeColor = SystemColors.ControlLight
            };
            this.Controls.Add(topLeftTitle);

            // Gizleme butonu
            hideButton = new Button
            {
                Text = "-",
                Size = new Size(30, 30),
                Location = new Point(827, 7),
                BackColor = Color.Silver,
                FlatStyle = FlatStyle.Flat
            };
            hideButton.Click += HideButton_Click;
            this.Controls.Add(hideButton);

            // Kapatma butonu
            closeButton = new Button
            {
                Text = "X",
                Size = new Size(30, 30),
                Location = new Point(863, 7),
                BackColor = Color.Maroon,
                ForeColor = SystemColors.ButtonHighlight,
                FlatStyle = FlatStyle.Flat
            };
            closeButton.Click += CloseButton_Click;
            this.Controls.Add(closeButton);
        }

        // Olay metodları
        private void HideButton_Click(object sender, EventArgs e)
        {
 
            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
