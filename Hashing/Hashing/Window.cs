namespace Hashing;

public partial class Window : Form
{
    private HashFunction hashFunction;

    public Window()
    {
        InitializeComponent();
    }

    private void ShowHash(string text)
    {
        txtHash.Text = hashFunction?.ComputeHash(text);
    }

    private void PasswordChangedHandler(object sender, EventArgs e)
    {
        ShowHash(((TextBox)sender).Text);
    }

    private void RadioCheckedHandler(object sender, EventArgs e)
    {
        RadioButton radio = (RadioButton)sender;
        IHashStrategy strategy = (IHashStrategy)radio.Tag;
        hashFunction = new HashFunction(strategy);
        ShowHash(txtPassword.Text);
    }
}
