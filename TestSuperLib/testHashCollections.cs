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

namespace TestSuperLib
{
    public partial class testHashCollections : Form
    {
        public testHashCollections()
        {
            InitializeComponent();
        }

        public static string RandomString(int length, Random random)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            BucketHash<string> bucketHash = new BucketHash<string>(50);
            LinearHash<string> linearHash = new LinearHash<string>(101);
            QuadraticHash<string> quadraticHash = new QuadraticHash<string>(200);

            int noItems = 70;

            string[] array = new string[noItems];

            for (int i = 0; i < noItems; i++)
            {
                array[i] = RandomString(5, rnd);
            }

            log("Test result:\r\nBucketHash: ");

            var resultBucketHash = Timing.Time(() =>
            {
                for (int i = 0; i < noItems; i++)
                {
                    bucketHash.Insert(array[i]);
                }
                return new NoResult();
            });

            log($"{resultBucketHash.Time:0.00000000}" + "\r\nLinearHash: ");

            var resultLinearHash = Timing.Time(() =>
            {
                for (int i = 0; i < noItems; i++)
                {
                    linearHash.Insert(array[i]);
                }
                return new NoResult();
            });

            log($"{resultLinearHash.Time:0.00000000}" + "\r\nQuadraticHash: ");

            var resultQuadraticHash = Timing.Time(() =>
            {
                for (int i = 0; i < noItems; i++)
                {
                    quadraticHash.Insert(array[i]);
                }
                return new NoResult();
            });

            log($"{resultQuadraticHash.Time:0.00000000}" + "\r\n\r\nAll sorted\r\nOriginal array:\r\n");

            foreach (var i in array)
            {
                log(i + " ");
            }

            log("\r\nBucketHash:\r\n");

            foreach (var i in bucketHash)
            {
                log(i + " ");
            }

            log("\r\nLinearHash:\r\n");

            foreach (var i in linearHash)
            {
                log(i + " ");
            }

            log("\r\nQuadraticHash:\r\n");

            foreach (var i in quadraticHash)
            {
                log(i + " ");
            }

            var bucketArray = bucketHash.ToArray();
            var linearArray = linearHash.ToArray();
            var quadraticArray = quadraticHash.ToArray();

            SmartBubbleSort.Sort(ref array);
            SmartBubbleSort.Sort(ref bucketArray);
            SmartBubbleSort.Sort(ref linearArray);
            SmartBubbleSort.Sort(ref quadraticArray);

            if (array.SequenceEqual(bucketArray))
            {
                log("\r\nBucketHash contains all elements!");
            }

            if (array.SequenceEqual(linearArray))
            {
                log("\r\nLinearHash contains all elements!");
            }

            if (array.SequenceEqual(quadraticArray))
            {
                log("\r\nQuadraticHash contains all elements!");
            }
        }

        private void log(string str)
        {
            textBoxLog.AppendText(str);
        }
    }
}
