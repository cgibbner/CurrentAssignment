namespace LINQ
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtfNum = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtfInput = new System.Windows.Forms.RichTextBox();
            this.rtfBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFNsearch = new System.Windows.Forms.Button();
            this.btnLNsearch = new System.Windows.Forms.Button();
            this.btnAsearch = new System.Windows.Forms.Button();
            this.txtBoxFN = new System.Windows.Forms.TextBox();
            this.txtBoxLN = new System.Windows.Forms.TextBox();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 59);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select a file to store.";
            // 
            // rtfNum
            // 
            this.rtfNum.Location = new System.Drawing.Point(101, 132);
            this.rtfNum.Name = "rtfNum";
            this.rtfNum.Size = new System.Drawing.Size(69, 23);
            this.rtfNum.TabIndex = 2;
            this.rtfNum.Text = "";
            this.rtfNum.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select number of records to view then press View.";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(194, 132);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number to view:";
            // 
            // rtfInput
            // 
            this.rtfInput.Location = new System.Drawing.Point(12, 30);
            this.rtfInput.Name = "rtfInput";
            this.rtfInput.Size = new System.Drawing.Size(257, 23);
            this.rtfInput.TabIndex = 6;
            this.rtfInput.Text = "";
            this.rtfInput.TextChanged += new System.EventHandler(this.rtfInput_TextChanged);
            // 
            // rtfBox2
            // 
            this.rtfBox2.Location = new System.Drawing.Point(292, 30);
            this.rtfBox2.Name = "rtfBox2";
            this.rtfBox2.Size = new System.Drawing.Size(495, 293);
            this.rtfBox2.TabIndex = 7;
            this.rtfBox2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(496, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "First Name | Last Name | Address | City | State | Zip | Type | Dev Type | Cost Ce" +
    "nter | Manager | Tax Type";
            // 
            // btnFNsearch
            // 
            this.btnFNsearch.Location = new System.Drawing.Point(194, 221);
            this.btnFNsearch.Name = "btnFNsearch";
            this.btnFNsearch.Size = new System.Drawing.Size(75, 23);
            this.btnFNsearch.TabIndex = 9;
            this.btnFNsearch.Text = "Search";
            this.btnFNsearch.UseVisualStyleBackColor = true;
            this.btnFNsearch.Click += new System.EventHandler(this.btnFNsearch_Click);
            // 
            // btnLNsearch
            // 
            this.btnLNsearch.Location = new System.Drawing.Point(194, 250);
            this.btnLNsearch.Name = "btnLNsearch";
            this.btnLNsearch.Size = new System.Drawing.Size(75, 23);
            this.btnLNsearch.TabIndex = 10;
            this.btnLNsearch.Text = "Search";
            this.btnLNsearch.UseVisualStyleBackColor = true;
            // 
            // btnAsearch
            // 
            this.btnAsearch.Location = new System.Drawing.Point(194, 279);
            this.btnAsearch.Name = "btnAsearch";
            this.btnAsearch.Size = new System.Drawing.Size(75, 23);
            this.btnAsearch.TabIndex = 11;
            this.btnAsearch.Text = "Search";
            this.btnAsearch.UseVisualStyleBackColor = true;
            // 
            // txtBoxFN
            // 
            this.txtBoxFN.Location = new System.Drawing.Point(70, 223);
            this.txtBoxFN.Name = "txtBoxFN";
            this.txtBoxFN.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFN.TabIndex = 12;
            // 
            // txtBoxLN
            // 
            this.txtBoxLN.Location = new System.Drawing.Point(70, 252);
            this.txtBoxLN.Name = "txtBoxLN";
            this.txtBoxLN.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLN.TabIndex = 13;
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(70, 281);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(100, 20);
            this.txtBoxA.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Below are additional search options. Search by...";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "________________________________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 335);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxA);
            this.Controls.Add(this.txtBoxLN);
            this.Controls.Add(this.txtBoxFN);
            this.Controls.Add(this.btnAsearch);
            this.Controls.Add(this.btnLNsearch);
            this.Controls.Add(this.btnFNsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtfBox2);
            this.Controls.Add(this.rtfInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtfNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Employee Store v1.5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtfNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtfInput;
        private System.Windows.Forms.RichTextBox rtfBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFNsearch;
        private System.Windows.Forms.Button btnLNsearch;
        private System.Windows.Forms.Button btnAsearch;
        private System.Windows.Forms.TextBox txtBoxFN;
        private System.Windows.Forms.TextBox txtBoxLN;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}

