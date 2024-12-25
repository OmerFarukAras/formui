namespace formui;

public partial class Profile : Form
{
    public Profile()
    {
        InitializeComponent();
        InitializeTopBar();
    }
    private void InitializeTopBar() {
        TopBar topBar = new TopBar();
        this.Controls.Add(topBar);
    }
}