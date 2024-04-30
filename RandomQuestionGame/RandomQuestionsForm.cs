using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomQuestionGame
{
    public partial class RandomQuestionsForm : Form
    {

        private QuestionDal _questionDal;
        private List<string> sentences;
        private int currentIndex = 0;
        public RandomQuestionsForm()
        {
            InitializeComponent();
            _questionDal = new QuestionDal();
            sentences = _questionDal.GettAll();
            Shuffle(sentences);
        }

        private void RandomQuestionsForm_Load(object sender, EventArgs e)
        {
            ShowList();// Display the first question

            SizeLabel();
        }
        // Method to display the next question
        private void ShowList()
        {
            if (currentIndex < sentences.Count)
            {
                lblShow.Text = sentences[currentIndex];
                currentIndex++;
            }
            else
            {
                // Close the form
                this.Close();
            }
            
        }
        // Create a random generator
        static void Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }


        private void RandomQuestionsForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Display the next question
            if (e.KeyCode == Keys.Enter)
            {
                ShowList();
            }
            // Close the form
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        // Method to adjust the size of the label
        private void SizeLabel()
        {
            int maximumWidth  = 1500; 
            int newHeight  = TextRenderer.MeasureText(lblShow.Text, lblShow.Font, new Size(maximumWidth , int.MaxValue), TextFormatFlags.WordBreak).Height;

            lblShow.Size = new Size(maximumWidth , newHeight );
            lblShow.Location = new Point((this.ClientSize.Width - lblShow.Size.Width) / 2, (this.ClientSize.Height - lblShow.Size.Height) / 2);

        }

        private void lblShow_TextChanged(object sender, EventArgs e)
        {
            SizeLabel();
        }

        
    }
}
