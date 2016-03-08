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
using TestSuperLib.Week_1;

namespace TestSuperLib
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnChapter1_Click(object sender, EventArgs e)
        {
            Chapter1 chapter1 = new Chapter1();
            chapter1.ShowDialog();
        }

        private void btnChapter2_Click(object sender, EventArgs e)
        {
            Chapter2 chapter2 = new Chapter2();
            chapter2.ShowDialog();
        }

        private void btnChapter3_Click(object sender, EventArgs e)
        {
            Chapter3 chapter3 = new Chapter3();
            chapter3.ShowDialog();
        }

        private void btnChapter4_Click(object sender, EventArgs e)
        {
            Chapter4 chapter4 = new Chapter4();
            chapter4.ShowDialog();
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
            testCollections form = new testCollections();
            form.ShowDialog();
        }
    }
}
