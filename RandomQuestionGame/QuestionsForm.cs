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
    public partial class QuestionsForm : Form
    {

        private QuestionDal _questionDal;
        public QuestionsForm()
        {
            InitializeComponent();

            // Initialize QuestionDal
            _questionDal = new QuestionDal();

            dgwQuestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgwQuestion.DefaultCellStyle.Font = new Font("Arial", 12);
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {

            PopulateDataGridView();


        }
        private void PopulateDataGridView()
        {
            // Get questions from the database
            List<string> sentences = _questionDal.GettAll();

            DataTable dt = new DataTable();
            dt.Columns.Add("Sentence");

            foreach (string sentence in sentences)
            {
                // Add questions to DataTable
                dt.Rows.Add(sentence);
                tbxQuestion.Text = "";
            }

            dgwQuestion.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newQuestion = tbxQuestion.Text;

            if (!string.IsNullOrWhiteSpace(tbxQuestion.Text))
            {
                try
                {
                    // Add new question to database
                    _questionDal.AddQuestion(newQuestion);
                    PopulateDataGridView();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Error occurred while adding question: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid sentence!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            string deleteQuestion = tbxQuestion.Text;

            try
            {
                // Delete question from database
                _questionDal.DeleteQuestion(deleteQuestion);
                
                PopulateDataGridView();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error occurred while adding question: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgwQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxQuestion.Text = "";
            // Set textbox text to clicked question
            tbxQuestion.Text = dgwQuestion.CurrentRow.Cells[0].Value.ToString();
        }

        
    }
}
