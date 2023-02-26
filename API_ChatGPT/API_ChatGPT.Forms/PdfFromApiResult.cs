using API_ChatGPT.ClassLib;
using System.Runtime.InteropServices;

namespace API_ChatGPT.Forms;

public partial class PdfFromApiResult : Form
{
    private API_Service _apiService;
    private PDFDocument _document = null!;

    public PdfFromApiResult()
    {
        InitializeComponent();

        _apiService = new();

        this.StyleForm();
    }

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
        int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    private void StyleForm()
    {
        this.buttonPost.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonPost.Width, buttonPost.Height, 20, 20));
        this.buttonView.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonView.Width, buttonView.Height, 20, 20));
        this.textBoxContent.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxContent.Width, textBoxContent.Height, 20, 20));
    }

    private void buttonPost_Click(object sender, EventArgs e)
    {
        try
        {
            if (_document == null)
                throw new Exception("Confirme a geração do documento antes que possa ser feito o PDF.");

            _document!.Print();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private async void buttonView_Click(object sender, EventArgs e)
    {
        try
        {
            if (String.IsNullOrWhiteSpace(this.textBoxContent.Text))
                throw new Exception("É necessário que haja um conteúdo dentro da caixa de texto.");

            this.UseWaitCursor = true;
            string? response = await _apiService.RequestResult(this.textBoxContent.Text);
            this.UseWaitCursor = false;

            if (response == null)
                throw new Exception("A requisição foi mal sucedida, tente novamente mais tarde.");

            _document = new()
            {
                Text = response,
                Font = new Font("Yu Gothic", 12),
                Color = Brushes.Black
            };

            this.printPreviewControl.Document = _document;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
