using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artis_lab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static ARTISLAB.ArtisLabInfoServiceSoapClient ARTISClient;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ARTISClient = new ARTISLAB.ArtisLabInfoServiceSoapClient("ArtisLabInfoServiceSoap");
            Application.Run(new MainForm());
        }
    }
}
