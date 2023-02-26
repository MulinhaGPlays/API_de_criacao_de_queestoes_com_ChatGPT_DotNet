using System.Drawing;
using System.Drawing.Printing;

namespace API_ChatGPT.ClassLib;

public class PDFDocument : PrintDocument
{
    public PDFDocument()
    {
        this.PrinterSettings.PrinterName = "Microsoft Print to PDF";
    }

    public required string Text { get; set; }
    public required Font Font { get; set; }
    public required Brush Color { get; set; }

    protected override void OnPrintPage(PrintPageEventArgs e)
    {
        e.Graphics!.DrawString(Text, Font, Color, new PointF(20, 20));
    }
}
