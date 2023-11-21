//most code comes from lecture slides, vidoes and VClearn
//Code for random item from Dictionary comes from: https://stackoverflow.com/questions/1028136/random-entry-from-dictionary#:~:text=Random%20rand%20%3D%20new%20Random()%3B%20string%20randomKey%20%3D%20keyList%5Brand,random%20object%20matching%20that%20key.
//Code for Dictionary and matching comes from: https://stackoverflow.com/questions/69886562/c-sharp-how-to-match-items-from-two-list-boxes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ST10116374_PROG7312_POE
{
    public partial class Identifying_Areas_Form : Form
    {
        private static Dictionary<string, string> DeweyCall = new Dictionary<string, string>() {
      {
        "000",
        "General Knowledge"
      },
      {
        "100",
        "Philosophy & Psychology"
      },
      {
        "200",
        "Relegion"
      },
      {
        "300",
        "Socaial Sciences"
      },
      {
        "400",
        "Languages"
      },
      {
        "500",
        "Science"
      },
      {
        "600",
        "Technology"
      },
    };
        List<string> keyList = new List<string>(DeweyCall.Keys); //thses list are uased to call the data to be randomized
        List<string> valueList = new List<string>(DeweyCall.Values);
        public Identifying_Areas_Form()
        {
            InitializeComponent();
            RewardPB.Visible = false;//Hide user Reward
        }

        private void checkBT_Click(object sender, EventArgs e)
        {
            //This is used to check wether you hac selected the right itmes with eath other
            if (DeweyCall[callNumLBX.Text] != descriptionsLBX.Text)
            {
                MessageBox.Show("Incorrect");
                
            }
            else
            {
                MessageBox.Show("Correct");
                RewardPB.Visible = true;// SHows user reward
            }
        }

        private void calltoDesBT_Click(object sender, EventArgs e)
        {
            ClearList();//calls the clears method
            RewardPB.Visible = false;
            foreach (KeyValuePair<string, string> kvp in DeweyCall)
            {
                descriptionsLBX.Items.Add(kvp.Value);
            }
            Random rand = new Random(); //this code is used to call random call numbers from the Dictionary: DeweyCall
            string randomKey = keyList[rand.Next(keyList.Count)];
            callNumLBX.Items.Add(randomKey);
            string randomKey1 = keyList[rand.Next(keyList.Count)];
            callNumLBX.Items.Add(randomKey1);
            string randomKey2 = keyList[rand.Next(keyList.Count)];
            callNumLBX.Items.Add(randomKey2);
            string randomKey3 = keyList[rand.Next(keyList.Count)];
            callNumLBX.Items.Add(randomKey3);
        }

        private void desctoCallNumBT_Click(object sender, EventArgs e)
        {
            ClearList();//calls the clears method
            RewardPB.Visible = false;
            foreach (KeyValuePair<string, string> kvp in DeweyCall)
            {
                callNumLBX.Items.Add(kvp.Key);
            }
            Random rand = new Random(); //this code is used to call random descriptions from the Dictionary: DeweyCall
            string randomKey = valueList[rand.Next(valueList.Count)];
            descriptionsLBX.Items.Add(randomKey);
            string randomKey1 = valueList[rand.Next(valueList.Count)];
            descriptionsLBX.Items.Add(randomKey1);
            string randomKey2 = valueList[rand.Next(valueList.Count)];
            descriptionsLBX.Items.Add(randomKey2);
            string randomKey3 = valueList[rand.Next(valueList.Count)];
            descriptionsLBX.Items.Add(randomKey3);
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
        public void ClearList() //This is sued to clear list so user can play over and over
        {
            callNumLBX.Items.Clear();
            descriptionsLBX.Items.Clear();
        }
    
    }
}
