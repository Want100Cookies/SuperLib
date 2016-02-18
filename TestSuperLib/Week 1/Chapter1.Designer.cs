namespace TestSuperLib.Week_1
{
    partial class Chapter1
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lstBoxTests = new System.Windows.Forms.ListBox();
            this.btnTurnIn = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnTestSuperCollection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(120, 43);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(234, 26);
            this.txtBoxName.TabIndex = 0;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(120, 77);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(63, 26);
            this.txtBoxNumber.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 80);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(102, 20);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Test number:";
            // 
            // lstBoxTests
            // 
            this.lstBoxTests.FormattingEnabled = true;
            this.lstBoxTests.ItemHeight = 20;
            this.lstBoxTests.Location = new System.Drawing.Point(360, 43);
            this.lstBoxTests.Name = "lstBoxTests";
            this.lstBoxTests.Size = new System.Drawing.Size(290, 124);
            this.lstBoxTests.TabIndex = 4;
            // 
            // btnTurnIn
            // 
            this.btnTurnIn.Location = new System.Drawing.Point(16, 127);
            this.btnTurnIn.Name = "btnTurnIn";
            this.btnTurnIn.Size = new System.Drawing.Size(80, 37);
            this.btnTurnIn.TabIndex = 5;
            this.btnTurnIn.Text = "Turn in";
            this.btnTurnIn.UseVisualStyleBackColor = true;
            this.btnTurnIn.Click += new System.EventHandler(this.btnTurnIn_Click);
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(102, 127);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(80, 37);
            this.btnLook.TabIndex = 6;
            this.btnLook.Text = "Look";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(188, 127);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(80, 37);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(274, 127);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Exercise 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Exercise 3";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(16, 218);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(376, 40);
            this.btnCompare.TabIndex = 11;
            this.btnCompare.Text = "Compare speed ArrayList vs SuperLib.Collection";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnTestSuperCollection
            // 
            this.btnTestSuperCollection.Location = new System.Drawing.Point(17, 317);
            this.btnTestSuperCollection.Name = "btnTestSuperCollection";
            this.btnTestSuperCollection.Size = new System.Drawing.Size(338, 40);
            this.btnTestSuperCollection.TabIndex = 13;
            this.btnTestSuperCollection.Text = "Test SuperCollection";
            this.btnTestSuperCollection.UseVisualStyleBackColor = true;
            this.btnTestSuperCollection.Click += new System.EventHandler(this.btnTestSuperCollection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Exercise 4";
            // 
            // Chapter1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 541);
            this.Controls.Add(this.btnTestSuperCollection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.btnTurnIn);
            this.Controls.Add(this.lstBoxTests);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.txtBoxName);
            this.Name = "Chapter1";
            this.Text = "Chapter 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chapter_1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ListBox lstBoxTests;
        private System.Windows.Forms.Button btnTurnIn;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnTestSuperCollection;
        private System.Windows.Forms.Label label3;
    }
}