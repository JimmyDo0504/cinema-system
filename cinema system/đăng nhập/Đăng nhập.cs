using rạp_chiếu_phim.admin;
using rạp_chiếu_phim.khách_hàng;
using rạp_chiếu_phim.nhân_viên;
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

namespace rạp_chiếu_phim.đăng_nhập
{
    public partial class Đăng_nhập : Form
    {
        private string captchaText;
        public Đăng_nhập()
        {
            InitializeComponent();
            GenerateCaptcha();

            UC_Đăng_ký ucDangKy = new UC_Đăng_ký();
            ucDangKy.Dock = DockStyle.Fill;

            tabRegister.Controls.Add(ucDangKy);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Hãy điền thông tin vào tên đăng nhập");
                return;
            }
            else
            {
                if (txtEmail.Text == "admin" && txtPassword.Text == "1" && check_captcha())
                {
                    MessageBox.Show("Đăng nhập với tư cách quản trị viên thành công!");
                    admin_design ad = new admin_design();
                    ad.Show();
                    this.Hide();
                }
                else
                {
                    if (txtEmail.Text == "staff" && txtPassword.Text == "1" && check_captcha())
                    {
                        MessageBox.Show("Đăng nhập với tư cách nhân viên thành công!");
                        StaffDesign sd = new StaffDesign();
                        sd.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (txtEmail.Text == "1" && txtPassword.Text == "1" && check_captcha())
                        {
                            MessageBox.Show("Đăng nhập với tư cách khách hàng thành công!");
                            UserDesign ud = new UserDesign("abc");
                            ud.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                        }
                    }

                }
            }
        }

        private void GenerateCaptcha()
        {
            Bitmap bmp = new Bitmap(picCaptcha.Width, picCaptcha.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.Clear(Color.White);

            Random rnd = new Random();
            captchaText = "";
            string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ0123456789";
            for (int i = 0; i < 5; i++)
            {
                captchaText += chars[rnd.Next(chars.Length)];
            }

            using (Font font = new Font("Arial", 20, FontStyle.Bold))
            {
                g.DrawString(captchaText, font, Brushes.Black, new PointF(10, 10));
            }

            // vẽ thêm vài đường loằng ngoằng
            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(Pens.Gray, rnd.Next(0, bmp.Width), rnd.Next(0, bmp.Height),
                                      rnd.Next(0, bmp.Width), rnd.Next(0, bmp.Height));
            }

            picCaptcha.Image = bmp;
        }
        private Boolean check_captcha()
        {
            if (txtCaptcha.Text != captchaText)
            {
                MessageBox.Show("Mã xác nhận không đúng, vui lòng thử lại.");
                GenerateCaptcha();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle rect = e.Bounds;

            // nếu tab đang được chọn -> nền đỏ, chữ trắng
            if (e.Index == tabControl.SelectedIndex)
            {
                e.Graphics.FillRectangle(Brushes.Red, rect);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, this.Font,
                                      rect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            else
            {
                // tab chưa chọn -> nền trắng, chữ đỏ
                e.Graphics.FillRectangle(Brushes.White, rect);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, this.Font,
                                      rect, Color.Red, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            UserDesign ud = new UserDesign();
            ud.Show();
            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
