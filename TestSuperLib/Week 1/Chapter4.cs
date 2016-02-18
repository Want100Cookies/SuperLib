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
using SuperLib.Search;
using SuperLib.Sort;

namespace TestSuperLib.Week_1
{
    public partial class Chapter4 : Form
    {
        public Chapter4()
        {
            InitializeComponent();
        }

        private void btnUnorderedBinary_Click(object sender, EventArgs e)
        {
            CArray<int> array = new CArray<int>(100);
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                array.Insert((int) (random.NextDouble()*100));
            }

            array.DisplayElements();
            int toSearch = array.First();
            int result = BinarySearch.Search(array.GetArray(), toSearch);
            array.DisplayElements();
            MessageBox.Show("Searching for: " + toSearch + "\nFound: " + result);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            /*BinarySearch<int> binary = new BinarySearch<int>(1000);
            SeqSearch<int> seqSearch = new SeqSearch<int>(1000);

            Random rnd = new Random();
            int toFind = 0;
            int toFindIndex = (int) (rnd.NextDouble()*1000);

            for (int i = 0; i < 1000; i++)
            {
                int value = (int) (rnd.NextDouble()*100);

                binary.Insert(value);
                seqSearch.Insert(value);

                if (i == toFindIndex)
                {
                    toFind = value;
                }
            }


            binary.Search(toFind, true);
            int binaryComparisons = binary.CompCount;

            seqSearch.FindFirst(toFind);
            int seqFirstComps = seqSearch.CompCount;

            seqSearch.FindLast(toFind);
            int seqLastComps = seqSearch.CompCount;

            MessageBox.Show("Comparison count test results: (1000 random ints between 0-100) \n" +
                            "Searched for " + toFind + " on index " + toFindIndex + "\n" +
                            "Binary search: \t" + binaryComparisons + "\n" +
                            "Sequential first: \t" + seqFirstComps + "\n" +
                            "Sequential last: \t" + seqLastComps);*/
            MessageBox.Show("See code for implementation. Left out for performence");
        }
    }
}
