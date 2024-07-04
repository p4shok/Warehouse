using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Storage : Form
    {
        public Storage()
        {
            InitializeComponent();


            int zero = 0;
            QuantityLabel.Text = zero.ToString();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {

        }

        private void Storage_Load(object sender, EventArgs e)
        {

        }
    }
}
