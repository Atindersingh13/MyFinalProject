
namespace MyFinalProject
{
    partial class Eftpos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eftpos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.eftposamount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cashoutamount = new System.Windows.Forms.TextBox();
            this.TotalAmount = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Proccessing = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Proccessing.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(451, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyFinalProject.Properties.Resources._10;
            this.pictureBox2.Location = new System.Drawing.Point(451, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MyFinalProject.Properties.Resources._50;
            this.pictureBox3.Location = new System.Drawing.Point(451, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MyFinalProject.Properties.Resources._5;
            this.pictureBox4.Location = new System.Drawing.Point(451, 265);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(214, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MyFinalProject.Properties.Resources._20;
            this.pictureBox5.Location = new System.Drawing.Point(451, 133);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(214, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // eftposamount
            // 
            this.eftposamount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.eftposamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eftposamount.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eftposamount.Location = new System.Drawing.Point(267, 34);
            this.eftposamount.Multiline = true;
            this.eftposamount.Name = "eftposamount";
            this.eftposamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eftposamount.Size = new System.Drawing.Size(103, 36);
            this.eftposamount.TabIndex = 5;
       //     this.eftposamount.TextChanged += new System.EventHandler(this.eftposamount_TextChanged);
            this.eftposamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eftposamount_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.Proccessing);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TotalAmount);
            this.groupBox2.Controls.Add(this.Cashoutamount);
            this.groupBox2.Controls.Add(this.eftposamount);
            this.groupBox2.Location = new System.Drawing.Point(1, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 236);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
        //    this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Cashoutamount
            // 
            this.Cashoutamount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Cashoutamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cashoutamount.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cashoutamount.Location = new System.Drawing.Point(267, 101);
            this.Cashoutamount.Multiline = true;
            this.Cashoutamount.Name = "Cashoutamount";
            this.Cashoutamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cashoutamount.Size = new System.Drawing.Size(103, 36);
            this.Cashoutamount.TabIndex = 6;
            this.Cashoutamount.TextChanged += new System.EventHandler(this.Cashoutamount_TextChanged);
            this.Cashoutamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cashoutamount_KeyDown_1);
         //   this.Cashoutamount.MouseHover += new System.EventHandler(this.Cashoutamount_MouseHover);
            // 
            // TotalAmount
            // 
            this.TotalAmount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(267, 174);
            this.TotalAmount.Multiline = true;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalAmount.Size = new System.Drawing.Size(103, 36);
            this.TotalAmount.TabIndex = 7;
            this.TotalAmount.TextChanged += new System.EventHandler(this.TotalAmount_TextChanged);
            this.TotalAmount.MouseHover += new System.EventHandler(this.TotalAmount_MouseHover);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.Navy;
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.SystemColors.Control;
            this.btnok.Location = new System.Drawing.Point(69, 252);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(302, 73);
            this.btnok.TabIndex = 68;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Purchase  Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cash Out  Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total  Amount";
            // 
            // Proccessing
            // 
            this.Proccessing.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.Proccessing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Proccessing.Controls.Add(this.OK);
            this.Proccessing.Controls.Add(this.label4);
            this.Proccessing.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Proccessing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Proccessing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Proccessing.Location = new System.Drawing.Point(6, 83);
            this.Proccessing.Name = "Proccessing";
            this.Proccessing.Size = new System.Drawing.Size(429, 100);
            this.Proccessing.TabIndex = 11;
            this.Proccessing.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "                         Proccessing\r\nThis Function Working With Eftpos machines\r" +
    "\n                           Thank you";
            // 
            // OK
            // 
            this.OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OK.Location = new System.Drawing.Point(161, 71);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Eftpos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(670, 328);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Eftpos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Cash Out Amount";
      //      this.Load += new System.EventHandler(this.Eftpos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Proccessing.ResumeLayout(false);
            this.Proccessing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox eftposamount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalAmount;
        private System.Windows.Forms.TextBox Cashoutamount;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.GroupBox Proccessing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OK;
    }
}