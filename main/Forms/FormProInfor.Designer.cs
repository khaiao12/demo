namespace main.Forms
{
    partial class FormProInfor
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
            this.btnBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaindia = new System.Windows.Forms.Label();
            this.lblSidedia = new System.Windows.Forms.Label();
            this.lblDiaCover = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuy.Location = new System.Drawing.Point(362, 280);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(107, 55);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Mua";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kim cương chính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kim cương phụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vỏ kim cương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "$";
            // 
            // lblMaindia
            // 
            this.lblMaindia.BackColor = System.Drawing.Color.White;
            this.lblMaindia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaindia.Location = new System.Drawing.Point(154, 31);
            this.lblMaindia.Name = "lblMaindia";
            this.lblMaindia.Size = new System.Drawing.Size(240, 32);
            this.lblMaindia.TabIndex = 11;
            this.lblMaindia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSidedia
            // 
            this.lblSidedia.BackColor = System.Drawing.Color.White;
            this.lblSidedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSidedia.Location = new System.Drawing.Point(154, 99);
            this.lblSidedia.Name = "lblSidedia";
            this.lblSidedia.Size = new System.Drawing.Size(240, 32);
            this.lblSidedia.TabIndex = 12;
            this.lblSidedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiaCover
            // 
            this.lblDiaCover.BackColor = System.Drawing.Color.White;
            this.lblDiaCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiaCover.Location = new System.Drawing.Point(154, 163);
            this.lblDiaCover.Name = "lblDiaCover";
            this.lblDiaCover.Size = new System.Drawing.Size(240, 32);
            this.lblDiaCover.TabIndex = 13;
            this.lblDiaCover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(154, 231);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(180, 32);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.Location = new System.Drawing.Point(15, 280);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(107, 55);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FormProInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 347);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDiaCover);
            this.Controls.Add(this.lblSidedia);
            this.Controls.Add(this.lblMaindia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProInfor";
            this.Text = "information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaindia;
        private System.Windows.Forms.Label lblSidedia;
        private System.Windows.Forms.Label lblDiaCover;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnShow;
    }
}