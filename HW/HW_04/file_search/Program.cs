using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_search
{
    /// <summary>
    /// 1. Разработайте программу, которая позволяет пользователю осуществлять поиск файлов по заданному критерию. 
    ///Приложение состоит из двух форм — главное окно и окно поиска. 
    ///Пользователь может открыть сколько угодно окон поиска. Окно поиска запускается немодально. 
    ///В окне поиска пользователь выбирает папку, в которой будет идти поиск и вводит маску поиска, например «*.doc».  
    ///Найденные файлы отображаются в списке. 
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
            Application.Run(new FormMainWindow());
        }
    }
}
