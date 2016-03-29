using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperLib.Sort;

namespace TestSuperLib
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonTestSorting_Click(object sender, EventArgs e)
        {
            TestSortingAlgorithms form = new TestSortingAlgorithms();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestSearchingAlgorithms form = new TestSearchingAlgorithms();
            form.ShowDialog();
        }

        private void btnCollections_Click(object sender, EventArgs e)
        {
            testHashCollections form = new testHashCollections();
            form.ShowDialog();
        }

        private void btnLinkedCollections_Click(object sender, EventArgs e)
        {
            testLinkedCollections form = new testLinkedCollections();
            form.ShowDialog();
        }

        private void btnTestBinarySearchTree_Click(object sender, EventArgs e)
        {
            testBinarySearchTree form = new testBinarySearchTree();
            form.ShowDialog();
        }
    }
}
