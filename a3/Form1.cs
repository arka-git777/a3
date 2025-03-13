using System.Windows.Forms;

namespace a3
{
    public partial class Form1 : Form
    {
        private List<string> recentFiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                recentFiles.Add(openFileDialog.FileName);
                string fileName = openFileDialog.FileName;
                filesToolStripMenuItem.DropDownItems.Add(Path.GetFileName(openFileDialog.FileName), null, FileItem_Click);
            }
        }

        private void FileItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            string clickedFileName = clickedItem.Text;
            for (int i = 0; i < recentFiles.Count; i++)
            {
                if (recentFiles[i].Contains(clickedFileName))
                {
                    MessageBox.Show($"File path is {recentFiles[i]}");
                }
            }

        }

        private void lightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            textBox1.BackColor = Color.White;
        }

        private void darkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            textBox1.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var ticForm = new Tic(this, textBox1.Text);
            this.Visible = false;
            ticForm.Show();
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected file: " + recentFiles[0]);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

