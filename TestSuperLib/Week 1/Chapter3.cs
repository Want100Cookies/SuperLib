using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperLib;
using SuperLib.Collections;
using SuperLib.Sort;

namespace TestSuperLib.Week_1
{
    public partial class Chapter3 : Form
    {
        public Chapter3()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int size = 100;

            int[] bubbleSort = new int[size];
            int[] smartBubbleSort = new int[size];
            int[] insertionSort = new int[size];
            int[] selectionSort = new int[size];

            Random rnd = new Random(100);
            for (int i = 0; i < size-1; i++)
            {
                int value = (int) (rnd.NextDouble()*100);

                bubbleSort[i] = value;
                smartBubbleSort[i] = value;
                insertionSort[i] = value;
                selectionSort[i] = value;
            }

            var bubbleSortResult = Timing.Time(() => 
            {
                BubbleSort.Sort(ref bubbleSort);
                return new NoResult();
            });

            var smartBubbleSortResult = Timing.Time(() =>
            {
                //SmartBubbleSort.Sort(ref smartBubbleSort); // not implemented
                return new NoResult();
            });

            var insertionSortResult = Timing.Time(() =>
            {
                InsertionSort.Sort(ref insertionSort);
                return new NoResult();
            });

            var selectionSortResult = Timing.Time(() =>
            {
                SelectionSort.Sort(ref selectionSort);
                return new NoResult();
            });

            StringBuilder stringBuilder = new StringBuilder("Result of test (random, 100 integers between 0 - 100): \n");

            stringBuilder.Append("BubbleSort: \t" + $"{bubbleSortResult.Time:0.00000000}" + "s \n");
            stringBuilder.Append("SmartBubbleSort: \t" + $"{smartBubbleSortResult.Time:0.00000000}" + "s \n");
            stringBuilder.Append("InsertionSort: \t" + $"{insertionSortResult.Time:0.00000000}" + "s \n");
            stringBuilder.Append("SelectionSort: \t" + $"{selectionSortResult.Time:0.00000000}" + "s");

            MessageBox.Show(stringBuilder.ToString());
        }

        private void btnCompare2_Click(object sender, EventArgs e)
        {
            int size = 1000;

            int[] bubbleSortRand = new int[size];
            int[] smartBubbleSortRand = new int[size];
            int[] insertionSortRand = new int[size];
            int[] selectionSortRand = new int[size];
            int[] bubbleSort = new int[size];
            int[] smartBubbleSort = new int[size];
            int[] insertionSort = new int[size];
            int[] selectionSort = new int[size];

            Random rnd = new Random(100);
            for (int i = 0; i < size-1; i++)
            {
                int value = (int)(rnd.NextDouble() * 100);

                bubbleSortRand[i] = value;
                smartBubbleSortRand[i] = value;
                insertionSortRand[i] = value;
                selectionSortRand[i] = value;
                bubbleSort[i] = (i);
                smartBubbleSort[i] = (i);
                insertionSort[i] = (i);
                selectionSort[i] = (i);
            }

            var bubbleSortRandAction = Timing.Time(() => { BubbleSort.Sort(ref bubbleSortRand); return new NoResult(); });
            var smartBubbleSortRandAction = Timing.Time(() =>
            {
                return new NoResult();
                //SmartBubbleSort.Sort(ref smartBubbleSortRand); 
            });
            var insertionSortRandAction = Timing.Time(() => { InsertionSort.Sort(ref insertionSortRand); return new NoResult(); });
            var selectionSortRandAction = Timing.Time(() => { SelectionSort.Sort(ref selectionSortRand); return new NoResult(); });

            var bubbleSortAction = Timing.Time(() => { BubbleSort.Sort(ref bubbleSort); return new NoResult(); });
            var smartBubbleSortAction = Timing.Time(() =>
            {
                return new NoResult();
                //SmartBubbleSort.Sort(ref smartBubbleSort); 
            });
            var insertionSortAction = Timing.Time(() => { InsertionSort.Sort(ref insertionSort); return new NoResult(); });
            var selectionSortAction = Timing.Time(() => { SelectionSort.Sort(ref selectionSort); return new NoResult(); });

            MessageBox.Show("Test results (1000 ints - random 0-100): \n" +
                            "\tBubbleSort: \t" + $"{bubbleSortRandAction.Time:0.00000000}" + "\n" +
                            "\tSmartBubbleSort: \t" + $"{smartBubbleSortRandAction.Time:0.00000000}" + "\n" +
                            "\tInsertionSort: \t" + $"{insertionSortRandAction.Time:0.00000000}" + "\n" +
                            "\tSelectionSort: \t" + $"{selectionSortRandAction.Time:0.00000000}" + "\n" +
                            "Test results (1000 ints - ascending):\n" +
                            "\tBubbleSort: \t" + $"{bubbleSortAction.Time:0.00000000}" + "\n" +
                            "\tSmartBubbleSort: \t" + $"{smartBubbleSortAction.Time:0.00000000}" + "\n" +
                            "\tInsertionSort: \t" + $"{insertionSortAction.Time:0.00000000}" + "\n" +
                            "\tSelectionSort: \t" + $"{selectionSortAction.Time:0.00000000}");
        }

        private void btnCompare3_Click(object sender, EventArgs e)
        {
            int size = 1000;

            int[] bubbleSort = new int[size];
            int[] smartBubbleSort = new int[size];
            int[] insertionSort = new int[size];
            int[] selectionSort = new int[size];

            for (int i = 999; i >= 0; i--)
            {
                bubbleSort[i] = (i);
                smartBubbleSort[i] = (i);
                insertionSort[i] = (i);
                selectionSort[i] = (i);
            }

            var bubbleSortAction = Timing.Time(() =>
            {
                BubbleSort.Sort(ref bubbleSort);
                return new NoResult();
            });

            var smartBubbleSortAction = Timing.Time(() =>
            {
                SmartBubbleSort.Sort(ref smartBubbleSort);
                return new NoResult();
            });

            var insertionSortAction = Timing.Time(() =>
            {
                InsertionSort.Sort(ref insertionSort);
                return new NoResult();
            });

            var selectionSortAction = Timing.Time(() =>
            {
                SelectionSort.Sort(ref selectionSort);
                return new NoResult();
            });

            StringBuilder stringBuilder = new StringBuilder("Result of test (1000 ascending ints): \n");

            stringBuilder.Append("BubbleSort: \t" + $"{bubbleSortAction.Time:0.00000000}" + "s \n");
            stringBuilder.Append("SmartBubbleSort: \t" + $"{smartBubbleSortAction.Time:0.00000000}" + "s \n");
            stringBuilder.Append("InsertionSort: \t" + $"{insertionSortAction.Time:0.00000000}" + "s \n");
            stringBuilder.Append("SelectionSort: \t" + $"{selectionSortAction.Time:0.00000000}" + "s");

            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
