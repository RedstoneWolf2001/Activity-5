using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_5
{
    public partial class Form1 : Form
    {
        public Form1(System.IO.Stream input)
        {
            InitializeComponent();
            try
            {

                FileDialogue.ShowDialog();

                input = FileDialogue.OpenFile();

                StreamReader streamReader = new StreamReader(input);

                List<string> wordsList = new List<string>();

                string first, last, longest = "", mostVowels = "";
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                string ioStream = streamReader.ReadToEnd();

                string[] words = ioStream.Split(' ', '\n');

                for (int i = 0; i < words.Length; i++)
                    wordsList.Add(words[i]);

                wordsList.Sort();               // alphabetize 


                for (int i = 0; i < wordsList.Count; i++)
                {
                    wordsList[i].ToLower();     // lowercase
                }

                first = wordsList[0];           // first and last word alphabetically
                last = wordsList[wordsList.Count - 1];


                for (int i = 0; i < wordsList.Count; i++)
                    if (longest.Length < wordsList[i].Length)
                        longest = wordsList[i]; // longest term



                int maxNumVowels = 0;
                for (int w = 0; w < wordsList.Count; w++)           //what word   i'm working on
                {
                    int numVowels = 0;
                    for (int l = 0; l < wordsList[w].Length; l++)   //what letter i'm working on
                    {
                        for (int v = 0; v < vowels.Length; v++)     //what vowel  i'm working on
                        {
                            if (wordsList[w].ElementAt(l) == vowels[v])
                            {
                                numVowels++;
                            }
                        }
                    }

                    
                    if (numVowels > maxNumVowels)
                    {
                        maxNumVowels = numVowels;
                        mostVowels = wordsList[w];
                    }
                }

                StreamWriter output;
                output = File.CreateText("stats.txt");

                output.WriteLine("First Word Alphabetically: " + first);
                firstTB.Text = first;

                output.WriteLine("Last Word Alphabetically: " + last);
                lastTB.Text = last;

                output.WriteLine("Longest Word: " + longest);
                longestTB.Text = longest;

                output.WriteLine("Word with the most vowels: " + mostVowels);
                mostTB.Text = mostVowels;

                output.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

    }
}
