using AttendanceControlAdminClient.GUI.SignInForm;
using System;
using System.Net;
using System.Windows.Forms;

namespace AttendanceControlAdminClient
{
    static class Program
    {
        /// <summary>
        ///     Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls 
                | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 
                | SecurityProtocolType.Ssl3;    
            //Instancia el formulario de login
            new SignInForm().ShowDialog();
        }
    }
}
