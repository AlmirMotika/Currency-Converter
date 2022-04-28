namespace Currency_Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.from_combo = new System.Windows.Forms.ComboBox();
            this.to_combo = new System.Windows.Forms.ComboBox();
            this.Display_txt = new System.Windows.Forms.Label();
            this.Conv_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(119, 71);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(121, 20);
            this.amount_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conver from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Convert to";
            // 
            // from_combo
            // 
            this.from_combo.FormattingEnabled = true;
            this.from_combo.Items.AddRange(new object[] {
            "Dollar",
            "Euro",
            "BAM"});
            this.from_combo.Location = new System.Drawing.Point(119, 113);
            this.from_combo.Name = "from_combo";
            this.from_combo.Size = new System.Drawing.Size(121, 21);
            this.from_combo.TabIndex = 4;
            // 
            // to_combo
            // 
            this.to_combo.FormattingEnabled = true;
            this.to_combo.Items.AddRange(new object[] {
            "Dollar",
            "Euro",
            "BAM"});
            this.to_combo.Location = new System.Drawing.Point(119, 162);
            this.to_combo.Name = "to_combo";
            this.to_combo.Size = new System.Drawing.Size(121, 21);
            this.to_combo.TabIndex = 5;
            // 
            // Display_txt
            // 
            this.Display_txt.AutoSize = true;
            this.Display_txt.Location = new System.Drawing.Point(37, 227);
            this.Display_txt.Name = "Display_txt";
            this.Display_txt.Size = new System.Drawing.Size(98, 13);
            this.Display_txt.TabIndex = 6;
            this.Display_txt.Text = "Converted Amount:";
            // 
            // Conv_btn
            // 
            this.Conv_btn.Location = new System.Drawing.Point(250, 69);
            this.Conv_btn.Name = "Conv_btn";
            this.Conv_btn.Size = new System.Drawing.Size(75, 23);
            this.Conv_btn.TabIndex = 7;
            this.Conv_btn.Text = "Convert";
            this.Conv_btn.UseVisualStyleBackColor = true;
            this.Conv_btn.Click += new System.EventHandler(this.Conv_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(337, 354);
            this.Controls.Add(this.Conv_btn);
            this.Controls.Add(this.Display_txt);
            this.Controls.Add(this.to_combo);
            this.Controls.Add(this.from_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox from_combo;
        private System.Windows.Forms.ComboBox to_combo;
        private System.Windows.Forms.Label Display_txt;
        private System.Windows.Forms.Button Conv_btn;
    }
}

