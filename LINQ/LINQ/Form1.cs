using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{

    public partial class Form1 : Form
    {
        List<Manager> mList = new List<Manager>(); //global variable to storemanager objects
        List<Developer> dList = new List<Developer>(); //global variable to store developer objects
        int mVar = 0; //global variable to count the number of manager objects
        int dVar = 0; //global variable to store the number of developer objects

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e) //event handler declaration for clicking the load button
        {

            string file; //declares a string variable to hold a file directory  
            file = System.IO.File.ReadAllText(rtfInput.Text); //reads the contents of the directory in the variable file

            file = file.Replace('\n', '\r'); //organizes the contents of file for a 2d array
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rowsNum = lines.Length;
            int colsNum = lines[0].Split(',').Length;
            string[,] values = new string[rowsNum, colsNum]; //declares a 2d array values for holding all data objects

            for (int r = 0; r < rowsNum; r++) //for loop for assigning the data members their place in the 2d array
            {
                string[] line_r = lines[r].Split(','); //splits each data member by ,
                for (int c = 0; c < colsNum; c++)
                {
                    values[r, c] = line_r[c];
                }
            }
            
            for (int t = 0; t < rowsNum; t++) //for loop for assigning data members from values to their appropriate employee subclass object 
            {
                if (values[t, 6] == "Developer") //if employee type is developer
                {
                    Developer D1 = new Developer(); //declares a new developer object
                    D1.fName = values[t, 0];
                    D1.lName = values[t, 1];
                    D1.address = values[t, 2];
                    D1.city = values[t, 3];
                    D1.state = values[t, 4];
                    D1.zip = values[t, 5];
                    D1.type = values[t, 6];
                    D1.devType = values[t, 7];                   
                    D1.supervisor = values[t, 9];
                    D1.taxType = values[t, 10];

                    dList.Add(D1); //add the new developer object to the dList
                    dVar += 1; //increment the developer count by 1
                }
                else //else clause, employee type is manager
                {
                    Manager M1 = new Manager(); //declares a new manager object
                    M1.fName = values[t, 0];
                    M1.lName = values[t, 1];
                    M1.address = values[t, 2];
                    M1.city = values[t, 3];
                    M1.state = values[t, 4];
                    M1.zip = values[t, 5];
                    M1.type = values[t, 6];                  
                    M1.costCenter = values[t, 8];
                    M1.supervisor = values[t, 9];
                    
                    mList.Add(M1); //add the new manager object to the mList
                    mVar += 1; //increment teh manager count by 1
                }
            }
          
        }

        public void btnView_Click(object sender, EventArgs e) //event handler for the view button
        {       
            int selection; //declares a variable to hold user selection
            selection = Convert.ToInt32(rtfNum.Text); //get user selection

            if (selection < 3)
            {
                MessageBox.Show("Please enter a number bigger than 2.");

            }
            else
            {
                int count = 0; //declares a counter to only display the user selected number of employees
                
                for (int x = 0; x < mVar; x++) //for loop to increment through the manager list
                {
                    if (count == selection) //if user selection is reached, break
                    {
                        break;
                    }
                    rtfBox2.Text += mList[x].fName; //output to the rich text box
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += mList[x].lName;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += mList[x].address;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += mList[x].city;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += mList[x].state;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += mList[x].zip;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += mList[x].type;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += ("NA");
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += mList[x].costCenter;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += mList[x].supervisor;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += ("NA");
                    rtfBox2.Text += ("\n");
                     
                    count++; //increment count by 1
                                
                }
                for (int x = 0; x < dVar; x++) //for loop to increment through the developer list
                {
                    if (count == selection) //if user selection is reached, break
                    {
                        break;
                    }
                    rtfBox2.Text += dList[x].fName; //output to the rich text box
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += dList[x].lName;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += dList[x].address;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += dList[x].city;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += dList[x].state;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += dList[x].zip;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += dList[x].type;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += dList[x].devType;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += ("0");
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += dList[x].supervisor;
                    rtfBox2.Text += (" | ");
                    rtfBox2.Text += dList[x].taxType;
                    rtfBox2.Text += ("\n");

                    count++; //increment count by 1
                   
                }
                
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnFNsearch_Click(object sender, EventArgs e)
        {
            string FNsearch = txtBoxFN.Text;


            var nameSearch = dList.Where(p => p.fName == (FNsearch));

            foreach (var Manager in nameSearch)
            {
                rtfBox2.Text += Manager.fName; //output to the rich text box
                rtfBox2.Text += (" | ");
                rtfBox2.Text += Manager.lName;
                rtfBox2.Text += (" | ");
                rtfBox2.Text += Manager.address;
                rtfBox2.Text += (" | ");
                rtfBox2.Text += Manager.city;
                rtfBox2.Text += (" | ");
                rtfBox2.Text += Manager.state;
                rtfBox2.Text += (" | ");
                rtfBox2.Text += Manager.zip;
                rtfBox2.Text += (" | ");
                rtfBox2.Text += Manager.type;
                rtfBox2.Text += (" | ");
                rtfBox2.Text += Manager.devType;
                rtfBox2.Text += (" | ");
                rtfBox2.Text += ("0");
                rtfBox2.Text += (" | ");
                rtfBox2.Text += Manager.supervisor;
                rtfBox2.Text += (" | ");
                rtfBox2.Text += Manager.taxType;
                rtfBox2.Text += ("\n");
            }


        }

        private void rtfInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

