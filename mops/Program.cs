using System;
using System.Windows.Forms;

namespace mops
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var message = string.Empty;
            var caption = string.Empty;
            foreach (var arg in args)
            {
                var split = arg.Split(':');

                if (split[0].StartsWith("-message"))
                {
                    message = split[1];
                }
                else if (split[0].StartsWith("-caption"))
                {
                    caption = split[1];
                }
            }

            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            Console.WriteLine($"Message shown! Message: {message}; Caption: {caption}");
        }
    }
}