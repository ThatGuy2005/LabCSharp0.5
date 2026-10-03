using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LabCSharp0._5
{
    internal static class Program
    {
        /// <summary>
        /// When pressing the Start button, the program will change the color of the Stop button to green,
        /// indicating that it can be pressed to stop something.
        /// When the Stop button is pressed, the color state of the buttons will go back to default.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
