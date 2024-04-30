using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RandomQuestionGame
{
    class QuestionDal
    {

        // find the question file path
        public string FindQuestionFile()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, "Question.txt");
            return filePath;
        }
        //get all questions
        public List<string> GettAll()
        {
            List<string> sentences = new List<string>();
            string filePath = FindQuestionFile();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sentences.Add(line); 
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while reading file: " + e.Message);
            }

            return sentences;
        }
        //add a new question
        public void AddQuestion(string newQuestion)
        {
            string filePath = FindQuestionFile();

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(newQuestion);
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error occurred while adding question: {ex.Message}");
                throw; 
            }
        }
        //delete a specific question
        public void DeleteQuestion(string deleteQuestion)
        {
            string filePath = FindQuestionFile();

            try
            {
                // Read all lines of the file
                List<string> lines = new List<string>(File.ReadAllLines(filePath));

                // Find the line containing the question to be deleted
                string lineToRemove = lines.Find(line => line.Contains(deleteQuestion));

                // If found, remove the line from the list
                if (lineToRemove != null)
                {
                    lines.Remove(lineToRemove);

                    // Write the lines back to the file
                    File.WriteAllLines(filePath, lines);
                    Console.WriteLine("Question deleted.");
                }
                else
                {
                    Console.WriteLine("Question not found.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while deleting question: " + e.Message);
            }


        }
    }


    
}
