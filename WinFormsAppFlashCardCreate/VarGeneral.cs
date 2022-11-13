namespace WinFormsAppFlashCardCreate
{
    public static class VarGeneral
    {
        public static int card;
        public static int firstCard;
        public static string categoryCard = "";
        public static int score;
        public static string NumberCard(ComboBox boxNumberVar)
        {
            string CFCPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CreatorFlashCard/";
            string numbervar = boxNumberVar.Text;
            string filePath = CFCPath + numbervar + "/";
            string variable = File.ReadAllText(filePath + "variable.txt");
            int i = int.Parse(variable) + 1;
            variable = Convert.ToString(i);
            try
            {
                using (StreamWriter swVar = new(filePath + "variable.txt")) { swVar.WriteLine(variable); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return variable;
        }
        public static string NumberCard(ComboBox boxNumberVar, int j)
        {
            string CFCPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CreatorFlashCard/";
            string numbervar = boxNumberVar.Text;
            string filePath = CFCPath + numbervar + "/";
            string variable = File.ReadAllText(filePath + "variable.txt");
            int i = int.Parse(variable) + j;
            variable = Convert.ToString(i);
            try
            {
                using (StreamWriter swVar = new(filePath + "variable.txt")) { swVar.WriteLine(variable); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return variable;
        }
        public static void CreateCategory(ComboBox boxCategory, ComboBox boxCategoryScore, TextBox textCategory, string path, ToolStripComboBox toolStripComboboxCategory)
        {
            if (Directory.Exists(path + textCategory.Text))
            {
                MessageBox.Show("This category has already been create");
            }
            else
            {
                Directory.CreateDirectory(path + textCategory.Text);
                boxCategory.Items.Add(textCategory.Text);
                boxCategoryScore.Items.Add(textCategory.Text);
                toolStripComboboxCategory.Items.Add(textCategory.Text);

                try
                {
                    using (StreamWriter swVar = new(path + textCategory.Text + "/variable.txt")) { swVar.WriteLine("-1"); }
                    using (StreamWriter swVar = new(path + textCategory.Text + "/score.txt")) { swVar.WriteLine("0"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static void DeleteCategory(ComboBox boxCategory, ComboBox boxCategoryScore, TextBox textCategory, string path, ToolStripComboBox toolStripComboboxCategory)
        {
            try
            {
                if (textCategory.Text == "")
                {
                    MessageBox.Show("The Category don't exist");
                }
                else
                {
                    Directory.Delete(path + textCategory.Text, true);
                    boxCategory.Items.Remove(textCategory.Text);
                    boxCategoryScore.Items.Remove(textCategory.Text);
                    toolStripComboboxCategory.Items.Remove(textCategory.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Category don't exist");
                MessageBox.Show(ex.Message);
            }

        }
        public static void ChoiceCard(ToolStripComboBox toolStripComboboxCategory)
        {
            Random random = new();
            categoryCard = toolStripComboboxCategory.Text;
            try
            {
                string variable = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CreatorFlashCard/" + categoryCard + "/variable.txt");
                int i = int.Parse(variable) + 1;
                card = random.Next(0, i);
                firstCard = random.Next(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a category");
                MessageBox.Show(ex.Message);
            }
        }
        public static void RestartChoiceCard()
        {
            Random random = new();
            try
            {
                string variable = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CreatorFlashCard/" + categoryCard + "/variable.txt");
                int i = int.Parse(variable) + 1;
                card = random.Next(0, i);
                firstCard = random.Next(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error1");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
