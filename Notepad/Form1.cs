namespace PersonalNotepad

{
    public partial class Form1 : Form
    {

        private string currentFilePath = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Tekstbestanden (*.txt)|*.txt|Alle bestanden (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                File.WriteAllText(currentFilePath, textBox.Text);
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Font = fontDialog.Font;
                }
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.BackColor = colorDialog.Color;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personal Notepad\nOntwikkeld door [Betul Can]", "Over");
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.ForeColor = colorDialog.Color;
                }
            }
        }

        private void styleSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Font = fontDialog.Font;
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    File.WriteAllText(currentFilePath, textBox.Text);
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string lastText = "";
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox.Text != lastText)
            {
                lastText = textBox.Text;
            }
        }

        private void undToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentText = textBox.Text;
            textBox.Text = lastText;
            lastText = currentText;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentText = textBox.Text;
            textBox.Text = lastText;
            lastText = currentText;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.SelectedText))
            {
                Clipboard.SetText(textBox.SelectedText);
                textBox.SelectedText = "";
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.SelectedText))
            {
                Clipboard.SetText(textBox.SelectedText);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                int selectionStart = textBox.SelectionStart; 
                textBox.Text = textBox.Text.Insert(selectionStart, Clipboard.GetText());
                textBox.SelectionStart = selectionStart + Clipboard.GetText().Length; 
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void hideTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Visible = false;
        }

        private void unhideTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Visible = true;
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voor ondersteuning kunt u contact opnemen met:\n\nE-mail: support@test.com\nTelefoon: 123-456-7890\n\nOf bezoek onze website: www.test.com",
                   "Ondersteuning",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }
    }
}
