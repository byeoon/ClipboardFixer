using System.Diagnostics;

namespace ClipboardFixer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Title = "ClipboardFixer";
            Console.WriteLine("Now fixing Clipboard...");
            Process.Start("taskkill", "/f /im dwm.exe");
            Process.Start("taskkill", "/f /im rdpclip.exe");

            Process.Start("dwm.exe");
            Process.Start("rdpclip.exe");

            Console.WriteLine("Clipboard fixed! Press any key to exit.");
            Console.ReadLine();

        }
    }
}
