using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_management.Pages
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
