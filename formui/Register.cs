using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace formui {
    public partial class Register : Form {
        private MainPage MainPage;
        private Auth Auth;

        private User user = new User();

        private bool loggedIn = false;
        private string error = "";

        public Register() {
            InitializeComponent();
            InitializeTopBar();

            MainPage = new MainPage();
            Auth = new Auth();
        }
        private void InitializeTopBar() {
            TopBar topBar = new TopBar();
            this.Controls.Add(topBar);
        }

        private void noLoginButton_Click(object sender, EventArgs e) {
            this.Hide();
            MainPage.Show();
        }

        private void loginButton_Click(object sender, EventArgs e) {
            this.Hide();
            Auth.Show();
        }

        private async void registerButton_Click(object sender, EventArgs e) {
            (loggedIn, error) = await user.Register(usernameInput.Text, passwordInput.Text, emailInput.Text);
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
