using System.ComponentModel;

namespace formui;

partial class Profile
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
    private void InitializeComponent()
    {
        mainPanel = new MaterialSkin.Controls.MaterialCard();
        centerText = new MaterialSkin.Controls.MaterialLabel();
        mainPanel.SuspendLayout();
        SuspendLayout();
        // 
        // mainPanel
        // 
        mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
        mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        mainPanel.Controls.Add(centerText);
        mainPanel.Depth = 0;
        mainPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
        mainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
        mainPanel.Location = new System.Drawing.Point(23, 62);
        mainPanel.Margin = new System.Windows.Forms.Padding(14);
        mainPanel.MouseState = MaterialSkin.MouseState.HOVER;
        mainPanel.Name = "mainPanel";
        mainPanel.Padding = new System.Windows.Forms.Padding(14);
        mainPanel.Size = new System.Drawing.Size(854, 550);
        mainPanel.TabIndex = 0;
        // 
        // centerText
        // 
        centerText.AutoSize = true;
        centerText.Depth = 0;
        centerText.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
        centerText.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
        centerText.Location = new System.Drawing.Point(85, 339);
        centerText.MouseState = MaterialSkin.MouseState.HOVER;
        centerText.Name = "centerText";
        centerText.Size = new System.Drawing.Size(685, 24);
        centerText.TabIndex = 8;
        centerText.Text = "Özetlemek istediğiniz metni yazı olarak girebilir ve ya dosya yükleyebilirsiniz.";
        // 
        // Profile
        // 
        AutoValidate = System.Windows.Forms.AutoValidate.Disable;
        ClientSize = new System.Drawing.Size(800, 450);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Profile";
        mainPanel.ResumeLayout(false);
        mainPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion        
    private MaterialSkin.Controls.MaterialCard mainPanel;    
    private MaterialSkin.Controls.MaterialLabel centerText;


}