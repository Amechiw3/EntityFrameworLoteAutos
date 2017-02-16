using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebCam_Capture;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace LoteAutosGit.Tools
{
    class Webcam
    {
        private WebCamCapture webcam;
        private PictureBox _FrameImage;
        private int FrameNumber = 30;

        public void InitializeWebCam(ref PictureBox ImageControl)
        {
            webcam = new WebCamCapture();
            webcam.FrameNumber = ((ulong)(0ul));
            webcam.TimeToCapture_milliseconds = FrameNumber;
            webcam.ImageCaptured += new WebCamCapture.WebCamEventHandler(webcam_ImageCaptured);
            _FrameImage = ImageControl;
        }

        void webcam_ImageCaptured(object source, WebcamEventArgs e)
        {
            _FrameImage.Image = e.WebCamImage;
        }

        public void Start()
        {
            webcam.TimeToCapture_milliseconds = FrameNumber;
            webcam.Start(0);
        }

        public void Stop()
        {
            webcam.Stop();
        }

        public void Continue()
        {
            // change the capture time frame
            webcam.TimeToCapture_milliseconds = FrameNumber;

            // resume the video capture from the stop
            webcam.Start(this.webcam.FrameNumber);
        }

        public void ResolutionSetting()
        {
            webcam.Config();
        }

        public void AdvanceSetting()
        {
            webcam.Config2();
        }

        public static string SaveImageCapture(Image image)
        {
            var s = new SaveFileDialog();
            var rnd = new Random();
            s.FileName = "Image";// Default file name
            s.InitialDirectory = Directory.GetCurrentDirectory() + @"\Propietario";
            s.FileName = rnd.Next(0, 100000).ToString();
            s.DefaultExt = ".png";// Default file extension
            s.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png"; // Filter files by extension
            // Save Image
            string filename = s.FileName;
            //MessageBox.Show( Path.GetFileName(s.FileName) );
            string archivo = Directory.GetCurrentDirectory() + @"\Propietario\"+ filename+".png";
            FileStream fstream = new FileStream(archivo, FileMode.Create);
            image.Save(fstream, ImageFormat.Jpeg);
            fstream.Close();
            return filename + ".png";
        }

        public static void SaveImage(PictureBox pcFoto)
        {
            var s = new OpenFileDialog();
            var rnd = new Random();
            //s.FileName = "Image";// Default file name
            s.FileName = rnd.Next(0, 100000).ToString();
            s.DefaultExt = ".png";// Default file extension
            s.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png"; // Filter files by extension

            // Show save file dialog box
            // Process save file dialog box results
            if (s.ShowDialog() == DialogResult.OK)
            {
                // Save Image
                string filename = s.FileName;
                MessageBox.Show(Path.GetFileName(s.FileName));
                pcFoto.Image = Image.FromFile(filename);


                //FileStream fstream = new FileStream(filename, FileMode.Create);
                //image.Save(fstream, ImageFormat.Jpeg);
                //fstream.Close();
            }
        }
    }
}
