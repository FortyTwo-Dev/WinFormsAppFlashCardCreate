namespace WinFormsAppFlashCardCreate
{
    public partial class Card1 : Form
    {
        public Card1()
        {
            InitializeComponent();
        }
        public string clue1 = "";
        public string clue2 = "";
        public string clue3 = "";
        public bool clue1B = false;
        public bool clue2B = false;
        public bool clue3B = false;
        public string path = "CreatorFlashCard/" + VarGeneral.categoryCard + "/" + Convert.ToString(VarGeneral.card);
        private void Card1_Load(object sender, EventArgs e)
        {
            string path = "CreatorFlashCard/" + VarGeneral.categoryCard + "/" + Convert.ToString(VarGeneral.card);
            buttonRestart.Enabled = false;
            buttonResultCard1.Enabled = true;
            Card1 card = new()
            {
                Text = "First Card n°" + Convert.ToString(VarGeneral.card)
            };
            if (VarGeneral.categoryCard != "")
            {
                string variable = File.ReadAllText(path + "/0.txt");
                variable = variable.Replace("\r\n", "").Trim();
                labelCard1.Text = variable;
                if (File.Exists(path + "/Clue/1/1.txt"))
                {
                    clue1 = File.ReadAllText(path + "/Clue/1/1.txt");
                    toolStripMenuItem1.Visible = true;
                    clue1B = true;
                }
                else
                {
                    toolStripMenuItem1.Visible = false;
                    clue1B = false;
                }

                if (File.Exists(path + "/Clue/2.txt"))
                {
                    clue2 = File.ReadAllText(path + "/Clue/1/2.txt");
                    toolStripMenuItem1.Visible = true;
                    clue2B = true;
                }
                else
                {
                    toolStripMenuItem2.Visible = false;
                    clue2B = false;
                }

                if (File.Exists(path + "/Clue/3.txt"))
                {
                    clue3 = File.ReadAllText(path + "/Clue/1/3.txt");
                    toolStripMenuItem2.Visible = true;
                    clue3B = true;
                }
                else
                {
                    toolStripMenuItem3.Visible = false;
                    clue3B = false;
                }
            }
            else
            {
                MessageBox.Show("Not found");
            }
            MessageBox.Show(Convert.ToString(VarGeneral.card));
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Close();
            VarGeneral.RestartChoiceCard();
            Card1 card1 = new();
            Card2 card2 = new();
            if (VarGeneral.firstCard == 0)
            {
                if (VarGeneral.categoryCard != "")
                {
                    card1.Show();
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
            else
            {
                if (VarGeneral.categoryCard != "")
                {
                    card2.Show();
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
        }

        private void buttonResultCard2_Click(object sender, EventArgs e)
        {
            string variable = File.ReadAllText(path + "/1.txt");
            variable = variable.Replace("\r\n", "").Trim();
            if (variable == textBoxAnswer.Text)
            {
                buttonRestart.Enabled = true;
                buttonResultCard1.BackColor = Color.Green;
                buttonResultCard1.Enabled = false;
                VarGeneral.score += 1;
            }
            else
            {
                buttonResultCard1.BackColor = Color.Red;
                VarGeneral.score -= 2;
                MessageBox.Show(variable);
            }
        }

        private void buttonCancelCard2_Click(object sender, EventArgs e)
        {
            using (StreamWriter swVar = new("CreatorFlashCard/" + VarGeneral.categoryCard + "/score.txt")) { swVar.WriteLine(Convert.ToString(VarGeneral.score)); }
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clue1B)
            {
                MessageBox.Show(clue1);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (clue2B)
            {
                MessageBox.Show(clue2);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (clue3B)
            {
                MessageBox.Show(clue3);
            }
        }
    }
}