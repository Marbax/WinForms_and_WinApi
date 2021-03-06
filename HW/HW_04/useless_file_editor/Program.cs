﻿using System;
using System.Windows.Forms;

namespace useless_file_editor
{
    /// <summary>
    /// 3. Разработайте приложение, которое состоит из двух форм. 
    /// Первая форма содержит TextBox доступный только для чтения и две кнопки «загрузить файл» и «редактировать». 
    /// Кнопка «редактировать» изначально неактивна. 
    /// При нажатии на первую кнопку, открывается диалог и пользователю предлагают выбрать текстовый файл. 
    /// Выбранный файл загружается в TextBox и кнопка «редактировать» становится активной. 
    /// При нажатии на вторую кнопку открывается вторая форма (не модально), которая содержит TextBox доступный для редактирования и две кнопки «Сохранить» и «Отменить». 
    /// При нажатии на первую кнопку  изменения отображаются в TextBox первой формы.
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
            Application.Run(new Form1());
        }
    }
}
