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
    public partial class Rep : Form
    {
        public Rep()
        {
            InitializeComponent();
        }
        public class supproductlocal
        {
            public int NationalId { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public double salary { get; set; }
            public double TargetSale { get; set; }
            public double commuation { get; set; }


        }
        List<supproductlocal> supproductlocalList = new List<supproductlocal>();
        private void button20_Click(object sender, EventArgs e)
        {
            ListViewItem items = new ListViewItem(NationalIdRepTxt.Text, 0);
            items.SubItems.Add(NameRepTxt.Text);
            items.SubItems.Add(phoneRepTxt.Text);
            items.SubItems.Add(AddressText.Text);
            items.SubItems.Add(salaryRepTxt.Text);
            items.SubItems.Add(SaleTargetTxt.Text);
            items.SubItems.Add(ComuationRepTxt.Text);
            
            listView1.Items.AddRange(new ListViewItem[] { items });
            
            supproductlocal locallist = new supproductlocal();
            //add property to locallist
            locallist.NationalId = int.Parse(NationalIdRepTxt.Text);
            locallist.Name = NameRepTxt.Text;
            locallist.Phone = phoneRepTxt.Text;
            locallist.Address = AddressText.Text;
            locallist.salary =double.Parse(salaryRepTxt.Text);
            locallist.TargetSale =double.Parse(SaleTargetTxt.Text);
            locallist.Phone = SaleTargetTxt.Text;
            supproductlocalList.Add(locallist);
        }

        private void Rep_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }
    }
}
