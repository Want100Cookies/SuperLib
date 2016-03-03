using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperLib.Sort
{
    public partial class testSearchingAlgorithms : Form
    {
        public testSearchingAlgorithms()
        {
            InitializeComponent();

            numericUpDownRangeTo.Value = 200;
            numericUpDownNoOfElements.Value = 100;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //array aanmaken
            //array vullen met random waardes (random generator klasse maken?)
            //array sorteren
            //tijdmeting starten
            //methode aanroepen 
            //tijdmeting stoppen
            int size = (int)numericUpDownNoOfElements.Value;
            int[] array = new int[size];
            
            Random generator = new Random();
            for (int i = 0; i < (numericUpDownNoOfElements.Value); i++)
            {
                array[i] = generator.Next((int)numericUpDownRangeFrom.Value, (int)numericUpDownRangeTo.Value);
            }
            InsertionSort.Sort(ref array);

            log("Original array:\r\n");
            foreach (var v in array)
            {
                log(v.ToString() + " ");
            }
            log("\r\n");
        }

        private void log(string s)
        {
            textBoxOutput.AppendText(s);
        }
    }
}
