using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperLib.Collections;
using SuperLib.Sort;

namespace TestSuperLib
{
    public partial class testLinkedCollections : Form
    {
        public testLinkedCollections()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            DoublyLinkedList<int> doubly = new DoublyLinkedList<int>();
            CircularLinkedList<int> circular = new CircularLinkedList<int>();

            int noItems = 70;

            int[] array = new int[noItems];

            for (int i = 0; i < noItems; i++)
            {
                array[i] = rnd.Next(0, 100);
            }

            int previous = array[0];

            doubly.InsertFirst(array[0]);
            circular.InsertFirst(array[0]);

            for (int i = 1; i < noItems; i++)
            {
                doubly.Insert(array[i], previous);
                circular.Insert(array[i], previous);
                previous = array[i];
            }

            log("Original array:\r\n");

            foreach (var i in array)
            {
                log(i + " ");
            }

            log("\r\nDoubly linked list:\r\n");

            foreach (var i in doubly.GetEnumerable())
            {
                log(i + " ");
            }

            log("\r\nDoubly linked list (reversed):\r\n");

            foreach (var i in doubly.GetReverseEnumerable())
            {
                log(i + " ");
            }

            log("\r\nCircular linked list (2 iterations):\r\n");

            foreach (var i in circular.GetEnumerable(2))
            {
                log(i + " ");
            }

            var doublyArray = doubly.GetEnumerable().ToArray();
            var doublyReverseArray = doubly.GetReverseEnumerable().ToArray();

            SmartBubbleSort.Sort(ref array);
            SmartBubbleSort.Sort(ref doublyArray);
            SmartBubbleSort.Sort(ref doublyReverseArray);

            log("\r\nOriginal array (sorted):\r\n");

            foreach (var i in array)
            {
                log(i + " ");
            }

            log("\r\nDoubly linked list (sorted):\r\n");

            foreach (var i in doublyArray)
            {
                log(i + " ");
            }

            log("\r\nDoubly linked list (reversed, sorted):\r\n");

            foreach (var i in doublyReverseArray)
            {
                log(i + " ");
            }

            if (array.SequenceEqual(doublyArray))
            {
                log("\r\nDoubly contains all elements!");
            }

            if (array.SequenceEqual(doublyReverseArray))
            {
                log("\r\nDoubly reverse contains all elements!");
            }
        }

        private void log(string str)
        {
            textBoxLog.AppendText(str);
        }
    }
}
