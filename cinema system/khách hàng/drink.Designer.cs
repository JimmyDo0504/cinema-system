namespace rạp_chiếu_phim.khách_hàng
{
    partial class drink
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoadontxt = new System.Windows.Forms.Label();
            this.phimtxt = new System.Windows.Forms.Label();
            this.drinktxt = new System.Windows.Forms.Label();
            this.sumtxt = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.order_thức_uống1 = new rạp_chiếu_phim.khách_hàng.Order_thức_uống();
            this.order_thức_uống2 = new rạp_chiếu_phim.khách_hàng.Order_thức_uống();
            this.SuspendLayout();
            // 
            // hoadontxt
            // 
            this.hoadontxt.AutoSize = true;
            this.hoadontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoadontxt.Location = new System.Drawing.Point(848, 116);
            this.hoadontxt.Name = "hoadontxt";
            this.hoadontxt.Size = new System.Drawing.Size(137, 32);
            this.hoadontxt.TabIndex = 3;
            this.hoadontxt.Text = "Hóa đơn:";
            this.hoadontxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // phimtxt
            // 
            this.phimtxt.AutoSize = true;
            this.phimtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phimtxt.Location = new System.Drawing.Point(888, 159);
            this.phimtxt.Name = "phimtxt";
            this.phimtxt.Size = new System.Drawing.Size(97, 18);
            this.phimtxt.TabIndex = 4;
            this.phimtxt.Text = "Vé xem phim:";
            // 
            // drinktxt
            // 
            this.drinktxt.AutoSize = true;
            this.drinktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinktxt.Location = new System.Drawing.Point(888, 194);
            this.drinktxt.Name = "drinktxt";
            this.drinktxt.Size = new System.Drawing.Size(99, 18);
            this.drinktxt.TabIndex = 5;
            this.drinktxt.Text = "Vé đồ uống   :";
            // 
            // sumtxt
            // 
            this.sumtxt.AutoSize = true;
            this.sumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumtxt.Location = new System.Drawing.Point(848, 231);
            this.sumtxt.Name = "sumtxt";
            this.sumtxt.Size = new System.Drawing.Size(166, 32);
            this.sumtxt.TabIndex = 6;
            this.sumtxt.Text = "Tổng cộng:";
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(854, 613);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(125, 35);
            this.Back_btn.TabIndex = 7;
            this.Back_btn.Text = "Quay lại";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(1025, 613);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(125, 35);
            this.next_btn.TabIndex = 8;
            this.next_btn.Text = "Tiếp theo";
            this.next_btn.UseVisualStyleBackColor = true;
            // 
            // order_thức_uống1
            // 
            this.order_thức_uống1.BackColor = System.Drawing.Color.White;
            this.order_thức_uống1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.order_thức_uống1.Location = new System.Drawing.Point(3, 3);
            this.order_thức_uống1.Name = "order_thức_uống1";
            this.order_thức_uống1.Size = new System.Drawing.Size(640, 238);
            this.order_thức_uống1.TabIndex = 0;
            this.order_thức_uống1.Load += new System.EventHandler(this.order_thức_uống1_Load);
            // 
            // order_thức_uống2
            // 
            this.order_thức_uống2.BackColor = System.Drawing.Color.White;
            this.order_thức_uống2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.order_thức_uống2.Location = new System.Drawing.Point(3, 247);
            this.order_thức_uống2.Name = "order_thức_uống2";
            this.order_thức_uống2.Size = new System.Drawing.Size(640, 238);
            this.order_thức_uống2.TabIndex = 9;
            // 
            // drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 698);
            this.Controls.Add(this.order_thức_uống2);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.sumtxt);
            this.Controls.Add(this.drinktxt);
            this.Controls.Add(this.phimtxt);
            this.Controls.Add(this.hoadontxt);
            this.Controls.Add(this.order_thức_uống1);
            this.Name = "drink";
            this.Text = "drink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Order_thức_uống order_thức_uống1;
        private System.Windows.Forms.Label hoadontxt;
        private System.Windows.Forms.Label phimtxt;
        private System.Windows.Forms.Label drinktxt;
        private System.Windows.Forms.Label sumtxt;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button next_btn;
        private Order_thức_uống order_thức_uống2;
    }
}