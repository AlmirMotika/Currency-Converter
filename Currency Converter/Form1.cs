using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Conv_btn_Click(object sender, EventArgs e)
        {
            double i = double.Parse(amount_txt.Text);
            
            if (from_combo.SelectedItem.ToString() == "Euro" && to_combo.SelectedItem.ToString() == "RSD")
            {
                double conver = i * 117.2308;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t RSD";
            }
            if (from_combo.SelectedItem.ToString() == "Euro" && to_combo.SelectedItem.ToString() == "Dollar")
            {
                double conver = i * 1.1479;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t Dollar";
            }
            if (from_combo.SelectedItem.ToString() == "Euro" && to_combo.SelectedItem.ToString() == "BAM")
            {
                double conver = i * 1.95583;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t BAM";
            }                             
            if (from_combo.SelectedItem.ToString() == "BAM" && to_combo.SelectedItem.ToString() == "Euro")
            {
                double conver = i / 1.95583;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t Euro";
            }
            if (from_combo.SelectedItem.ToString() == "BAM" && to_combo.SelectedItem.ToString() == "Dollar")
            {
                double conver = i / 115;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t Dollar";
            }
            
            if (from_combo.SelectedItem.ToString() == "BAM" && to_combo.SelectedItem.ToString() == "RSD")
            {
                double conver = i * 59.9391;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t RSD";
            }
            if (from_combo.SelectedItem.ToString() == "Dollar" && to_combo.SelectedItem.ToString() == "Euro")
            {
                double conver = i / 1.1479;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t Euro";
            }
            if (from_combo.SelectedItem.ToString() == "Dollar" && to_combo.SelectedItem.ToString() == "BAM")
            {
                double conver = i / 115;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t BAM";
            }
            if (from_combo.SelectedItem.ToString() == "Dollar" && to_combo.SelectedItem.ToString() == "RSD")
            {
                double conver = i * 102.126;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t RSD";
            }
            if (from_combo.SelectedItem.ToString() == "RSD" && to_combo.SelectedItem.ToString() == "Euro")
            {
                double conver = i / 117.2308;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t Euro";
            }
            if (from_combo.SelectedItem.ToString() == "RSD" && to_combo.SelectedItem.ToString() == "BAM")
            {
                double conver = i / 59.9391;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t BAM";
            }
            if (from_combo.SelectedItem.ToString() == "RSD" && to_combo.SelectedItem.ToString() == "Dollar")
            {
                double conver = i / 102.126;
                Display_txt.Text = "Converted Amount : " + Math.Round(conver, 5) + "\t Dollar";
            }
        }
    }
}
