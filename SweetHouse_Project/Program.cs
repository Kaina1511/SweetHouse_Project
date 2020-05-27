using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SweetHouse_Project
{
    static class Program
    {
        public struct User
        {
            public string login;
            public string password;
            public string type;
        }

        public static SweetHouseEntities21 shDb = new SweetHouseEntities21(); 
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAuthorization());
        }
    }
}
