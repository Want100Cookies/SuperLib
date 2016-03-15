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
        public testBinarySearchTree()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            BinarySearchTree<int> BST = new BinarySearchTree<int>();

            for (int i = 0; i < numericUpDownNoItems.Value; i++)
            {
                BST.Insert(rnd.Next((int)numericUpDownRandomStart.Value, (int)numericUpDownRandomStop.Value));
            }

            foreach (int i in BST.EnumerableInOrder(BST.RootNode))
            {
                Output.AppendText(i + " ");
            }

            printBST(BST.RootNode, 1);
        }

        private void printBST(BinarySearchTree<int>.Node<int> node, int depth)
        {
            if (node == null) return;

            for (int i = 0; i < depth; i++)
            {
                Output.AppendText("-");
            }
            Output.AppendText(node.Data + "\r\n");
            depth++;
            printBST(node.Left, depth);
            printBST(node.Right, depth);
        }
    }
}
