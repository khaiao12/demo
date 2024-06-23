namespace main
{
    partial class FormProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnNecklace = new System.Windows.Forms.Button();
            this.btnBracelet = new System.Windows.Forms.Button();
            this.btnEarrings = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWatch);
            this.panel1.Controls.Add(this.btnNecklace);
            this.panel1.Controls.Add(this.btnBracelet);
            this.panel1.Controls.Add(this.btnEarrings);
            this.panel1.Controls.Add(this.btnRing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 447);
            this.panel1.TabIndex = 7;
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(29, 376);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(133, 60);
            this.btnWatch.TabIndex = 9;
            this.btnWatch.Text = "Đồng hồ";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // btnNecklace
            // 
            this.btnNecklace.Location = new System.Drawing.Point(29, 283);
            this.btnNecklace.Name = "btnNecklace";
            this.btnNecklace.Size = new System.Drawing.Size(133, 60);
            this.btnNecklace.TabIndex = 8;
            this.btnNecklace.Text = "Dây chuyền";
            this.btnNecklace.UseVisualStyleBackColor = true;
            this.btnNecklace.Click += new System.EventHandler(this.btnNecklace_Click);
            // 
            // btnBracelet
            // 
            this.btnBracelet.Location = new System.Drawing.Point(29, 191);
            this.btnBracelet.Name = "btnBracelet";
            this.btnBracelet.Size = new System.Drawing.Size(133, 60);
            this.btnBracelet.TabIndex = 7;
            this.btnBracelet.Text = "Vòng tay";
            this.btnBracelet.UseVisualStyleBackColor = true;
            this.btnBracelet.Click += new System.EventHandler(this.btnBracelet_Click);
            // 
            // btnEarrings
            // 
            this.btnEarrings.Location = new System.Drawing.Point(29, 100);
            this.btnEarrings.Name = "btnEarrings";
            this.btnEarrings.Size = new System.Drawing.Size(133, 60);
            this.btnEarrings.TabIndex = 6;
            this.btnEarrings.Text = "Khuyên tai";
            this.btnEarrings.UseVisualStyleBackColor = true;
            this.btnEarrings.Click += new System.EventHandler(this.btnEarrings_Click);
            // 
            // btnRing
            // 
            this.btnRing.Location = new System.Drawing.Point(29, 10);
            this.btnRing.Name = "btnRing";
            this.btnRing.Size = new System.Drawing.Size(133, 60);
            this.btnRing.TabIndex = 5;
            this.btnRing.Text = "Nhẫn";
            this.btnRing.UseVisualStyleBackColor = true;
            this.btnRing.Click += new System.EventHandler(this.btnRing_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.AutoScroll = true;
            this.panelProduct.Controls.Add(this.richTextBox1);
            this.panelProduct.Controls.Add(this.pictureBox1);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProduct.Location = new System.Drawing.Point(190, 0);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(637, 447);
            this.panelProduct.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(112, 330);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(412, 96);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Cửa hàng kim cương DIAMONDS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::main.Properties.Resources.th__1_;
            this.pictureBox1.Location = new System.Drawing.Point(159, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(827, 447);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panel1);
            this.Name = "FormProduct";
            this.Text = "Product";
            this.panel1.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnNecklace;
        private System.Windows.Forms.Button btnBracelet;
        private System.Windows.Forms.Button btnEarrings;
        private System.Windows.Forms.Button btnRing;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}