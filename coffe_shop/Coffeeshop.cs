using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffe_shop
{
    public partial class Coffeeshop : Form
    {
        public Coffeeshop()
        {
            InitializeComponent();
        }

        
        private void savebutton1_Click(object sender, EventArgs e)
        {
            string order;
            string quantity;
            int q;
            int totalprice;
            int price;
            price = 0;
            totalprice = 0;
            order = ordercomboBox1.Text;
            quantity = quantitytextBox4.Text;
            q = int.Parse(quantity);

            if(order== "Black-120")
            {
                price = 120;
                totalprice = price * q;
            }
            else if(order== "Cold-100")
            {
                price = 100;
                totalprice = price * q;
            }
            else if (order == "Hot-90")
            {  
                price = 90;
                totalprice = price * q;
            }
            else if (order == "Regular-80")
            {
                price = 80;
                totalprice = price * q;
            }

            displayrichTextBox1.Text= ("Customer name: " + nametextBox1.Text+ Environment.NewLine + Environment.NewLine + "Contact No: " +contacttextBox2.Text
                                        + Environment.NewLine+ Environment.NewLine + "address:" +addresstextBox3.Text+ Environment.NewLine+ Environment.NewLine
                                        + "order:" +ordercomboBox1.Text+ Environment.NewLine + Environment.NewLine + "quantity:" +quantitytextBox4.Text
                                        + Environment.NewLine+ Environment.NewLine + "total price:" +totalprice );
        }

        private void contacttextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                     e.Handled = true;
                }
        }

        private void quantitytextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
