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

namespace TestSuperLib
{
    public partial class testCollections : Form
    {
        public testCollections()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            BucketHash<int> bucketHash = new BucketHash<int>();
            LinearHash<int> linearHash = new LinearHash<int>();
            QuadraticHash<int> quadraticHash = new QuadraticHash<int>();

            int[] array = new int[50];

            for (int i = 0; i < 50; i++)
            {
                array[i] = rnd.Next(0, 100);
            }

            log("Test result:\r\nBucketHash: ");

            var resultBucketHash = Timing.Time(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    bucketHash.Insert(array[i]);
                }
                return new NoResult();
            });

            log($"{resultBucketHash.Time:0.00000000}" + "\r\nLinearHash: ");

            var resultLinearHash = Timing.Time(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    linearHash.Insert(array[i]);
                }
                return new NoResult();
            });

            log($"{resultLinearHash.Time:0.00000000}" + "\r\n\r\nOriginal array:\r\n");

            foreach (int i in array)
            {
                log(i + " ");
            }

            log("\r\nBucketHash:\r\n");

            foreach (int i in bucketHash)
            {
                log(i + " ");
            }

            log("\r\nLinearHash:\r\n");

            foreach (int i in linearHash)
            {
                log(i + " ");
            }
        }

        private void log(string str)
        {
            textBoxLog.AppendText(str);
        }
    }
}
