/*
directoryTimeStampSort - C# (Windows Forms App .NET) version
Taking a directory full of files, and putting them in folders based on the date of their last modification

Works good for lots of things, logs, pictures, piles of HL7 pharmacy requests, you name it!

Some error checking. Should stop and report to shell on any error As always, use at your own risk. 
 */

/*
 * This is the main program file. It basically just runs the mainForm window and not much else
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace directoryTimeStampSort
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
