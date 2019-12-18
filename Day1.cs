using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdventOfCode
{
    public partial class Day1 : Form
    {
        public Day1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Declare variables for input and output paths and output file.
            string inputFilePath = importFilePathTextBox.Text;
            string outputFilePath = exportFilePathTextBox.Text;
            int fileLength;

            //Check to see if user entered anything for the output filepath, if not default to the same directory as input with 'Day1Output.txt' 
            //as its name.
            if(string.IsNullOrEmpty(outputFilePath) == true)
            {
                outputFilePath = String.Format(Path.GetDirectoryName(inputFilePath) + "\\Day1Output.txt");
            }

            //If the user inputs an invalid import filepath, return an error popup and prompt for a valid input path
            if (File.Exists(inputFilePath) == false)
            {
                MessageBox.Show("Please enter a valid file path.", "Error:Invalid File Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Read each line of the input file into an array
            string[] input = System.IO.File.ReadAllLines(inputFilePath);
            fileLength = input.Length;
            
            //Declare output filepath for the streamwriter
            using (var output = new StreamWriter(outputFilePath))
            {

                //for each entry in the input list, divide by 3, round down, and then subtract 2. Finally write that to the output file.
                for (int i = 0; i < fileLength; i++)
                {
                    decimal entry = Convert.ToDecimal(input[i]);
                    entry = entry / 3;
                    entry = Math.Floor(entry);
                    entry = entry - 2;
                    output.Write(entry + "\r\n");
                }
            }
        }
    }
}
