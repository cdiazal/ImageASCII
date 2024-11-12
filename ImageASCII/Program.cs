using System.Drawing;
using System.Text;
using Emgu.CV;
using Mat = Emgu.CV.Mat;
using VideoCapture = Emgu.CV.VideoCapture;

char[] chars = { '#', '#', '@', '%', '=', '+', '*', ':', '-', '.', ' ' };
var capture = new VideoCapture();
var img = new Mat();

StringBuilder sb = new();
while (capture.IsOpened)
{
    capture.Read(img);
    if (img.Cols == 0) break;
    var bit = img.ToBitmap();
    var divideBy = img.Width / 300;
    var resized = new Size(img.Width / divideBy, img.Height / divideBy);
    Bitmap bitResized = new(bit, resized);
    sb = ConvertToAscii(bitResized);

    Console.Write(sb.ToString());
    Console.SetCursorPosition(0, 0);
    sb.Clear();
}

StringBuilder ConvertToAscii(Bitmap image)
{
    for (var i = 0x0; i < image.Height; i++)
    {
        for (var x = 0x0; x < image.Width; x++)
        {
            var color = ((Bitmap)image).GetPixel(x, i);
            var gray = (color.R + color.G + color.B) / 0x3;
            var index = (gray * (chars.Length - 0x1)) / 0xFF;
            Console.Write(chars[index]);
        }
        Console.Write('\n');
    }
    return sb;
}