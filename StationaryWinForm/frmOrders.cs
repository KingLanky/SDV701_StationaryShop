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
        //private clsOrder _Order;
        private static Dictionary<string, string> _OrdersList = new Dictionary<string, string>();
        //private static Dictionary<string, frmOrders> _OrderFormList = new Dictionary<string, frmOrders>();
        public frmOrders()
        {
            InitializeComponent();
        }

        public static void Run()
        {
            frmOrders lcOrderForm;

            lcOrderForm = new frmOrders();
            lcOrderForm.ShowDialog();

        }

        public async void UpdateInfoDisplay()
        {
            clsOrder lcOrder = await ServiceClient.GetOrderDetailsAsync(lstOrders.SelectedValue.ToString());

            rtbDetails.Text = lcOrder.ToString();

        }

        private async void UpdateOrderListDisplay()
        {
            lstOrders.DataSource = null;
            lstOrders.DataSource = await ServiceClient.GetOrdersAsync();

            CalcTotalIncome();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            //CreateOrderDic();
            UpdateOrderListDisplay();
        }

        private async void CreateOrderDic()
        {
            List<string> lcOrderIDList = await ServiceClient.GetOrdersAsync();
            clsOrder lcOrder;

            foreach (var ID in lcOrderIDList)
            {
                lcOrder = await ServiceClient.GetOrderDetailsAsync(ID);
                _OrdersList.Add(ID, lcOrder.CustomerName);
            }

        }

        private async void CalcTotalIncome()
        {
            //MessageBox.Show(Convert.ToString(lstOrders.Items));
            decimal lcIncome = 0;
            clsOrder lcOrder;

            foreach (var Order in lstOrders.Items)
            {
                lcOrder = await ServiceClient.GetOrderDetailsAsync(Order.ToString());
                lcIncome += lcOrder.OrderPrice;
            }

            lblTotalIncome.Text = "Total Income: $" + lcIncome.ToString("F");
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfoDisplay();
        }
    }
}
