using System.Diagnostics;

namespace ClipboardFixer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Now fixing Clipboard...");

            System.Diagnostics.Process dwm = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo dwmStart = new System.Diagnostics.ProcessStartInfo();
            dwmStart.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            dwmStart.FileName = "cmd.exe";
            dwmStart.Arguments = "taskkill /f /im dwm.exe";
            dwm.StartInfo = dwmStart;
            dwm.Start();

            System.Diagnostics.Process rdp = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo rdpStart = new System.Diagnostics.ProcessStartInfo();
            rdpStart.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            rdpStart.FileName = "cmd.exe";
            rdpStart.Arguments = "taskkill /f /im rdpclip.exe";
            rdp.StartInfo = rdpStart;
            rdp.Start();

            Process.Start("dwm.exe");
            Process.Start("rdpclip.exe");
            Console.WriteLine("Clipboard fixed!");
            Console.ReadLine();

        }
    }
}
