// See https://aka.ms/new-console-template for more information


using System.Drawing;
using System.Drawing.Imaging;

const String FONT_NAME = "Times New Roman";

Console.WriteLine("Please input the image name:");
String imageName = Console.ReadLine();
Console.WriteLine("Please input the text you want on the image:");
String text = Console.ReadLine();

Image image = Image.FromFile(imageName); 
Bitmap bitmap = new Bitmap(image);
image.Dispose(); //releasing resources

SolidBrush brush = new SolidBrush(Color.Black);
PointF pf = new PointF(200, 200);
Font font = new Font(FONT_NAME, 40);

Graphics graphics = Graphics.FromImage(bitmap);
graphics.DrawString(text,font,brush,pf);

bitmap.Save("new_"+imageName,ImageFormat.Jpeg);
font.Dispose();
graphics.Dispose();
Console.WriteLine("The job has been done.");
Console.ReadLine();



