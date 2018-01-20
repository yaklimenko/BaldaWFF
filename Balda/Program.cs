using System;
using System.Windows.Forms;
using log4net;

namespace Balda
{
    static class Program
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Program));
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Конфигурирую логер
            log4net.Config.DOMConfigurator.Configure(); 
            log.Debug("starting app...");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BaldaCheatingForm());
        }
    }
}
