using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTest
{
    public partial class Form1 : Form
    {
        List<Base> dataStor = new List<Base>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxSub1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            Sub Cont = new Sub();

            Cont.data = txtBoxBase.Text;
            Cont.rackNum = txtBoxSub1.Text;
            Cont.rogerNum = txtBoxSub2.Text;

            dataStor.Add(Cont);

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            rtfBox.Text = dataStor[0].data;
            //rtfBox.Text = dataStor[0].rackNum;
            //rtfBox.Text = dataStor[0].rogerNum;
        }
    }
}
