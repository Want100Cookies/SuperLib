using System;
using System.Collections;
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
using SuperLib.Week_1;


namespace TestSuperLib.Week_1
{
    public partial class Chapter1 : Form
    {
        private Collection _submittedTests;
        private Collection _outForChecking;

        public Chapter1()
        {
            InitializeComponent();

            _submittedTests = new Collection();
            _outForChecking = new Collection();
        }

        private void Chapter_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Parent.Show();
        }

        private void btnTurnIn_Click(object sender, EventArgs e)
        {
            int number; // Init variables
            string name;

            try // Validate the input
            {
                number = int.Parse(txtBoxNumber.Text);
                name = txtBoxName.Text;
                if (name.Length == 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Test test = new Test // Init new test with data
            {
                StudentName = name,
                TestNumber = number
            };

            _submittedTests.Add(test); // Add test to submitted tests

            txtBoxNumber.Clear();
            txtBoxName.Clear();
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Please fill in a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Test test in _submittedTests)
            {
                if (test.StudentName != name) continue;

                _submittedTests.Remove(test);
                _outForChecking.Add(test);
                break;
            }

            txtBoxNumber.Clear();
            txtBoxName.Clear();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Please fill in a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Test test in _outForChecking)
            {
                if (test.StudentName != name) continue;

                _outForChecking.Remove(test);
                _submittedTests.Add(test);
                break;
            }

            txtBoxNumber.Clear();
            txtBoxName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            foreach (Test test in _outForChecking)
            {
                _submittedTests.Add(test);
            }

            _outForChecking.Clear();

            lstBoxTests.Items.Clear();

            foreach (Test test in _submittedTests)
            {
                lstBoxTests.Items.Add(test.StudentName);
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            Collection tmpCollection = new Collection();
            ArrayList tmpArrayList = new ArrayList();

            var collection = Timing.Time<NoResult>(() =>
            {
                for (int i = 0; i < 999999; i++)
                {
                    tmpCollection.Add(i);
                }

                return new NoResult();
            });

            

            var arrayList = Timing.Time<NoResult>(() =>
            {
                for (int i = 0; i < 999999; i++)
                {
                    tmpArrayList.Add(i);
                }

                return new NoResult();
            });

            MessageBox.Show("Collection time = " 
                + collection.Time
                + " s \nArrayList time = " 
                + arrayList.Time 
                + " s",
                "Result");
        }

        private void btnTestSuperCollection_Click(object sender, EventArgs e)
        {
            SuperCollection<string> tmpCollection = new SuperCollection<string>();

            string str1 = "String 1";
            string str2 = "String 2";
            string str3 = "String 3";
            string str4 = "String 4";

            tmpCollection.Add(str1);
            tmpCollection.Add(str2);

            bool result1 = tmpCollection.Contains(str1);

            tmpCollection.Remove(str1);

            bool result2 = tmpCollection.Contains(str1);

            tmpCollection.Add(str1);
            tmpCollection.Add(str3);
            tmpCollection.Add(str4);

            MessageBox.Show("Test 1 (remove str1): " + (result1 != result2));

            StringBuilder strBuilder = new StringBuilder("Test 2 (contents of collection): \n\n");

            foreach (string str in tmpCollection)
            {
                strBuilder.Append(str + "\n");
            }

            MessageBox.Show(strBuilder.ToString());

        }
    }
}
