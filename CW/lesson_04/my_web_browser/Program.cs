using System;
using System.Windows.Forms;

namespace my_web_browser
{
    /// <summary>
    /// 1. Добавление сайтов в каталог интернет-ресурсов
    /// 2. Удаление сайтов из каталога интернет-ресурсов
    /// 3. Переходы к загрузке страниц по адресам, указанным в списке сайтов для данной категории
    /// </summary>
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
            Application.Run(new FormMain());
        }
    }
}
