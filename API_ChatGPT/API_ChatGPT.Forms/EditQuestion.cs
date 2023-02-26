using System.Runtime.InteropServices;

namespace API_ChatGPT.Forms;

public partial class EditQuestion : Form
{
    public EditQuestion()
    {
        InitializeComponent();

        this.StyleForm();
    }

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
        int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    private void StyleForm()
    {
        this.buttonCancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonCancel.Width, buttonCancel.Height, 20, 20));
        this.buttonOk.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonOk.Width, buttonOk.Height, 20, 20));
        this.textBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox.Width, textBox.Height, 20, 20));
    }
}
