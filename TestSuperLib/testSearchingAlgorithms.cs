using System;
using System.Windows.Forms;
using SuperLib;
using SuperLib.Search;
using SuperLib.Sort;

namespace TestSuperLib
{
    public partial class TestSearchingAlgorithms : Form
    {
        private int[] Array;

        public TestSearchingAlgorithms()
        {
            InitializeComponent();

            numericUpDownRangeTo.Value = 200;
            numericUpDownNoOfElements.Value = 100;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int toSearch = (int)numericUpDownValueToSearch.Value;

            var BinarySearch = Timing.Time(() => SuperLib.Search.BinarySearch.Search(Array, toSearch));
            var MinSearch = Timing.Time(() => MinMax.FindMin(Array));
            var MaxSearch = Timing.Time(() => MinMax.FindMax(Array));
            var SeqSearch = Timing.Time(() => SuperLib.Search.SeqSearch.FindFirst(Array, toSearch));

            log("Binary search result: " + BinarySearch.ReturnValue + "\r\n");
            log("Min search result: " + MinSearch.ReturnValue + "\r\n");
            log("Max search result: " + MaxSearch.ReturnValue + "\r\n");
            log("Sequential search result: " + SeqSearch.ReturnValue + "\r\n");

            log("Timing:\r\nBinary search: " + BinarySearch.Time);
            log("\r\nMin search: " + MinSearch.Time);
            log("\r\nMax search: " + MaxSearch.Time);
            log("\r\nSequential search: " + SeqSearch.Time + "\r\n");

        }

        private void log(string s)
        {
            textBoxOutput.AppendText(s);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDownNoOfElements.Value;
            Array = new int[size];

            Random generator = new Random();
            log("Original array:\r\n");
            for (int i = 0; i < (numericUpDownNoOfElements.Value); i++)
            {
                Array[i] = generator.Next((int)numericUpDownRangeFrom.Value, (int)numericUpDownRangeTo.Value);
            }

            SmartBubbleSort.Sort(ref Array);
            foreach (int i in Array)
            {
                log(i + " ");
            }
            log("\r\n");
        }
    }
}
