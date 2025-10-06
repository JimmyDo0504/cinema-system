using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rạp_chiếu_phim.khách_hàng
{
    public partial class drink : Form
    {
        public drink()
        {
            InitializeComponent();
        }

        public drink(int a)
        {
            InitializeComponent();
            string b = "Vé xem phim: " + a.ToString() + " đ";
            phimtxt.Text = b;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void order_thức_uống1_Load(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            phòng_chiếu pc = new phòng_chiếu();
            pc.Show();
            this.Hide();
        }
    }
}
