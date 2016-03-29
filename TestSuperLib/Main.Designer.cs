namespace TestSuperLib
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTestSorting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCollections = new System.Windows.Forms.Button();
            this.btnLinkedCollections = new System.Windows.Forms.Button();
            this.btnTestBinarySearchTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test application";
            // 
            // buttonTestSorting
            // 
            this.buttonTestSorting.Location = new System.Drawing.Point(19, 46);
            this.buttonTestSorting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTestSorting.Name = "buttonTestSorting";
            this.buttonTestSorting.Size = new System.Drawing.Size(263, 54);
            this.buttonTestSorting.TabIndex = 6;
            this.buttonTestSorting.Text = "Test sorting algorithms";
            this.buttonTestSorting.UseVisualStyleBackColor = true;
            this.buttonTestSorting.Click += new System.EventHandler(this.buttonTestSorting_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Test searching algorithms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCollections
            // 
            this.btnCollections.Location = new System.Drawing.Point(558, 46);
            this.btnCollections.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCollections.Name = "btnCollections";
            this.btnCollections.Size = new System.Drawing.Size(263, 54);
            this.btnCollections.TabIndex = 8;
            this.btnCollections.Text = "Test hash collections";
            this.btnCollections.UseVisualStyleBackColor = true;
            this.btnCollections.Click += new System.EventHandler(this.btnCollections_Click);
            // 
            // btnLinkedCollections
            // 
            this.btnLinkedCollections.Location = new System.Drawing.Point(19, 108);
            this.btnLinkedCollections.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLinkedCollections.Name = "btnLinkedCollections";
            this.btnLinkedCollections.Size = new System.Drawing.Size(263, 54);
            this.btnLinkedCollections.TabIndex = 9;
            this.btnLinkedCollections.Text = "Test linked collections";
            this.btnLinkedCollections.UseVisualStyleBackColor = true;
            this.btnLinkedCollections.Click += new System.EventHandler(this.btnLinkedCollections_Click);
            // 
            // btnTestBinarySearchTree
            // 
            this.btnTestBinarySearchTree.Location = new System.Drawing.Point(289, 108);
            this.btnTestBinarySearchTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTestBinarySearchTree.Name = "btnTestBinarySearchTree";
            this.btnTestBinarySearchTree.Size = new System.Drawing.Size(263, 54);
            this.btnTestBinarySearchTree.TabIndex = 10;
            this.btnTestBinarySearchTree.Text = "Test binary search tree";
            this.btnTestBinarySearchTree.UseVisualStyleBackColor = true;
            this.btnTestBinarySearchTree.Click += new System.EventHandler(this.btnTestBinarySearchTree_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 405);
            this.Controls.Add(this.btnTestBinarySearchTree);
            this.Controls.Add(this.btnLinkedCollections);
            this.Controls.Add(this.btnCollections);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTestSorting);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Test for SuperLib";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTestSorting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCollections;
        private System.Windows.Forms.Button btnLinkedCollections;
        private System.Windows.Forms.Button btnTestBinarySearchTree;
    }
}

