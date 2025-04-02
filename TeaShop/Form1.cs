using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeaShop
{
    public partial class Form1 : Form
    {
        List<Customer> customers = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = "items.txt"; 
            LoadComboBoxItems(filePath);
        }

        private void LoadComboBoxItems(string filePath)
        {
            cb_item.Items.Clear();

            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            cb_item.Items.Add(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while reading the file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("The specified file does not exist.");
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            String S = "";

            foreach(var c in customers)
            {
                S += c.Name + " " + c.Phone + " " + c.Address + "\n";
            }

            StreamWriter MyFile = new StreamWriter("customer.txt");
            MyFile.Write(S);
            MyFile.Close();
        }

        private void bt_Add_customer_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string phone = tb_phone.Text;
            string address = tb_address.Text;   
            customers.Add(new Customer { Name = name, Phone = phone, Address = address });
        }
    }
}



       

        
