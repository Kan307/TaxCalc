using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int price;
            bool success = int.TryParse(this.priceBox.Text, out price);

            if(success)
            {
                int taxPrice = (int)(price * 1.1);
                this.taxpricebox.Text = taxPrice.ToString();

            }
            else
            {
                MessageBox.Show("正しく入力して下さい");
            }
        }
    }
}
