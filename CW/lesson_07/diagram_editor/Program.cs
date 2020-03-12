using System;
using System.Windows.Forms;

namespace diagram_editor
{
    /// <summary>
    /// Ваше задание состоит в разработке приложения "Редактор диаграмм"
    /// Необходимо задействовать элемент управления ListView и набор базовых
    /// контролов для ввода исходных данных в виде пар: легенда-значение
    /// (например: фамилия кандидата - число голосов). Следует предусмотреть
    /// рисование двух типов диаграмм: столбчастой и круговой.Также плюсом
    /// будет размещение надписей к диаграммам или создание панели с подписями
    /// к различным цветам, отображаемым на них.В правой боковой панели нужно
    /// будет выводить статистические показатели набора данных: максимальное и
    /// минимальное значения, средний результат.
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
