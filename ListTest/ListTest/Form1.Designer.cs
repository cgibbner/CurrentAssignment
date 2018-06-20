namespace ListTest
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxBase = new System.Windows.Forms.TextBox();
            this.txtBoxSub1 = new System.Windows.Forms.TextBox();
            this.txtBoxSub2 = new System.Windows.Forms.TextBox();
            this.rtfBox = new System.Windows.Forms.RichTextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(254, 118);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 39);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "Write To List";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 189);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBoxSub2);
            this.tabPage1.Controls.Add(this.txtBoxSub1);
            this.tabPage1.Controls.Add(this.txtBoxBase);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnWrite);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(335, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Write";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRead);
            this.tabPage2.Controls.Add(this.rtfBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(335, 163);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Read";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subclass Data 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subclass Data 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxBase
            // 
            this.txtBoxBase.Location = new System.Drawing.Point(113, 25);
            this.txtBoxBase.Name = "txtBoxBase";
            this.txtBoxBase.Size = new System.Drawing.Size(143, 20);
            this.txtBoxBase.TabIndex = 4;
            this.txtBoxBase.TextChanged += new System.EventHandler(this.txtBoxBase_TextChanged);
            // 
            // txtBoxSub1
            // 
            this.txtBoxSub1.Location = new System.Drawing.Point(113, 51);
            this.txtBoxSub1.Name = "txtBoxSub1";
            this.txtBoxSub1.Size = new System.Drawing.Size(143, 20);
            this.txtBoxSub1.TabIndex = 5;
            this.txtBoxSub1.TextChanged += new System.EventHandler(this.txtBoxSub1_TextChanged);
            // 
            // txtBoxSub2
            // 
            this.txtBoxSub2.Location = new System.Drawing.Point(113, 77);
            this.txtBoxSub2.Name = "txtBoxSub2";
            this.txtBoxSub2.Size = new System.Drawing.Size(143, 20);
            this.txtBoxSub2.TabIndex = 6;
            // 
            // rtfBox
            // 
            this.rtfBox.Location = new System.Drawing.Point(6, 6);
            this.rtfBox.Name = "rtfBox";
            this.rtfBox.Size = new System.Drawing.Size(219, 151);
            this.rtfBox.TabIndex = 0;
            this.rtfBox.Text = "";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(254, 118);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 39);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read From List";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 214);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "List Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtBoxSub2;
        private System.Windows.Forms.TextBox txtBoxSub1;
        private System.Windows.Forms.TextBox txtBoxBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox rtfBox;
    }
}

