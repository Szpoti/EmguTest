using System;
using System.Threading;
using Emgu.CV;

namespace ConsoleApp1
{
    class Program
    {
        static QRCodeDetector detector;
        static VideoCapture videoCapture = new VideoCapture();
        private static ManualResetEvent waitHandle = new ManualResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine("Started!");
            videoCapture.ImageGrabbed += Capture_ImageGrabbed;
            detector = new();
            videoCapture.Start();
            waitHandle.WaitOne();
        }

        private static void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            Console.WriteLine("capturing");
            Mat m = new Mat();
            Mat o = new Mat();
            videoCapture.Retrieve(m);
            var qrs = detector.Detect(m, o);
            if (qrs)
            {
                string code = detector.Decode(m, o, new Mat());
                if (code != "")
                {
                    Console.WriteLine(code);
                }
            }
        }
    }
}
