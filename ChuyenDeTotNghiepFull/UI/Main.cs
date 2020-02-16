using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenDeTotNghiepFull
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ActionLoginClick(object sender, EventArgs e)
        {
            var _Login = new UI.Login();
            _Login.MdiParent = this;
            _Login.Show();
            //Application.Run(_Login);
        }

        private void ActionLogoutClick(object sender, EventArgs e)
        {
            //TODO: Code show window alert login
        }

        private void ActionExitClick(object sender, EventArgs e)
        {
            //TODO: Code show window alert exit app
        }

        private void ActionToAccountManager(object sender, EventArgs e)
        {
            var _AccountManager = new UI.AccountManager();
            _AccountManager.MdiParent = this;
            _AccountManager.Show();
            //Application.Run(_AccountManager);
        }

        private void ActionToStaffManager(object sender, EventArgs e)
        {
            var _StaffManager = new UI.StaffManager();
            _StaffManager.MdiParent = this;
            _StaffManager.Show();
            //Application.Run(_StaffManager);
        }

        private void ActionBillManager(object sender, EventArgs e)
        {
            var _BillManager = new UI.BillManager();
            _BillManager.MdiParent = this;
            _BillManager.Show();
            //Application.Run(_BillManager);
        }

        private void ActionToCustomerManager(object sender, EventArgs e)
        {
            var _CustomerManager = new UI.CustomerManager();
            _CustomerManager.MdiParent = this;
            _CustomerManager.Show();
            //Application.Run(_CustomerManager);
        }

        private void ActionToSupplierManager(object sender, EventArgs e)
        {
            var _SupplierManager = new UI.SupplierManager();
            _SupplierManager.MdiParent = this;
            _SupplierManager.Show();
            //Application.Run(_SupplierManager);
        }

        private void ActionToOrderManager(object sender, EventArgs e)
        {
            var _OrderManager = new UI.OrderManager();
            _OrderManager.MdiParent = this;
            _OrderManager.Show();
            //Application.Run(_OrderManager);
        }

        private void ActionToAboutApp(object sender, EventArgs e)
        {
            //TODO: Show window you can see all infomation about app
        }

        private void ActionToFeedBack(object sender, EventArgs e)
        {
            //TODO: Show window you can write your feedback
        }
    }
}
