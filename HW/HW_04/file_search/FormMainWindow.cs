using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_search
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void FormMainWindow_Load(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.IsBalloon = true;
            tp.SetToolTip(linkLabelHelp, "1. Разработайте программу, которая позволяет пользователю осуществлять поиск файлов по заданному критерию. \nПриложение состоит из двух форм — главное окно и окно поиска. \nПользователь может открыть сколько угодно окон поиска. \nОкно поиска запускается немодально. \nВ окне поиска пользователь выбирает папку, в которой будет идти поиск и вводит маску поиска, например «*.doc».  \nНайденные файлы отображаются в списке. ");
        }

        private void buttonOpenSearchWindow_Click(object sender, EventArgs e)
        {
            FormSearchWindow fsw = new FormSearchWindow();
            fsw.Show(this);
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Marbax/WinForms_and_WinApi/tree/master/HW/HW_04/file_search");
        }
    }
}
