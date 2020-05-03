
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.GUI.MainForm;
using AttendanceControlAdminClient.GUI.SignInForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;          
            new SignInForm().ShowDialog();
        }
    }
}
