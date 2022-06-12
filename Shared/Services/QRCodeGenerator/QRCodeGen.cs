using System.Drawing;
using System.IO;
using QRCoder;

namespace Shared.Services
{
    public class QRCodeGen : IQRCodeGen
    {
        public Bitmap URLQRCodegenerator(string url)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(10);
            return qrCodeImage;
        }

        public byte[] GenerateByteArray(string url)
        {
            var image = URLQRCodegenerator(url);
            return ImageToByte(image);
        }

        byte[] ImageToByte(Image img)
        {
            using var stream = new MemoryStream();
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            return stream.ToArray();
        }

        byte[] IQRCodeGen.ImageToByte(Image img)
        {
            throw new System.NotImplementedException();
        }
    }
}