using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp_pereph_company
{
    public partial class FormMain : Form
    {
        List<Product> _exProducts;

        public FormMain()
        {
            InitializeComponent();
        }

        private void InitTestProducts()
        {
            _exProducts = new List<Product>();
            _exProducts.Add(new Product("Mother Board rx1111", "3 noth bridges\n48 available mem", "good", 12000));
            _exProducts.Add(new Product("Video card rx0111", "16G mem\n2k bus", "very good", 1500));
            _exProducts.Add(new Product("Mem Stick", "16G mem\n2k MGz", "very good", 12200));
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Marbax/WinForms_and_WinApi/tree/master/HW/HW_04/comp_pereph_company");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitTestProducts();
            ComboBoxGoodsUpdate();
            ToolTip tp = new ToolTip();
            tp.IsBalloon = true;
            tp.SetToolTip(linkLabelHelp, "2. Фирма продает составляющие компьютера. \nПервая форма отвечает за учет продаж, вторая за добавление иредактирование составляющих.\nПервая форма: Список, выпадающий список, текстовое поле, кнопка вызова второй формы.   \nВ выпадающем списке появляются наименования всех товаров, которые в наличии в магазине.   \nПользователь выбирает товар, в текстовом окне, которое нельзя редактировать, появляется цена.   \nПользователь нажимает «добавить» и товар добавляется в список продаж.   \nТакже должно быть окошко, которое выводит общую стоимость.   \nВторая форма: Информация о комплектующих(наименование, характеристика, описание и цена) вводится в текстовые поля;            \nв список добавляется текстовая строка, содержащая информацию о товаре, кроме цены, цена в списке не видна, но содержится;            \nтакже комплектующие можно редактировать");
            listBoxCart.DisplayMember = comboBoxGoods.DisplayMember = "Name";

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            using (FormComponentsInfo fci = new FormComponentsInfo())
            {
                if (fci.ShowDialog() == DialogResult.OK)
                {
                    listBoxCart.Items.Add(new Product(fci.ProdName, fci.ProdSpecifications, fci.ProdDescription, fci.ProdValue));
                    TotalValueUpdate();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxCart.Items.Count > 0 && listBoxCart.SelectedIndex != -1)
            {
                Product tmp_prod = (Product)listBoxCart.Items[listBoxCart.SelectedIndex];
                using (FormComponentsInfo fci = new FormComponentsInfo() { ProdName = tmp_prod.Name, ProdSpecifications = tmp_prod.Specifications, ProdDescription = tmp_prod.Description, ProdValue = tmp_prod.Value })
                {
                    if (fci.ShowDialog() == DialogResult.OK)
                    {
                        listBoxCart.Items.RemoveAt(listBoxCart.SelectedIndex);
                        listBoxCart.Items.Add(new Product(fci.ProdName, fci.ProdSpecifications, fci.ProdDescription, fci.ProdValue));
                        TotalValueUpdate();
                    }
                }
            }
        }

        private void listBoxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedIndex != -1)
            {
                textBoxValue.Text = ((Product)listBoxCart.Items[listBoxCart.SelectedIndex]).Value.ToString();
            }
        }

        private void TotalValueUpdate()
        {
            decimal tmp_total_value = 0;
            foreach (object item in listBoxCart.Items)
            {
                tmp_total_value += ((Product)item).Value;
            }
            textBoxTotalValue.Text = tmp_total_value.ToString();
        }

        private void ComboBoxGoodsUpdate()
        {
            _exProducts.ForEach(x => comboBoxGoods.Items.Add(x));
        }

        private void comboBoxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxValue.Text = ((Product)comboBoxGoods.Items[comboBoxGoods.SelectedIndex]).Value.ToString();
        }

        private void buttonAddExist_Click(object sender, EventArgs e)
        {
            if (comboBoxGoods.SelectedIndex != -1)
            {
                listBoxCart.Items.Add((Product)comboBoxGoods.Items[comboBoxGoods.SelectedIndex]);
                TotalValueUpdate();
            }
        }
    }
}
