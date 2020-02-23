using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsCatalog
{
    public partial class FormMain : Form
    {
        private DataManager _dm = new DataManager();

        public FormMain()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            //InitTestData();
        }

        private void InitTestData()
        {
            int max = 10;
            for (int i = 0; i < max; i++)
            {
                _dm.Categories.Add(new Category() { Name = $"Cat-{i}" });
                _dm.Providers.Add(new Provider() { Name = $"Prov-{i}" });
                _dm.Products.Add(new Product() { Name = $"Product-{i}", Category_Id = i + 1, Provider_Id = max - i, Value = i * 10, Count = i + 2 });

            }
            _dm.SaveChanges();
        }

        private void LoadProducts()
        {
            listViewGoods.Items.Clear();
            foreach (var item in _dm.Products)
            {
                var field = listViewGoods.Items.Add(item.Id.ToString());
                field.SubItems.Add(item.Name);
                field.SubItems.Add(item.Category_Id.ToString());
                field.SubItems.Add(item.Provider_Id.ToString());
                field.SubItems.Add(item.Value.ToString("F"));
                field.SubItems.Add(item.Count.ToString());
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
