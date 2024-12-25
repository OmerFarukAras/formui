using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace formui {
    public partial class Auth : Form {
        private MainPage MainPage;
        private Register Register;

        private User user = new User();

        private bool loggedIn = false;
        private string error = "";
        public Auth() {
            InitializeComponent();
            InitializeTopBar();
        }
        private void InitializeTopBar() {
            // Yeni top bar
            TopBar topBar = new TopBar();
            this.Controls.Add(topBar);
        }
        private void Auth_Load(object sender, EventArgs e) {
            Register = new Register();
            MainPage = new MainPage();

            if (user.CheckSavedUser()) {
                this.Hide();
                MainPage.Show();
            }
        }
        private void noLoginButton_Click(object sender, EventArgs e) {
            this.Hide();
            MainPage.Show();
        }
        private void registerButton_Click(object sender, EventArgs e) {
            this.Hide();
            Register.Show();
        }
        private async void loginButton_Click(object sender, EventArgs e) {
            (loggedIn, error) = await user.Login(usernameInput.Text, passwordInput.Text);
            if (!loggedIn) changeErrorText(error);
            else {
                this.Hide();
                MainPage.Show();
            }
        }

        private void changeErrorText(string text) {
            errorText.AutoSize = true;
            errorText.Text = text;
            errorText.Top = 400;
            errorText.Left = (this.ClientSize.Width - 44 - errorText.Width) / 2;
        }
    }
}
