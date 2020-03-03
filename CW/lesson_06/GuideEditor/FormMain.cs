using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace GuideEditor
{
    public partial class FormMain : Form
    {
        private string _fPath = @"..\..\Guides\Guide_01\XMLDocContent.xml";

        public string FilePath
        {
            get { return _fPath; }
            set { _fPath = value; }
        }

        XDocument _doc;

        public FormMain()
        {
            InitializeComponent();
            if (File.Exists(_fPath))
                _doc = XDocument.Load(_fPath);
            else
                MessageBox.Show("No Such File");

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UpdateTreeViewGuides();
        }

        private void UpdateTreeViewGuides()
        {
            var root = _doc.Element("root");
            TreeNode rootNode = new TreeNode(root.Attribute("name").Value, 0, 0);

            var chapters = root.Elements("chapter");
            foreach (var chpt in chapters)
            {
                TreeNode chapterNode = new TreeNode(chpt.Attribute("name").Value, 1, 1);

                var paragraphs = chpt.Elements("paragraph");
                foreach (var par in paragraphs)
                {
                    TreeNode paragraphNode = new TreeNode(par.Attribute("name").Value, 2, 2);
                    chapterNode.Nodes.Add(paragraphNode);
                }

                rootNode.Nodes.Add(chapterNode);
            }
            treeViewDocContent.Nodes.Add(rootNode);
            treeViewDocContent.ExpandAll();
        }

        private void TreeViewDocContent_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            richTextBoxDocRead.Text = e.Node.Text;
        }

        private void TreeViewDocContent_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeName = treeViewDocContent.SelectedNode.Text;
            string pathToNode = @"..\..\Guides\Guide_01\" + nodeName + ".rtf";
            if (File.Exists(pathToNode))
            {
                richTextBoxDocRead.LoadFile(pathToNode);
            }
        }
    }
}
