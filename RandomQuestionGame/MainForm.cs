using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomQuestionGame
{
    public partial class MainForm : Form
    {
        private QuestionDal _questionDal;
        public MainForm()
        {
            InitializeComponent();
            _questionDal = new QuestionDal();

            // Center the Play button on form load
            btnPLay.Location = new Point((this.ClientSize.Width - btnPLay.Size.Width) / 2, (this.ClientSize.Height - btnPLay.Size.Height) / 2);
        }

        // Method to find or create the question file
        private void FindQuestionFile()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, "Question.txt");

            try
            {
                // If the file doesn't exist, create it
                if (!File.Exists(filePath))
                {
                    using (StreamWriter writer = File.CreateText(filePath))
                    {

                    }
                    MessageBox.Show("File successfully created.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        // Open the RandomQuestionsForm
        private void btnPLay_Click(object sender, EventArgs e)
        {
            FindQuestionFile();
            RandomQuestionsForm randomQuestionsForm = new RandomQuestionsForm();
            randomQuestionsForm.ShowDialog();
        }
        // Mouse enter event handler for the "Play" button
        private void btnPLay_MouseEnter(object sender, EventArgs e)
        {
            btnPLay.ForeColor = Color.GhostWhite;
            btnPLay.BackColor = Color.SlateBlue;
            btnPLay.FlatStyle = FlatStyle.Flat;
        }

        private void btnPLay_MouseLeave(object sender, EventArgs e)
        {
            btnPLay.ForeColor = Color.SlateBlue;
            btnPLay.BackColor = Color.GhostWhite;
        }
        // Click event handler for the "Settings" button
        private void btnSet_Click(object sender, EventArgs e)
        {
            FindQuestionFile();
            QuestionsForm questionForm = new QuestionsForm();
            questionForm.ShowDialog();
        }

        
    }
}