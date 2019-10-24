using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNew
{
    public partial class Form1 : Form
    {
        projectEntities1 context = new projectEntities1();
        public Form1()
        {
            InitializeComponent();
        }
        public class supproductlocal
        {
            public String CatName { get; set; }
      

        }
        List<supproductlocal> supproductlocalList = new List<supproductlocal>();
        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem items = new ListViewItem(CategoryText.Text,0);
            //items.SubItems.Add(TextBox1.text);
            CategoryListView.Items.AddRange(new ListViewItem[] { items });
            supproductlocal locallist = new supproductlocal();
            locallist.CatName = CategoryText.Text;
            supproductlocalList.Add(locallist);



        }

        private void button2_Click(object sender, EventArgs e)
        {
           // 
        }

        private void CategoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryListView.SelectedItems.Count == 0)
            { return; }
            else
            { 
            //row column
            CategoryText.Text = CategoryListView.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = CategoryListView.Items.Count - 1; i >= 0; i--)
            {
                if (CategoryListView.Items[i].Selected)
                {
                    CategoryListView.Items[i].Remove();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category newCat = new Category();
            foreach (var item in supproductlocalList)
            {
                newCat.Name = item.CatName;
                context.Categories.Add(newCat);
                context.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
