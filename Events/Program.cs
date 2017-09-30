using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var manager = new DownloadManager();
            manager.DownloadCompleted += Manager_DownloadCompleted1;

            manager.DownloadCompleted += Manager_DownloadCompleted2;

            manager.DownloadFile("test.png");

            //System.Console.ReadKey();
        }

        private static void Manager_DownloadCompleted1(object sender, System.EventArgs e)
        {
            System.Console.WriteLine("The download is complete (1)");
        }

        private static void Manager_DownloadCompleted2(object sender, System.EventArgs e)
        {
            System.Console.WriteLine("The download is complete (2)");
        }
    }
}