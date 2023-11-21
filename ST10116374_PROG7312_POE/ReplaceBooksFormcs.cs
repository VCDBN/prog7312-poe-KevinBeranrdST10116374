//all code comes from lecture slides/videos
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10116374_PROG7312_POE
{
    public partial class ReplaceBooksFormcs : Form
    {
        public ReplaceBooksFormcs()
        {
            InitializeComponent();
           
        }

        private void ReturnCloseBT_Click(object sender, EventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Do you want to to return to first page?";
            string caption = "Return to firt Page";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                var myForm = new Form1(); //To Move to next Form
                myForm.Show();
                this.Close();
            }

        }

        public void AddNumBT_Click(object sender, EventArgs e)
        {
            
            UserLBX.Items.Add(AddCallTB.Text); //lets user add items to the list box to be sorted
        }

        public void GenCallNumBT_Click(object sender, EventArgs e)
        {
            List<string> Callnumbers = new List<string>(); //list to store calnumbers of the books
            Callnumbers.Add("005.73 JAM");
            Callnumbers.Add("278.47 NAY");
            Callnumbers.Add("111.98 DFE");
            Callnumbers.Add("987.11 QWE");
            Callnumbers.Add("001.65 MIK");
            Callnumbers.Add("035.14 JIM");
            Callnumbers.Add("008.47 NEX");
            Callnumbers.Add("789.12 QPO");
            Callnumbers.Add("114.14 BQS");
            Callnumbers.Add("132.63 KXI");
            GenNumLBX.DataSource = Callnumbers;
        }

        public void CheckOrderBT_Click(object sender, EventArgs e)
        {
            
            //sorting algorithm used
            GenNumLBX.Sorted = true;//sorting algorithm used
            if (UserLBX.Text != GenNumLBX.Text)
            {
                MessageBox.Show("Incorrect");

            }
            else
            {
                MessageBox.Show("Correct");
                
            }


        }

        private void ClearBTU_Click(object sender, EventArgs e)
        {
 
            UserLBX.Items.Clear();//to clear list box 
            GenNumLBX.Sorted = false;
            GenNumLBX.Items.Clear();//to clear list box 
        }

        private void ProgressBT_Click(object sender, EventArgs e)
        {
            ItemsinlistPB.Maximum = 10;
            ItemsinlistPB.Minimum = 0;
            ItemsinlistPB.Style = ProgressBarStyle.Continuous;

            for (int i = 0; i <= 10; i++) 
            {   
                ItemsinlistPB.Value = UserLBX.Items.Count;
            }
        }
    }
}
