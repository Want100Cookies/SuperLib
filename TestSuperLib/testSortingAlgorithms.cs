using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SuperLib;
using SuperLib.Sort;

namespace TestSuperLib
{
    public partial class TestSortingAlgorithms : Form
    {
        public TestSortingAlgorithms()
        {
            InitializeComponent();

            testSortingAlgorithms_Resize(null, null);

            comboBoxDatatype.SelectedIndex = comboBoxTypeAlgorithm.SelectedIndex = 0;
            numericUpDownRangeTo.Value = 200;
            numericUpDownNoOfElements.Value = 100;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            //soort sorteren bepalen.
            //datatype bepalen: en array vullen met dat datatype.
            //tijdmeting starten
            //sorteren
            //tijdmeting stoppen.
            int size = (int) numericUpDownNoOfElements.Value;
            int[] array = new int[size];
            int[] sortedArray = new int[size];

            Random generator = new Random();
            Log("Original array:\r\n");
            for (int i = 0; i < (numericUpDownNoOfElements.Value); i++)
            {
                array[i] = generator.Next((int) numericUpDownRangeFrom.Value, (int) numericUpDownRangeTo.Value);
                Log(array[i] + " ");
                sortedArray[i] = i;
            }
            Log("\r\n");

            Log("Test results (" + array.Count() + " ints - random " + numericUpDownRangeFrom.Value + " - " +
                numericUpDownRangeTo.Value + "): \r\n");

            bool doBreak = true;

            switch (comboBoxTypeAlgorithm.SelectedIndex)
            {
                /*
                * note: efficiency is real...
                * pascal -> Let's make it more efficient
                */

                case 0: //all:
                    doBreak = false;
                    goto case 1;

                case 1: //bubble sort
                    int[] copy5 = (int[])array.Clone();
                    TestBubbleSort(copy5);
                    if (chkBoxViewResult.Checked) LogResult(copy5, "Bubble sort");
                    if (doBreak) break;
                    goto case 2;

                case 2://insertion sort
                    int[] copy6 = (int[])array.Clone();
                    TestInsertionSort(copy6);
                    if (chkBoxViewResult.Checked) LogResult(copy6, "Insertion sort");
                    if (doBreak) break;
                    goto case 3;

                case 3: //selection sort
                    int[] copy7 = (int[])array.Clone();
                    TestSelectionSort(copy7);
                    if (chkBoxViewResult.Checked) LogResult(copy7, "Selection sort");
                    if (doBreak) break;
                    goto case 4;

                case 4: //Smart bubble sort
                    int[] copy8 = (int[])array.Clone();
                    TestSmartBubbleSort(copy8);
                    if (chkBoxViewResult.Checked) LogResult(copy8, "Smart bubble sort");
                    break;

                default:
                    MessageBox.Show("Error in switch case statement of choosing the kind of sorting algorithm.");
                    break;
            }
        }

        private void TestBubbleSort(int[] array)
        {
            var bubbleSortRandAction = Timing.Time(() => { BubbleSort.Sort(ref array); return new NoResult(); });
            Log("BubbleSort:\t\t" + $"{bubbleSortRandAction.Time:0.00000000}" + "\r\n");
        }

        private void TestInsertionSort(int[] array)
        {
           var insertionSortRandAction = Timing.Time(() =>
            {
                SelectionSort.Sort(ref array);
                return new NoResult();
            });
            Log("InsertionSort:\t\t" + $"{insertionSortRandAction.Time:0.00000000}" + "\r\n");
        }

        private void TestSelectionSort(int[] array)
        {
            var selectionSortRandAction = Timing.Time(() =>
            {
                SelectionSort.Sort(ref array);
                return new NoResult();
            });
            Log("Selection Sort:\t\t" + $"{selectionSortRandAction.Time:0.00000000}" + "\r\n");
        }

        private void TestSmartBubbleSort(int[] array)
        {
            var smartBubbleSortRandAction = Timing.Time(() =>
            {
                SmartBubbleSort.Sort(ref array);
                return new NoResult();
            });
            Log("Smart BubbleSort:\t\t" + $"{smartBubbleSortRandAction.Time:0.00000000}" + "\r\n");
        }

        private void Log(string value)
        {
            textBoxResults.AppendText(value);
        }

        private void LogResult(int[] array, string sortName)
        {
            Log("Resulting array for " + sortName + ":\r\n");
            foreach (var v in array)
            {
                Log(v + " ");
            }
            Log("\r\n");
        }

        private void numericUpDownRangeFrom_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownRangeFrom.Value >= numericUpDownRangeTo.Value)
            {
                numericUpDownRangeTo.Value = numericUpDownRangeFrom.Value + 1;
            }
        }

        private void numericUpDownRangeTo_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRangeFrom_ValueChanged(sender,e);
        }

        private void testSortingAlgorithms_Resize(object sender, EventArgs e)
        {
            textBoxResults.Width = Width - 275;
        }
    }
}
