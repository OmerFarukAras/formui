namespace formui
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            fileSelectBg = new MaterialSkin.Controls.MaterialCard();
            fileSelectButton = new MaterialSkin.Controls.MaterialButton();
            progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            centerText = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            textInput = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            resetButton = new MaterialSkin.Controls.MaterialButton();
            analayzeButton = new MaterialSkin.Controls.MaterialButton();
            saveAsTxt = new MaterialSkin.Controls.MaterialButton();
            openFileDialog = new OpenFileDialog();
            ResponseCard = new MaterialSkin.Controls.MaterialCard();
            ResponseTopLeft = new MaterialSkin.Controls.MaterialLabel();
            ResponseText = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            ResponseCloseButton = new MaterialSkin.Controls.MaterialButton();
            mainPanel.SuspendLayout();
            fileSelectBg.SuspendLayout();
            ResponseCard.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(255, 255, 255);
            mainPanel.BackgroundImageLayout = ImageLayout.Center;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(fileSelectBg);
            mainPanel.Controls.Add(progressBar);
            mainPanel.Controls.Add(centerText);
            mainPanel.Controls.Add(materialLabel1);
            mainPanel.Controls.Add(textInput);
            mainPanel.Controls.Add(resetButton);
            mainPanel.Controls.Add(analayzeButton);
            mainPanel.Depth = 0;
            mainPanel.Font = new Font("Segoe UI", 9F);
            mainPanel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mainPanel.Location = new Point(23, 62);
            mainPanel.Margin = new Padding(14);
            mainPanel.MouseState = MaterialSkin.MouseState.HOVER;
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(14);
            mainPanel.Size = new Size(854, 550);
            mainPanel.TabIndex = 0;
            // 
            // fileSelectBg
            // 
            fileSelectBg.BackColor = Color.FromArgb(255, 255, 255);
            fileSelectBg.Controls.Add(fileSelectButton);
            fileSelectBg.Depth = 0;
            fileSelectBg.ForeColor = Color.FromArgb(222, 0, 0, 0);
            fileSelectBg.Location = new Point(18, 377);
            fileSelectBg.Margin = new Padding(14);
            fileSelectBg.MouseState = MaterialSkin.MouseState.HOVER;
            fileSelectBg.Name = "fileSelectBg";
            fileSelectBg.Padding = new Padding(14);
            fileSelectBg.Size = new Size(816, 79);
            fileSelectBg.TabIndex = 10;
            // 
            // fileSelectButton
            // 
            fileSelectButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fileSelectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            fileSelectButton.Depth = 0;
            fileSelectButton.HighEmphasis = true;
            fileSelectButton.Icon = null;
            fileSelectButton.Location = new Point(358, 21);
            fileSelectButton.Margin = new Padding(4, 6, 4, 6);
            fileSelectButton.MouseState = MaterialSkin.MouseState.HOVER;
            fileSelectButton.Name = "fileSelectButton";
            fileSelectButton.NoAccentTextColor = Color.Empty;
            fileSelectButton.Size = new Size(99, 36);
            fileSelectButton.TabIndex = 0;
            fileSelectButton.Text = "Dosya Seç";
            fileSelectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            fileSelectButton.UseAccentColor = false;
            fileSelectButton.UseVisualStyleBackColor = true;
            fileSelectButton.Click += fileSelectButton_Click;
            // 
            // progressBar
            // 
            progressBar.Depth = 0;
            progressBar.Location = new Point(17, 473);
            progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(817, 5);
            progressBar.TabIndex = 9;
            progressBar.Value = 30;
            // 
            // centerText
            // 
            centerText.AutoSize = true;
            centerText.Depth = 0;
            centerText.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            centerText.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            centerText.Location = new Point(85, 339);
            centerText.MouseState = MaterialSkin.MouseState.HOVER;
            centerText.Name = "centerText";
            centerText.Size = new Size(685, 24);
            centerText.TabIndex = 8;
            centerText.Text = "Özetlemek istediğiniz metni yazı olarak girebilir ve ya dosya yükleyebilirsiniz.";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(17, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(72, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Yazı Girişi";
            // 
            // textInput
            // 
            textInput.AnimateReadOnly = false;
            textInput.BackgroundImageLayout = ImageLayout.None;
            textInput.CharacterCasing = CharacterCasing.Normal;
            textInput.Depth = 0;
            textInput.HideSelection = true;
            textInput.Hint = "Lorem ipsum dolor sit amet.";
            textInput.Location = new Point(17, 36);
            textInput.MaxLength = 1000;
            textInput.MouseState = MaterialSkin.MouseState.OUT;
            textInput.Name = "textInput";
            textInput.PasswordChar = '\0';
            textInput.ReadOnly = false;
            textInput.ScrollBars = ScrollBars.None;
            textInput.SelectedText = "";
            textInput.SelectionLength = 0;
            textInput.SelectionStart = 0;
            textInput.ShortcutsEnabled = true;
            textInput.Size = new Size(818, 287);
            textInput.TabIndex = 1;
            textInput.TabStop = false;
            textInput.TextAlign = HorizontalAlignment.Left;
            textInput.UseSystemPasswordChar = false;
            textInput.TextChanged += textInput_TextChanged;
            // 
            // resetButton
            // 
            resetButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resetButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            resetButton.Depth = 0;
            resetButton.HighEmphasis = false;
            resetButton.Icon = null;
            resetButton.Location = new Point(18, 492);
            resetButton.Margin = new Padding(4, 6, 4, 6);
            resetButton.MouseState = MaterialSkin.MouseState.HOVER;
            resetButton.Name = "resetButton";
            resetButton.NoAccentTextColor = Color.Empty;
            resetButton.Size = new Size(74, 36);
            resetButton.TabIndex = 4;
            resetButton.Text = "Sıfırla";
            resetButton.TextAlign = ContentAlignment.BottomLeft;
            resetButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            resetButton.UseAccentColor = true;
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // analayzeButton
            // 
            analayzeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            analayzeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            analayzeButton.Depth = 0;
            analayzeButton.HighEmphasis = true;
            analayzeButton.Icon = null;
            analayzeButton.Location = new Point(742, 492);
            analayzeButton.Margin = new Padding(4, 6, 4, 6);
            analayzeButton.MouseState = MaterialSkin.MouseState.HOVER;
            analayzeButton.Name = "analayzeButton";
            analayzeButton.NoAccentTextColor = Color.Empty;
            analayzeButton.Size = new Size(93, 36);
            analayzeButton.TabIndex = 0;
            analayzeButton.Text = "Analiz Et";
            analayzeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            analayzeButton.UseAccentColor = false;
            analayzeButton.UseVisualStyleBackColor = true;
            analayzeButton.Click += analayzeButton_Click;
            // 
            // saveAsTxt
            // 
            saveAsTxt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveAsTxt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveAsTxt.Depth = 0;
            saveAsTxt.HighEmphasis = false;
            saveAsTxt.Icon = null;
            saveAsTxt.Location = new Point(706, 494);
            saveAsTxt.Margin = new Padding(4, 6, 4, 6);
            saveAsTxt.MouseState = MaterialSkin.MouseState.HOVER;
            saveAsTxt.Name = "saveAsTxt";
            saveAsTxt.NoAccentTextColor = Color.Empty;
            saveAsTxt.Size = new Size(129, 36);
            saveAsTxt.TabIndex = 7;
            saveAsTxt.Text = "Çıktıyı Kaydet";
            saveAsTxt.TextAlign = ContentAlignment.BottomLeft;
            saveAsTxt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            saveAsTxt.UseAccentColor = true;
            saveAsTxt.UseVisualStyleBackColor = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // ResponseCard
            // 
            ResponseCard.BackColor = Color.FromArgb(255, 255, 255);
            ResponseCard.Controls.Add(ResponseCloseButton);
            ResponseCard.Controls.Add(ResponseTopLeft);
            ResponseCard.Controls.Add(ResponseText);
            ResponseCard.Controls.Add(saveAsTxt);
            ResponseCard.Depth = 0;
            ResponseCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ResponseCard.Location = new Point(23, 62);
            ResponseCard.Margin = new Padding(14);
            ResponseCard.MouseState = MaterialSkin.MouseState.HOVER;
            ResponseCard.Name = "ResponseCard";
            ResponseCard.Padding = new Padding(14);
            ResponseCard.Size = new Size(854, 550);
            ResponseCard.TabIndex = 11;
            // 
            // ResponseTopLeft
            // 
            ResponseTopLeft.AutoSize = true;
            ResponseTopLeft.Depth = 0;
            ResponseTopLeft.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ResponseTopLeft.Location = new Point(19, 15);
            ResponseTopLeft.MouseState = MaterialSkin.MouseState.HOVER;
            ResponseTopLeft.Name = "ResponseTopLeft";
            ResponseTopLeft.Size = new Size(40, 19);
            ResponseTopLeft.TabIndex = 9;
            ResponseTopLeft.Text = "Çıktı :";
            // 
            // ResponseText
            // 
            ResponseText.AnimateReadOnly = false;
            ResponseText.BackgroundImageLayout = ImageLayout.None;
            ResponseText.CharacterCasing = CharacterCasing.Normal;
            ResponseText.Depth = 0;
            ResponseText.HideSelection = true;
            ResponseText.Location = new Point(18, 55);
            ResponseText.MaxLength = 32767;
            ResponseText.MouseState = MaterialSkin.MouseState.OUT;
            ResponseText.Name = "ResponseText";
            ResponseText.PasswordChar = '\0';
            ResponseText.ReadOnly = false;
            ResponseText.ScrollBars = ScrollBars.Vertical;
            ResponseText.SelectedText = "";
            ResponseText.SelectionLength = 0;
            ResponseText.SelectionStart = 0;
            ResponseText.ShortcutsEnabled = true;
            ResponseText.Size = new Size(817, 429);
            ResponseText.TabIndex = 8;
            ResponseText.TabStop = false;
            ResponseText.TextAlign = HorizontalAlignment.Left;
            ResponseText.UseSystemPasswordChar = false;
            // 
            // ResponseCloseButton
            // 
            ResponseCloseButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ResponseCloseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ResponseCloseButton.Depth = 0;
            ResponseCloseButton.HighEmphasis = true;
            ResponseCloseButton.Icon = null;
            ResponseCloseButton.Location = new Point(19, 494);
            ResponseCloseButton.Margin = new Padding(4, 6, 4, 6);
            ResponseCloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            ResponseCloseButton.Name = "ResponseCloseButton";
            ResponseCloseButton.NoAccentTextColor = Color.Empty;
            ResponseCloseButton.Size = new Size(161, 36);
            ResponseCloseButton.TabIndex = 10;
            ResponseCloseButton.Text = "Yeni Özet Oluştur";
            ResponseCloseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ResponseCloseButton.UseAccentColor = false;
            ResponseCloseButton.UseVisualStyleBackColor = true;
            ResponseCloseButton.Click += ResponseCloseButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 635);
            Controls.Add(ResponseCard);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DOC AI";
            Load += MainPage_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            fileSelectBg.ResumeLayout(false);
            fileSelectBg.PerformLayout();
            ResponseCard.ResumeLayout(false);
            ResponseCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard mainPanel;
        private MaterialSkin.Controls.MaterialButton resetButton;
        private MaterialSkin.Controls.MaterialButton analayzeButton;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 textInput;
        private OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel centerText;
        private MaterialSkin.Controls.MaterialButton saveAsTxt;
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
        private MaterialSkin.Controls.MaterialCard fileSelectBg;
        private MaterialSkin.Controls.MaterialButton fileSelectButton;
        private MaterialSkin.Controls.MaterialCard ResponseCard;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 ResponseText;
        private MaterialSkin.Controls.MaterialLabel ResponseTopLeft;
        private MaterialSkin.Controls.MaterialButton ResponseCloseButton;
    }
}