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
    public partial class testSortingAlgorithms : Form
    {
        public testSortingAlgorithms()
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
            for (int i = 0; i < (numericUpDownNoOfElements.Value); i++)
            {
                array[i] = generator.Next((int) numericUpDownRangeFrom.Value, (int) numericUpDownRangeTo.Value);
                sortedArray[i] = i;
            }
            log("Original array:\r\n");
            foreach (var v in array)
            {
                log(v + " ");
            }
            log("\r\n");

            log("Test results (" + array.Count() + " ints - random " + numericUpDownRangeFrom.Value + " - " +
                numericUpDownRangeTo.Value + "): \r\n");

            switch (comboBoxTypeAlgorithm.SelectedIndex)
            {
                case 0: //all:
                    int[] copy1 = (int[])array.Clone();
                    int[] copy2 = (int[])array.Clone();
                    int[] copy3 = (int[])array.Clone();
                    int[] copy4 = (int[])array.Clone();
                    testBubbleSort(copy1);
                    testInsertionSort(copy2);
                    testSelectionSort(copy3);
                    testSmartBubbleSort(copy4);
                    break;
               case 1: //bubble sort
                    int[] copy5 = (int[])array.Clone();
                    testBubbleSort(copy5);
                    break;
                case 2://insertion sort
                    int[] copy6 = (int[])array.Clone();
                    testInsertionSort(copy6);
                    break;
                case 3: //selection sort
                    int[] copy7 = (int[])array.Clone();
                    testSelectionSort(copy7);
                    break;
                case 4: //Smart bubble sort
                    int[] copy8 = (int[])array.Clone();
                    testSmartBubbleSort(copy8);
                    break;
                default:
                    MessageBox.Show("Error in switch case statement of choosing the kind of sorting algorithm.");
                    break;
            }

            //var smartBubbleSortRandAction = Timing.Time(() =>
            //{
            //    return new NoResult();
            //    //SmartBubbleSort.Sort(ref smartBubbleSortRand); 
            //});
            //var insertionSortRandAction = Timing.Time(() => { InsertionSort.Sort(ref array); return new NoResult(); });
            //var selectionSortRandAction = Timing.Time(() => { SelectionSort.Sort(ref array); return new NoResult(); });

            //var bubbleSortAction = Timing.Time(() => { BubbleSort.Sort(ref sortedArray); return new NoResult(); });
            //var smartBubbleSortAction = Timing.Time(() =>
            //{
            //    SmartBubbleSort.Sort(ref sortedArray);
            //    return new NoResult();
            //});
            //var insertionSortAction = Timing.Time(() => { InsertionSort.Sort(ref sortedArray); return new NoResult(); });
            //var selectionSortAction = Timing.Time(() => { SelectionSort.Sort(ref sortedArray); return new NoResult(); });

            //log("Test results (" + array.Count() + " ints - random " + numericUpDownRangeFrom.Value + " - " + numericUpDownRangeTo.Value + "): \r\n" +
            //                "SmartBubbleSort:" + $"{smartBubbleSortRandAction.Time:0.00000000}" + "\r\n" +
            //                "InsertionSort: " + $"{insertionSortRandAction.Time:0.00000000}" + "\r\n" +
            //                "SelectionSort: " + $"{selectionSortRandAction.Time:0.00000000}" + "\r\n" +
            //                "Test results (Sorted array, size: " + array.Count() + " - ascending):\r\n" +
            //                "BubbleSort: " + $"{bubbleSortAction.Time:0.00000000}" + "\r\n" +
            //                "SmartBubbleSort: " + $"{smartBubbleSortAction.Time:0.00000000}" + "\r\n" +
            //                "InsertionSort: " + $"{insertionSortAction.Time:0.00000000}" + "\r\n" +
            //                "SelectionSort: " + $"{selectionSortAction.Time:0.00000000}");

            //waarom geeft bubbleSortRandAction een noResult terug?
        }

        private void testBubbleSort(int[] array)
        {
            var bubbleSortRandAction = Timing.Time(() => { BubbleSort.Sort(ref array); return new NoResult(); });
            log("BubbleSort:" + $"{bubbleSortRandAction.Time:0.00000000}" + "\r\n");
        }

        private void testInsertionSort(int[] array)
        {
           var InsertionSortRandAction = Timing.Time(() =>
            {
                SelectionSort.Sort(ref array);
                return new NoResult();
            });
            log("InsertionSort:" + $"{InsertionSortRandAction.Time:0.00000000}" + "\r\n");
        }

        private void testSelectionSort(int[] array)
        {
            var SelectionSortRandAction = Timing.Time(() =>
            {
                SelectionSort.Sort(ref array);
                return new NoResult();
            });
            log("Selectionsort:" + $"{SelectionSortRandAction.Time:0.00000000}" + "\r\n");
        }

        private void testSmartBubbleSort(int[] array)
        {
            var smartBubbleSortRandAction = Timing.Time(() =>
            {
                SmartBubbleSort.Sort(ref array);
                return new NoResult();
            });
            log("Smart BubbleSort:" + $"{smartBubbleSortRandAction.Time:0.00000000}" + "\r\n");
        }

        private void log(String value)
        {
            textBoxResults.AppendText(value);
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
