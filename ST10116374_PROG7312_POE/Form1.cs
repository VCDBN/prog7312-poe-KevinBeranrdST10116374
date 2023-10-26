//all code comes from lecture slides/videos
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReBooksBT_Click(object sender, EventArgs e)
        {
            
            var myForm = new ReplaceBooksFormcs(); //To Move to next Form
            myForm.Show();
            this.Hide();

        }

        private void IdAreaBT_Click(object sender, EventArgs e)
        {
            var myForm = new Identifying_Areas_Form(); //To Move to next Form
            myForm.Show();
            this.Hide();
        }

        private void FindCallBT_Click(object sender, EventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Option disabled try replacing books instead!\n\rClose Form?";
            string caption = "Error Option disabled for now!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                Application.Exit();
            }
        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            Application.Exit(); //This is used to close the app once user is done
        }
    }
}
