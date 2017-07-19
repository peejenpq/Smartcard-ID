namespace TestIDCard
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtBoxLog = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_issue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PhotoProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_expire = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.lbl_en_lastname = new System.Windows.Forms.Label();
            this.lbl_en_firstname = new System.Windows.Forms.Label();
            this.lbl_en_prefix = new System.Windows.Forms.Label();
            this.lbl_th_lastname = new System.Windows.Forms.Label();
            this.lbl_th_firstname = new System.Windows.Forms.Label();
            this.lbl_th_prefix = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLibVersion = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(98, 31);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(91, 61);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtBoxLog
            // 
            this.txtBoxLog.Location = new System.Drawing.Point(3, 305);
            this.txtBoxLog.Multiline = true;
            this.txtBoxLog.Name = "txtBoxLog";
            this.txtBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxLog.Size = new System.Drawing.Size(530, 170);
            this.txtBoxLog.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(344, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 182);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(78, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "วันหมดอายุ";
            // 
            // lbl_issue
            // 
            this.lbl_issue.AutoSize = true;
            this.lbl_issue.Location = new System.Drawing.Point(147, 245);
            this.lbl_issue.Name = "lbl_issue";
            this.lbl_issue.Size = new System.Drawing.Size(47, 13);
            this.lbl_issue.TabIndex = 81;
            this.lbl_issue.Text = "lbl_issue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "วันออกบัตร";
            // 
            // PhotoProgressBar1
            // 
            this.PhotoProgressBar1.Location = new System.Drawing.Point(150, 276);
            this.PhotoProgressBar1.MarqueeAnimationSpeed = 0;
            this.PhotoProgressBar1.Name = "PhotoProgressBar1";
            this.PhotoProgressBar1.Size = new System.Drawing.Size(211, 23);
            this.PhotoProgressBar1.TabIndex = 79;
            // 
            // lbl_expire
            // 
            this.lbl_expire.AutoSize = true;
            this.lbl_expire.Location = new System.Drawing.Point(147, 258);
            this.lbl_expire.Name = "lbl_expire";
            this.lbl_expire.Size = new System.Drawing.Size(51, 13);
            this.lbl_expire.TabIndex = 83;
            this.lbl_expire.Text = "lbl_expire";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(147, 232);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(39, 13);
            this.lbl_sex.TabIndex = 78;
            this.lbl_sex.Text = "lbl_sex";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "เพศ";
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Location = new System.Drawing.Point(147, 219);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(60, 13);
            this.lbl_birthday.TabIndex = 76;
            this.lbl_birthday.Text = "lbl_birthday";
            // 
            // lbl_en_lastname
            // 
            this.lbl_en_lastname.AutoSize = true;
            this.lbl_en_lastname.Location = new System.Drawing.Point(147, 196);
            this.lbl_en_lastname.Name = "lbl_en_lastname";
            this.lbl_en_lastname.Size = new System.Drawing.Size(83, 13);
            this.lbl_en_lastname.TabIndex = 75;
            this.lbl_en_lastname.Text = "lbl_en_lastname";
            // 
            // lbl_en_firstname
            // 
            this.lbl_en_firstname.AutoSize = true;
            this.lbl_en_firstname.Location = new System.Drawing.Point(147, 183);
            this.lbl_en_firstname.Name = "lbl_en_firstname";
            this.lbl_en_firstname.Size = new System.Drawing.Size(83, 13);
            this.lbl_en_firstname.TabIndex = 74;
            this.lbl_en_firstname.Text = "lbl_en_firstname";
            // 
            // lbl_en_prefix
            // 
            this.lbl_en_prefix.AutoSize = true;
            this.lbl_en_prefix.Location = new System.Drawing.Point(147, 170);
            this.lbl_en_prefix.Name = "lbl_en_prefix";
            this.lbl_en_prefix.Size = new System.Drawing.Size(66, 13);
            this.lbl_en_prefix.TabIndex = 73;
            this.lbl_en_prefix.Text = "lbl_en_prefix";
            // 
            // lbl_th_lastname
            // 
            this.lbl_th_lastname.AutoSize = true;
            this.lbl_th_lastname.Location = new System.Drawing.Point(147, 147);
            this.lbl_th_lastname.Name = "lbl_th_lastname";
            this.lbl_th_lastname.Size = new System.Drawing.Size(80, 13);
            this.lbl_th_lastname.TabIndex = 72;
            this.lbl_th_lastname.Text = "lbl_th_lastname";
            // 
            // lbl_th_firstname
            // 
            this.lbl_th_firstname.AutoSize = true;
            this.lbl_th_firstname.Location = new System.Drawing.Point(147, 134);
            this.lbl_th_firstname.Name = "lbl_th_firstname";
            this.lbl_th_firstname.Size = new System.Drawing.Size(80, 13);
            this.lbl_th_firstname.TabIndex = 71;
            this.lbl_th_firstname.Text = "lbl_th_firstname";
            // 
            // lbl_th_prefix
            // 
            this.lbl_th_prefix.AutoSize = true;
            this.lbl_th_prefix.Location = new System.Drawing.Point(147, 121);
            this.lbl_th_prefix.Name = "lbl_th_prefix";
            this.lbl_th_prefix.Size = new System.Drawing.Size(63, 13);
            this.lbl_th_prefix.TabIndex = 70;
            this.lbl_th_prefix.Text = "lbl_th_prefix";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "วันเกิด";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "lastname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "firstname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "prefix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "สกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "คำนำ";
            // 
            // lbl_cid
            // 
            this.lbl_cid.AutoSize = true;
            this.lbl_cid.Location = new System.Drawing.Point(147, 108);
            this.lbl_cid.Name = "lbl_cid";
            this.lbl_cid.Size = new System.Drawing.Size(37, 13);
            this.lbl_cid.TabIndex = 62;
            this.lbl_cid.Text = "lbl_cid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "รหัสประจำตัวประชาชน";
            // 
            // lbLibVersion
            // 
            this.lbLibVersion.AutoSize = true;
            this.lbLibVersion.Location = new System.Drawing.Point(28, 9);
            this.lbLibVersion.Name = "lbLibVersion";
            this.lbLibVersion.Size = new System.Drawing.Size(41, 13);
            this.lbLibVersion.TabIndex = 84;
            this.lbLibVersion.Text = "label10";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 487);
            this.Controls.Add(this.lbLibVersion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_issue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PhotoProgressBar1);
            this.Controls.Add(this.lbl_expire);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_birthday);
            this.Controls.Add(this.lbl_en_lastname);
            this.Controls.Add(this.lbl_en_firstname);
            this.Controls.Add(this.lbl_en_prefix);
            this.Controls.Add(this.lbl_th_lastname);
            this.Controls.Add(this.lbl_th_firstname);
            this.Controls.Add(this.lbl_th_prefix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_cid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxLog);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtBoxLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_issue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar PhotoProgressBar1;
        private System.Windows.Forms.Label lbl_expire;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.Label lbl_en_lastname;
        private System.Windows.Forms.Label lbl_en_firstname;
        private System.Windows.Forms.Label lbl_en_prefix;
        private System.Windows.Forms.Label lbl_th_lastname;
        private System.Windows.Forms.Label lbl_th_firstname;
        private System.Windows.Forms.Label lbl_th_prefix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLibVersion;
        private System.Windows.Forms.ImageList imageList1;
    }
}

