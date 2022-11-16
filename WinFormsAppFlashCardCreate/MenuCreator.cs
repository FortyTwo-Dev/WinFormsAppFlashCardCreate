using System.IO;
using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;

namespace WinFormsAppFlashCardCreate
{
    public partial class MenuCreator : Form
    {
        public string CFCPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CreatorFlashCard/";
        public MenuCreator()
        {
            InitializeComponent();
        }

        public void CheckBoxCheck(CheckBox check1, TextBox text1, string str, string strClue)
        {
            string nameFile = comboBoxCategory.Text;
            string number = VarGeneral.NumberCard(comboBoxCategory, 0);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CreatorFlashCard/" + nameFile + "/" + number + "/Clue/" + str + "/";
            if (check1.Checked)
            {
                try
                {
                    //File.Create(path + strClue + ".txt");
                    Directory.CreateDirectory(path);
                    using (StreamWriter sw = new(path + strClue + ".txt")) { sw.WriteLine(text1.Text); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.Text == "")
            {
                MessageBox.Show("Please selected Category");
            }
            else
            {
                string nameFile = comboBoxCategory.Text;
                string number = VarGeneral.NumberCard(comboBoxCategory);
                string filePath = CFCPath + nameFile + "/";
                string numberToString = number;
                string newLocation = filePath + numberToString;
                string clue = newLocation + "/Clue";
                try
                {

                    Directory.CreateDirectory(newLocation);
                    using (StreamWriter swc1 = new StreamWriter(newLocation + "/0.txt")) { swc1.WriteLine(textBoxCard1.Text); }
                    using (StreamWriter swc2 = new StreamWriter( newLocation + "/1.txt")) { swc2.WriteLine(textBoxCard2.Text); }
                    Directory.CreateDirectory(clue);
                    Directory.CreateDirectory(clue + "/0");
                    Directory.CreateDirectory(clue + "/1");
                    CheckBoxCheck(checkBoxClue1Card1, textBoxClue1Card1, "0", "1");
                    CheckBoxCheck(checkBoxClue2Card1, textBoxClue2Card1, "0", "2");
                    CheckBoxCheck(checkBoxClue3Card1, textBoxClue3Card1, "0", "3");

                    CheckBoxCheck(checkBoxClue1Card2, textBoxClue1Card2, "1", "1");
                    CheckBoxCheck(checkBoxClue2Card2, textBoxClue2Card2, "1", "2");
                    CheckBoxCheck(checkBoxClue3Card2, textBoxClue3Card2, "1", "3");

                    textBoxCard1.Clear();
                    textBoxCard2.Clear();

                    checkBoxClue1Card1.Checked = false;
                    checkBoxClue1Card2.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(CFCPath))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CreatorFlashCard");
            }

            string pathDirectory = CFCPath;
            string[] dirs = Directory.GetDirectories(pathDirectory);
            for (int i = 0; i < dirs.Length; i++)
            {
                string name = Path.GetFileNameWithoutExtension(dirs[i]);
                comboBoxCategory.Items.Add(name);
                comboBoxCategoryScore.Items.Add(name);
                toolStripComboBoxCategory.Items.Add(name);

            }
        }

        public void EnableDisable(CheckBox getcheckBox, TextBox textBox, CheckBox checkBox, CheckBox checkBoxdisable)
        {
            if (getcheckBox.Checked)
            {
                textBox.Enabled = true;
                checkBox.Enabled = true;
            }
            else
            {
                textBox.Enabled = false;
                checkBox.Enabled = false;
                checkBoxdisable.Checked = false;
                textBox.Text = "";
            }
        }
        public void EnableDisableLast(CheckBox getcheckBox, TextBox textBox)
        {
            if (getcheckBox.Checked)
            {
                textBox.Enabled = true;
            }
            else
            {
                textBox.Enabled = false;
                textBox.Text = "";
            }
        }

        private void checkBoxClue1Card1_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisable(checkBoxClue1Card1, textBoxClue1Card1, checkBoxClue2Card1, checkBoxClue2Card1);
        }

        private void checkBoxClue2Card1_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisable(checkBoxClue2Card1, textBoxClue2Card1, checkBoxClue3Card1, checkBoxClue3Card1);
        }

        private void checkBoxClue3Card1_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableLast(checkBoxClue3Card1, textBoxClue3Card1);
        }

        private void checkBoxClue1Card2_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisable(checkBoxClue1Card2, textBoxClue1Card2, checkBoxClue2Card2, checkBoxClue2Card2);
        }

        private void checkBoxClue2Card2_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisable(checkBoxClue2Card2, textBoxClue2Card2, checkBoxClue3Card2, checkBoxClue3Card2);
        }

        private void checkBoxClue3Card2_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableLast(checkBoxClue3Card2, textBoxClue3Card2);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            VarGeneral.CreateCategory(comboBoxCategory, comboBoxCategoryScore, textBoxCategory, CFCPath, toolStripComboBoxCategory);
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            VarGeneral.DeleteCategory(comboBoxCategory, comboBoxCategoryScore, textBoxCategory, CFCPath, toolStripComboBoxCategory);
        }

        private void validateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VarGeneral.ChoiceCard(toolStripComboBoxCategory);
            Card1 card1 = new();
            Card2 card2 = new();
            if (VarGeneral.firstCard == 0)
            {
                if (VarGeneral.categoryCard != "")
                {
                    card1.ShowDialog();
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
                    card2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VarGeneral.ChoiceCard(toolStripComboBoxCategory);
            Card1 card1 = new();
            Card2 card2 = new();
            if (VarGeneral.firstCard == 0)
            {
                if (VarGeneral.categoryCard != "")
                {
                    card1.ShowDialog();
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
                    card2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
        }

        private void comboBoxCategoryScore_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Score = File.ReadAllText(CFCPath + comboBoxCategoryScore.Text + "/score.txt");
            Score = Score.Replace("\r\n", "").Trim();
            labelScore.Text = Score + " / " + VarGeneral.test;
        }

        private void buttonResetScore_Click(object sender, EventArgs e)
        {
            if (comboBoxCategoryScore.Text != "")
            {
                using (StreamWriter swVar = new(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CreatorFlashCard/" + comboBoxCategoryScore.Text + "/score.txt")) { swVar.WriteLine("0"); }
                string Score =  File.ReadAllText(CFCPath + comboBoxCategoryScore.Text + "/score.txt");
                Score = Score.Replace("\r\n", "").Trim();
                labelScore.Text = Score + " / 0";
                VarGeneral.test = 0;
            }
            else
            {
                MessageBox.Show("Please selected Category");
            }
        }
    }
}