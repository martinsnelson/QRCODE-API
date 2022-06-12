using System.Drawing;

namespace Shared.Services
{
    public interface IQRCodeGen
    {
        Bitmap URLQRCodegenerator(string url);
        byte[] GenerateByteArray(string url);
        byte[] ImageToByte(Image img);
    }

}