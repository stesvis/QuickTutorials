using System;
using System.Threading;

namespace Events
{
    internal class DownloadManager
    {
        public event EventHandler DownloadCompleted;

        public DownloadManager()
        {
        }

        public void DownloadFile(string filename)
        {
            Console.WriteLine($"Downloading file {filename}");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");

            OnDownloadCompleted(filename);
        }

        protected virtual void OnDownloadCompleted(string filename)
        {
            //Console.WriteLine("Handling event");
            DownloadCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}