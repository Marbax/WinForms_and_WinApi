using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// По проекту Goods Catalog с целью закрепления пройденных тем Вам необходимо завершить в полном объеме разработку базового функционала приложения. На завершающем этапе это: 
/// добавление и удаление категорий, добавление и удаление производителей, добавление и удаление товаров.
/// </summary>
namespace GoodsCatalog
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
            Application.Run(new FormMain());
        }
    }
}
