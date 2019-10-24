using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNew
{
    public partial class FormOfClient : Form
    {
        public FormOfClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        projectEntities1 context = new projectEntities1();
        Representitive x;
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void FormOfClient_Load(object sender, EventArgs e)
        {
            int numberOfBill;
            ClientBill clientB = context.ClientBills.OrderByDescending(c => c.ID).FirstOrDefault();
            if (clientB == null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9HH57Q0\MSSQLSEVEREX;Initial Catalog=project;Integrated Security=True");

                SqlCommand command = new SqlCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DBCC CHECKIDENT ('clientBills',RESEED,0)";
                command.ExecuteNonQuery();
                connection.Close();

                numberOfBill = 1;
                labelNumberBill.Text = numberOfBill.ToString();
            }
            else
            {
                numberOfBill = int.Parse(clientB.ID.ToString());
                numberOfBill++;
                labelNumberBill.Text = numberOfBill.ToString();
            }
            List<Representitive> rep = context.Representitives.ToList();
            rpresentiveCombo.DataSource = rep;
            rpresentiveCombo.DisplayMember = "Name";

            //------------------------fill name of product------------
            List<Product> ProductList = context.Products.ToList();
            productComboFromRepresentive.DataSource = ProductList;
            productComboFromRepresentive.DisplayMember = "Name";
        }

        private void button8_Click(object sender, EventArgs e)
        {


            // string RepresentiveName = null;
            if (TypeBillCombo.SelectedIndex == -1)
            {
                MessageBox.Show("لابد من ادخال نوع الفاتوره اولا"); return;
            }
            // if (labelRepresentitve.Text == "")
            //{
            LabelTypeOfBill.Visible = true;
            LabelTypeOfBill.Text = TypeBillCombo.Text;
            TypeBillCombo.Visible = false;
            // }

            if (rpresentiveCombo.SelectedIndex == -1)
            { MessageBox.Show("لابد من أدخال أسم المندوب اولا"); return; }
            // if (.Text == "")
            // {
            //RepresentiveName= rpresentiveCombo.Text;
            labelRepresentitve.Visible = true;
            labelRepresentitve.Text = rpresentiveCombo.Text;
            rpresentiveCombo.Visible = false;
            // }
            x = (Representitive)rpresentiveCombo.SelectedItem;
            var prdN = productComboFromRepresentive.Text.ToString();
            var prd = context.Products.Where(n => n.Name == prdN).FirstOrDefault();
            var y = context.RepresentitiveBillDetails
                  .Where(p => p.RepresentitiveBill.Representitive_NationalID == x.NationalID && p.ProductObj_ID == prd.ID).FirstOrDefault();
            if (int.Parse(numericUQouantity.Value.ToString()) > int.Parse(y.GivenAmount.ToString()))
            { MessageBox.Show("الكميه غير متاحه عند المندوب"); return; }
        }

        private void rpresentiveCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            x = (Representitive)rpresentiveCombo.SelectedItem;
            string repName=rpresentiveCombo.SelectedItem.ToString();
            var y = context.RepresentitiveBillDetails
                  .Where(p => p.RepresentitiveBill.Representitive_NationalID == x.NationalID);
            List<Product> ProductList = new List<Product>();
            foreach (var item in y)
            {
               Product ProdcutOfRep= context.Products.FirstOrDefault(p => p.ID == item.ProductObj_ID);
                ProductList.Add(ProdcutOfRep);
            }
            productComboFromRepresentive.DataSource= ProductList;
            productComboFromRepresentive.DisplayMember = "Name";
        }

        private void productComboFromRepresentive_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int numberOfBill;
            ClientBill clientB = context.ClientBills.OrderByDescending(c => c.ID).FirstOrDefault();
            if (clientB == null)
            {
                numberOfBill = 1;
                labelNumberBill.Text = numberOfBill.ToString();
            }
            else
            {
                numberOfBill = int.Parse(clientB.ID.ToString());
                numberOfBill++;
                labelNumberBill.Text = numberOfBill.ToString();
            }
        }
    }
}
