using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationaryWinForm
{
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();

            string[] tempOrders = { "1 \t $40.00","2 \t $37.50","3 \t $4.99"};
            lbOrders.DataSource = tempOrders;

            rtbDetails.Text = "Name: \t\t Velocity \n" +
                "Brand: \t\t BIC \n" +
                "Type: \t\t Pencil \n" +
                "Quantity: \t\t 5 \n" +
                "Order Cost: \t $37.5 \n" +
                "Customer Name: \t Franky Johns \n" +
                "Customer No. \t 022 555 1923";
        }
    }
}
