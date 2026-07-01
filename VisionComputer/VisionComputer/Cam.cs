using System;
using OpenCvSharp;

namespace VisionComputer
{
    public class Cam
    {
        private VideoCapture _capture;

        public Cam()
        {
            try
            {
                // Index 0 typically represents the default USB or built-in camera
                _capture = new VideoCapture(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing camera: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    if (ex.InnerException.InnerException != null)
                    {
                        Console.WriteLine($"Inner Inner Exception: {ex.InnerException.InnerException.Message}");
                    }
                }
            }
        }

        public bool IsCameraConnected()
        {
            return _capture != null && _capture.IsOpened();
        }

        public void TestConnection()
        {
            if (IsCameraConnected())
            {
                Console.WriteLine("SUCCESS: Camera is connected and working properly with OpenCvSharp4.");
            }
            else
            {
                Console.WriteLine("ERROR: Failed to connect to the camera. Please check the USB connection.");
            }
        }
    }
}
