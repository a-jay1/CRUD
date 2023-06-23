using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web;
using System.Web.UI;
using OpenCvSharp;

namespace YourNamespace
{
    public partial class LiveStreaming : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var capture = new VideoCapture(0))
            {
                if (!capture.IsOpened())
                {
                    // Handle error if camera fails to open
                    Response.Write("Camera failed to open.");
                    return;
                }

                // Read a frame from the capture device
                using (var frame = new Mat())
                {
                    if (!capture.Read(frame))
                    {
                        // Handle error if frame reading fails
                        Response.Write("Failed to read frame.");
                        return;
                    }

                    // Convert the frame to a JPEG image
                    var jpegImage = new Bitmap(frame.Cols, frame.Rows, PixelFormat.Format24bppRgb);
                    var rect = new Rectangle(0, 0, frame.Cols, frame.Rows);
                    var bmpData = jpegImage.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    //Cv2.CvtColor(frame, bmpData.Scan0, ColorConversionCodes.BGR2RGB);
                    jpegImage.UnlockBits(bmpData);

                    // Convert the JPEG image to base64 string and send it as the response
                    using (var stream = new MemoryStream())
                    {
                        jpegImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] imageBytes = stream.ToArray();
                        Response.BinaryWrite(imageBytes);
                        Response.Flush();
                        Response.End();
                    }
                }
            }
        }
    }
}
