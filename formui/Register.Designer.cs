namespace formui {
    partial class Register {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            mainPanel = new MaterialSkin.Controls.MaterialCard();
            emailLabel = new MaterialSkin.Controls.MaterialLabel();
            emailInput = new MaterialSkin.Controls.MaterialTextBox();
            errorText = new MaterialSkin.Controls.MaterialLabel();
            sifreLabel = new MaterialSkin.Controls.MaterialLabel();
            kullaniciAdiLabel = new MaterialSkin.Controls.MaterialLabel();
            noLoginButton = new MaterialSkin.Controls.MaterialButton();
            passwordInput = new MaterialSkin.Controls.MaterialTextBox();
            usernameInput = new MaterialSkin.Controls.MaterialTextBox();
            registerButton = new MaterialSkin.Controls.MaterialButton();
            loginButton = new MaterialSkin.Controls.MaterialButton();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(255, 255, 255);
            mainPanel.BackgroundImageLayout = ImageLayout.Center;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(emailLabel);
            mainPanel.Controls.Add(emailInput);
            mainPanel.Controls.Add(errorText);
            mainPanel.Controls.Add(sifreLabel);
            mainPanel.Controls.Add(kullaniciAdiLabel);
            mainPanel.Controls.Add(noLoginButton);
            mainPanel.Controls.Add(passwordInput);
            mainPanel.Controls.Add(usernameInput);
            mainPanel.Controls.Add(registerButton);
            mainPanel.Controls.Add(loginButton);
            mainPanel.Depth = 0;
            mainPanel.Font = new Font("Segoe UI", 9F);
            mainPanel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mainPanel.Location = new Point(23, 62);
            mainPanel.Margin = new Padding(14);
            mainPanel.MouseState = MaterialSkin.MouseState.HOVER;
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(14);
            mainPanel.Size = new Size(854, 550);
            mainPanel.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Depth = 0;
            emailLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailLabel.Location = new Point(300, 121);
            emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(45, 19);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "E-Mail";
            // 
            // emailInput
            // 
            emailInput.AnimateReadOnly = false;
            emailInput.BorderStyle = BorderStyle.None;
            emailInput.Depth = 0;
            emailInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailInput.LeadingIcon = null;
            emailInput.Location = new Point(300, 143);
            emailInput.MaxLength = 50;
            emailInput.MouseState = MaterialSkin.MouseState.OUT;
            emailInput.Multiline = false;
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(300, 50);
            emailInput.TabIndex = 8;
            emailInput.Text = "";
            emailInput.TrailingIcon = null;
            // 
            // errorText
            // 
            errorText.AutoSize = true;
            errorText.Depth = 0;
            errorText.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            errorText.Location = new Point(400, 400);
            errorText.MouseState = MaterialSkin.MouseState.HOVER;
            errorText.Name = "errorText";
            errorText.Size = new Size(72, 19);
            errorText.TabIndex = 7;
            errorText.Text = "Hoşgeldin";
            // 
            // sifreLabel
            // 
            sifreLabel.AutoSize = true;
            sifreLabel.Depth = 0;
            sifreLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            sifreLabel.Location = new Point(300, 289);
            sifreLabel.MouseState = MaterialSkin.MouseState.HOVER;
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new Size(34, 19);
            sifreLabel.TabIndex = 6;
            sifreLabel.Text = "Şifre";
            // 
            // kullaniciAdiLabel
            // 
            kullaniciAdiLabel.AutoSize = true;
            kullaniciAdiLabel.Depth = 0;
            kullaniciAdiLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            kullaniciAdiLabel.Location = new Point(300, 206);
            kullaniciAdiLabel.MouseState = MaterialSkin.MouseState.HOVER;
            kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            kullaniciAdiLabel.Size = new Size(89, 19);
            kullaniciAdiLabel.TabIndex = 5;
            kullaniciAdiLabel.Text = "Kullanıcı Adı";
            // 
            // noLoginButton
            // 
            noLoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            noLoginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            noLoginButton.Depth = 0;
            noLoginButton.HighEmphasis = false;
            noLoginButton.Icon = null;
            noLoginButton.Location = new Point(340, 496);
            noLoginButton.Margin = new Padding(4, 6, 4, 6);
            noLoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            noLoginButton.Name = "noLoginButton";
            noLoginButton.NoAccentTextColor = Color.Empty;
            noLoginButton.Size = new Size(217, 36);
            noLoginButton.TabIndex = 4;
            noLoginButton.Text = "Giriş Yapmadan Devam Et";
            noLoginButton.TextAlign = ContentAlignment.BottomLeft;
            noLoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            noLoginButton.UseAccentColor = true;
            noLoginButton.UseVisualStyleBackColor = false;
            noLoginButton.Click += noLoginButton_Click;
            // 
            // passwordInput
            // 
            passwordInput.AnimateReadOnly = false;
            passwordInput.BorderStyle = BorderStyle.None;
            passwordInput.Depth = 0;
            passwordInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordInput.LeadingIcon = null;
            passwordInput.Location = new Point(300, 311);
            passwordInput.MaxLength = 50;
            passwordInput.MouseState = MaterialSkin.MouseState.OUT;
            passwordInput.Multiline = false;
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(300, 50);
            passwordInput.TabIndex = 3;
            passwordInput.Text = "";
            passwordInput.TrailingIcon = null;
            // 
            // usernameInput
            // 
            usernameInput.AnimateReadOnly = false;
            usernameInput.BorderStyle = BorderStyle.None;
            usernameInput.Depth = 0;
            usernameInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameInput.LeadingIcon = null;
            usernameInput.Location = new Point(300, 228);
            usernameInput.MaxLength = 50;
            usernameInput.MouseState = MaterialSkin.MouseState.OUT;
            usernameInput.Multiline = false;
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(300, 50);
            usernameInput.TabIndex = 2;
            usernameInput.Text = "";
            usernameInput.TrailingIcon = null;
            // 
            // registerButton
            // 
            registerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            registerButton.Depth = 0;
            registerButton.HighEmphasis = true;
            registerButton.Icon = null;
            registerButton.Location = new Point(750, 496);
            registerButton.Margin = new Padding(4, 6, 4, 6);
            registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            registerButton.Name = "registerButton";
            registerButton.NoAccentTextColor = Color.Empty;
            registerButton.Size = new Size(84, 36);
            registerButton.TabIndex = 1;
            registerButton.Text = "Kayıt Ol";
            registerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            registerButton.UseAccentColor = false;
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // loginButton
            // 
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginButton.Depth = 0;
            loginButton.HighEmphasis = true;
            loginButton.Icon = null;
            loginButton.Location = new Point(18, 496);
            loginButton.Margin = new Padding(4, 6, 4, 6);
            loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            loginButton.Name = "loginButton";
            loginButton.NoAccentTextColor = Color.Empty;
            loginButton.Size = new Size(89, 36);
            loginButton.TabIndex = 0;
            loginButton.Text = "Giriş Yap";
            loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loginButton.UseAccentColor = false;
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Register
            // 
            //AutoScaleDimensions = new SizeF(7F, 15F);
            //AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 635);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard mainPanel;
        private MaterialSkin.Controls.MaterialLabel errorText;
        private MaterialSkin.Controls.MaterialLabel sifreLabel;
        private MaterialSkin.Controls.MaterialLabel kullaniciAdiLabel;
        private MaterialSkin.Controls.MaterialButton noLoginButton;
        private MaterialSkin.Controls.MaterialTextBox passwordInput;
        private MaterialSkin.Controls.MaterialTextBox usernameInput;
        private MaterialSkin.Controls.MaterialButton registerButton;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialTextBox emailInput;
    }
}