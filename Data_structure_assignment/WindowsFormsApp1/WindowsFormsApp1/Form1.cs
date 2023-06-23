using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> colorsName = new List<string>();
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (StreamReader reader = new StreamReader("colors.csv"))
                {
                    string data = "";
                    // Read file contents line by line
                    //ignore the first line of the csv file(name the column name)

                    string headerLine = reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] fields = line.Split(',');

                        if (fields.Length > 0)
                        {
                            colorsName.Add(fields[1]);
                        }
                    }
                    //colorsName.Add(data);                   
                }
                statusFile.Text = "File loaded !";

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void insert_bttn_Click(object sender, EventArgs e)
        {
        

        }

        private void Search_bttn_Click(object sender, EventArgs e)
        {

            //fix selecting the rows
            //checking the layout of programm
            if (Option_combo.SelectedIndex.Equals(2) && QuickSort_radio.Checked)
            {
                //make a quicksort with colorName
               
                int left = 0;
                int right = colorsName.Count - 1;
                
                List<Tuple<string, int>> colors = new List<Tuple<string, int>>();

                // add to the list the colors name with their original indexes
                for (int i = 0; i < colorsName.Count; i++)
                {
                    Tuple<string, int> tuple = Tuple.Create(colorsName[i], i);
                    colors.Add(tuple);
                }

                // list is sorted based on the color name
                colors.Sort((a, b) => string.Compare(a.Item1, b.Item1));

                //sort the List colors with Quicksort
                result_TB.Text += string.Join(Environment.NewLine, colors.Select(x => x.Item1 + " " + x.Item2));

            }

            if (LinearSearch_radio.Checked)
            {
                Boolean found = false;
                string target = colorNameInput.Text;

                for(int i = 0; i < colorsName.Count; i++)
                {
                    if (colorsName[i] == target){ //if the list index contains the word we are searching for
                        result_TB.Text = target + " color name found at index " + i.ToString();
                        found = true; //found it then set the flag found to true
                        break; //exit from the loop
                    }
                }
                if (!found)
                {
                    result_TB.Text = "Color name not found !";
                }
            }

            if (Option_combo.SelectedIndex.Equals(2) && BubbleSort_radio.Checked)
            {
                // Make a quicksort with colorName

                int left = 0;
                int right = colorsName.Count - 1;

                List<Tuple<string, int>> colors = new List<Tuple<string, int>>();

                // Add to the list the colors name with their original indexes
                for (int i = 0; i < colorsName.Count; i++)
                {
                    Tuple<string, int> tuple = Tuple.Create(colorsName[i], i);
                    colors.Add(tuple);
                }

                // Bubble sort implementation
                for (int i = 0; i < colors.Count - 1; i++)
                {
                    for (int j = 0; j < colors.Count - i - 1; j++)
                    {
                        if (string.Compare(colors[j].Item1, colors[j + 1].Item1) > 0)
                        {
                            // Swap the elements
                            Tuple<string, int> temp = colors[j];
                            colors[j] = colors[j + 1];
                            colors[j + 1] = temp;
                        }
                    }
                }

                // Sort the List colors with Bubble sort
                result_TB.Text += string.Join(Environment.NewLine, colors.Select(x => x.Item1 + " " + x.Item2));
            }

            if (BinarySearch_radio.Checked)
            {
                int low = 0;
                int high = colorsName.Count - 1;
                int middle;
                string target = colorNameInput.Text;
                Boolean found = false;

                List<Tuple<string, int>> colors = new List<Tuple<string, int>>();

                // add to the list the colors name with their original indexes
                for (int i = 0; i < colorsName.Count; i++)
                {
                    Tuple<string, int> tuple = Tuple.Create(colorsName[i], i);
                    colors.Add(tuple);
                }

                // list is sorted based on the color name
                colors.Sort((a, b) => string.Compare(a.Item1, b.Item1));


                while (low <= high)
                {
                    middle = (low + high) / 2;

                    if (string.Compare(colors[middle].Item1, target) < 0)
                    {
                        low = middle + 1;
                    }
                    else if (string.Compare(colors[middle].Item1, target) > 0)
                    {
                        high = middle - 1;
                    }
                    else
                    {
                        result_TB.Text = target + " color name found at index " + colors[middle].Item2.ToString();
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    result_TB.Text = "Color name not found !";
                }
            }
           
        }

        private void LinearSearch_radio_CheckedChanged(object sender, EventArgs e)
        {
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Option_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

