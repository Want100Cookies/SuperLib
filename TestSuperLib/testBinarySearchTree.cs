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

namespace TestSuperLib
{
    public partial class testBinarySearchTree : Form
    {
        private BinarySearchTree<int> BST; 

        public testBinarySearchTree()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Output.Clear();

            Random rnd = new Random();

            BST = new BinarySearchTree<int>();

            for (int i = 0; i < numericUpDownNoItems.Value; i++)
            {
                BST.Insert(rnd.Next((int)numericUpDownRandomStart.Value, (int)numericUpDownRandomStop.Value));
            }

            foreach (int i in BST.EnumerableInOrder(BST.RootNode))
            {
                Output.AppendText(i + " ");
            }

            printBST(BST.RootNode);
        }

        private void printBST(BinarySearchTree<int>.Node<int> node, string indent = "", bool last = true)
        {
            if (node == null) return;

            Output.AppendText("\r\n" + indent);

            if (last)
            {
                Output.AppendText("\\-");
                indent += " ";
            }
            else
            {
                Output.AppendText("|-");
                indent += "| ";
            }

            Output.AppendText(node.Data.ToString());

            printBST(node.Left, indent, node.Right == null);
            printBST(node.Right, indent);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = BST.Delete((int)numericUpDownDelete.Value);
            Output.AppendText("\r\nDeleted node? " + success + "\r\n\r\n");

            printBST(BST.RootNode);

            //var node = BST.FindNode((int) numericUpDownDelete.Value);
            //Output.AppendText("\r\nFound node: " + node.Data);
        }
    }
}
