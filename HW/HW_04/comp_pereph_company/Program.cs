﻿using System;
using System.Windows.Forms;

namespace comp_pereph_company
{
    /// <summary>
    /// 2. Фирма продает составляющие компьютера. 
    /// Первая форма отвечает за учет продаж, вторая за добавление и редактирование составляющих. 
    /// Первая форма: Список, выпадающий список, текстовое поле, кнопка вызова второй формы. 
    /// В выпадающем списке появляются наименования всех товаров, которые в наличии в магазине. 
    /// Пользователь выбирает товар, в текстовом окне, которое нельзя редактировать, появляется цена. 
    /// Пользователь нажимает «добавить» и товар добавляется в список продаж. 
    /// Также должно быть окошко, которое выводит общую стоимость. 
    /// 
    /// Вторая форма: Информация о комплектующих (наименование, характеристика, описание и цена) вводится в текстовые поля; 
    /// в список добавляется текстовая строка, содержащая информацию о товаре, кроме цены, цена в списке не видна, но содержится; 
    /// также комплектующие можно редактировать
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
