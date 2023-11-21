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
    public partial class FindingCallNumbers : Form
    {

        char c = '\n';
        private TreeLevel treeLevel;
        private bool lvl1 = true, lvl2 = false, lvl3 = false;

        public FindingCallNumbers()
        {
            InitializeComponent();
            CheckFiles();
            RestartBT.Enabled = false;
            RestartBT.Visible = false;
            RewardPB.Visible = false;
            FindingCallNum findingCallNumbers = new FindingCallNum();
            treeLevel = findingCallNumbers.GetLevel();
            DescriptionLB.Text = treeLevel.AnswerPath[2].Description;
            PopulateChoice(1);
            Global.Game3 = true;
        }

        private void Option1BT_Click(object sender, EventArgs e)
        {
            CheckAnswer(Option1BT.Text);
        }

        private void Option2BT_Click(object sender, EventArgs e)
        {
            CheckAnswer(Option2BT.Text);
        }

        private void Option4BT_Click(object sender, EventArgs e)
        {
            CheckAnswer(Option4BT.Text);
        }

        private void Option3BT_Click(object sender, EventArgs e)
        {
            CheckAnswer(Option3BT.Text);
        }

        private void RestartBT_Click(object sender, EventArgs e)
        {
            FindingCallNumbers NewForm = new FindingCallNumbers();
            NewForm.Show();
            this.Dispose(false);
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

        private void CheckAnswer(String text)
        {
            // extract the description from the concatenated call number in the button component
            string[] split = text.Split(c);
            string newSplit = split[0];

            // declare temp bool
            bool isAnswerCorrect;

            // check the level the user is on
            if (lvl1)
            {
                // check if the user has selected the correct answer from the filtered tree nodes to progress through
                isAnswerCorrect = treeLevel.Level1Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();

                // if the answer is correct
                if (isAnswerCorrect)
                {
                    // populated the choices for the next round
                    PopulateChoice(2);
                    lvl1 = false;
                    lvl2 = true;

                }
                else
                {
                    EndGame();
                }
            }
            else if (lvl2)
            {
                // check if the user has selected the correct answer from the filtered tree nodes to progress through
                isAnswerCorrect = treeLevel.Level2Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();

                // if the answer is correct
                if (isAnswerCorrect)
                {
                    PopulateChoice(3);
                    lvl2 = false;
                    lvl3 = true;
                }
                else
                {
                    EndGame();
                }


            }
            else if (lvl3)
            {
                // check if the user has selected the correct answer from the filtered tree nodes to progress through
                isAnswerCorrect = treeLevel.Level3Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();

                // if the answer is correct
                if (isAnswerCorrect)
                {
                    EndGame2();
                }
                else
                {
                    EndGame();
                }
            }
        }

        private void CheckFiles()
        {
            if (!JsonFileUtility.TreeGameDataExists())
            {
                JsonFileUtility.CreateTreeDataFile();
            }

            if (GlobalTree.Tree == null)
            {
                GlobalTree.Tree = JsonFileUtility.GetTree();
            }
        }

        private void EndGame()
        {
            FindingCallNumbers NewForm = new FindingCallNumbers();
            NewForm.Show();
            this.Dispose(false);
            string message = "Wrong Try again";
            MessageBox.Show(message);
        }

        private void EndGame2()
        {
            string message = "Well done all answers correct";
            MessageBox.Show(message);
            RestartBT.Enabled = true;
            RestartBT.Visible = true;
            RewardPB.Visible = true;
            Option1BT.Enabled = false;
            Option2BT.Enabled = false;
            Option3BT.Enabled = false;
            Option4BT.Enabled = false;
        }

        private void PopulateChoice(int i)
        {
            if (i == 1)
            {
                // populate level one child node descriptions and call number options
                Option1BT.Text = treeLevel.Level1Options[0].Description + "\n" + treeLevel.Level1Options[0].Number;
                Option2BT.Text = treeLevel.Level1Options[1].Description + "\n" + treeLevel.Level1Options[1].Number;
                Option3BT.Text = treeLevel.Level1Options[2].Description + "\n" + treeLevel.Level1Options[2].Number;
                Option4BT.Text = treeLevel.Level1Options[3].Description + "\n" + treeLevel.Level1Options[3].Number;
            }
            else if (i == 2)
            {
                Option1BT.Text = treeLevel.Level2Options[0].Description + "\n" + treeLevel.Level2Options[0].Number;
                Option2BT.Text = treeLevel.Level2Options[1].Description + "\n" + treeLevel.Level2Options[1].Number;
                Option3BT.Text = treeLevel.Level2Options[2].Description + "\n" + treeLevel.Level2Options[2].Number;
                Option4BT.Text = treeLevel.Level2Options[3].Description + "\n" + treeLevel.Level2Options[3].Number;
            }
            else if (i == 3)
            {

                Option1BT.Text = treeLevel.Level3Options[0].Description + "\n" + treeLevel.Level3Options[0].Number;
                Option2BT.Text = treeLevel.Level3Options[1].Description + "\n" + treeLevel.Level3Options[1].Number;
                Option3BT.Text = treeLevel.Level3Options[2].Description + "\n" + treeLevel.Level3Options[2].Number;
                Option4BT.Text = treeLevel.Level3Options[3].Description + "\n" + treeLevel.Level3Options[3].Number;
            }
            else
            {
                Console.WriteLine("Populate Choice not found");
            }

        }
    }
}
