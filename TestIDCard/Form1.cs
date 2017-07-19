using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThaiNationalIDCard;

namespace TestIDCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idcard = new ThaiIDCard();
            lbLibVersion.Text = "LibThaiIDCard version: " + idcard.Version();
        }
        private ThaiIDCard idcard;

        public void Log(string text = "")
        {
            if (txtBoxLog.InvokeRequired)
            {
                txtBoxLog.BeginInvoke(new MethodInvoker(delegate { txtBoxLog.AppendText(text); }));
            }
            else
            {
                txtBoxLog.AppendText(text);
            }
        }
        public void LogLine(string text = "")
        {
            if (txtBoxLog.InvokeRequired)
            {
                txtBoxLog.BeginInvoke(new MethodInvoker(delegate { txtBoxLog.AppendText(text + Environment.NewLine); }));
            }
            else
            {
                txtBoxLog.AppendText(text + Environment.NewLine);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_cid.Text = "Reading...";
                Refresh();
                idcard.eventPhotoProgress += new handlePhotoProgress(photoProgress);
                Personal personal = idcard.readAll();
                Personal readImg = idcard.readAllPhoto();
                if (personal != null)
                {
                    lbl_cid.Text = personal.Citizenid;
                    lbl_birthday.Text = personal.Birthday.ToString("dd/MM/yyyy");
                    lbl_sex.Text = personal.Sex;
                    lbl_th_prefix.Text = personal.Th_Prefix;
                    lbl_th_firstname.Text = personal.Th_Firstname;
                    lbl_th_lastname.Text = personal.Th_Lastname;
                    lbl_en_prefix.Text = personal.En_Prefix;
                    lbl_en_firstname.Text = personal.En_Firstname;
                    lbl_en_lastname.Text = personal.En_Lastname;
                    lbl_issue.Text = personal.Issue.ToString("dd/MM/yyyy");
                    lbl_expire.Text = personal.Expire.ToString("dd/MM/yyyy");
                    pictureBox1.Image = readImg.PhotoBitmap;

                    LogLine(personal.Address);
                    LogLine(personal.addrHouseNo); // บ้านเลขที่ 
                    LogLine(personal.addrVillageNo); // หมู่ที่
                    LogLine(personal.addrLane); // ซอย
                    LogLine(personal.addrRoad); // ถนน
                    LogLine(personal.addrTambol);
                    LogLine(personal.addrAmphur);
                    LogLine(personal.addrProvince);
                }
                else if (idcard.ErrorCode() > 0)
                {
                    MessageBox.Show(idcard.Error());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void photoProgress(int value, int maximum)
        {
            if (txtBoxLog.InvokeRequired)
            {
                if (PhotoProgressBar1.Maximum > value)
                    PhotoProgressBar1.BeginInvoke(new MethodInvoker(delegate { PhotoProgressBar1.Maximum = maximum; }));
                //fix progress bar sync.
                if (PhotoProgressBar1.Maximum > value)
                    PhotoProgressBar1.BeginInvoke(new MethodInvoker(delegate { PhotoProgressBar1.Value = value + 1; }));

                PhotoProgressBar1.BeginInvoke(new MethodInvoker(delegate { PhotoProgressBar1.Value = value; }));
            }
            else
            {
                if (PhotoProgressBar1.Maximum != maximum)
                    PhotoProgressBar1.Maximum = maximum;

                //fix progress bar sycn
                if (PhotoProgressBar1.Maximum > value)
                    PhotoProgressBar1.Value = value + 1;

                PhotoProgressBar1.Value = value;
            }
            Refresh();
        }

        public void CardInserted(Personal personal)
        {
            if (personal == null)
                return;
            lbl_cid.BeginInvoke(new MethodInvoker(delegate { lbl_cid.Text = personal.Citizenid; }));
            lbl_birthday.BeginInvoke(new MethodInvoker(delegate { lbl_birthday.Text = personal.Birthday.ToString("dd/MM/yyyy"); }));
            lbl_sex.BeginInvoke(new MethodInvoker(delegate { lbl_sex.Text = personal.Sex; }));
            lbl_th_prefix.BeginInvoke(new MethodInvoker(delegate { lbl_th_prefix.Text = personal.Th_Prefix; }));
            lbl_th_firstname.BeginInvoke(new MethodInvoker(delegate { lbl_th_firstname.Text = personal.Th_Firstname; }));
            lbl_th_lastname.BeginInvoke(new MethodInvoker(delegate { lbl_th_lastname.Text = personal.Th_Lastname; }));
            lbl_en_prefix.BeginInvoke(new MethodInvoker(delegate { lbl_en_prefix.Text = personal.En_Prefix; }));
            lbl_en_firstname.BeginInvoke(new MethodInvoker(delegate { lbl_en_firstname.Text = personal.En_Firstname; }));
            lbl_en_lastname.BeginInvoke(new MethodInvoker(delegate { lbl_en_lastname.Text = personal.En_Lastname; }));
            lbl_issue.BeginInvoke(new MethodInvoker(delegate { lbl_issue.Text = personal.Issue.ToString("dd/MM/yyyy"); }));
            lbl_expire.BeginInvoke(new MethodInvoker(delegate { lbl_expire.Text = personal.Expire.ToString("dd/MM/yyyy"); }));
            pictureBox1.BeginInvoke(new MethodInvoker(delegate { pictureBox1.Image = personal.PhotoBitmap; }));
        }
    }
}
