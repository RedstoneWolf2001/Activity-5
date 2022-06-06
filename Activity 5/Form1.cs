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
                string[] words;
                string first, last, longest = "", mostVowels;
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                int numVowels = 0;
                string ioStream = streamReader.ReadToEnd();

                words = ioStream.Split(' ');
                

                for (int i = 0; i < words.Length; i++)
                {
                    words[i].ToLower();     // lowercase

                    if (longest.Length < words[i].Length)
                        longest = words[i]; // longest term




                    
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

    }
}
