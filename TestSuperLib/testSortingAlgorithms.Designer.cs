namespace TestSuperLib
{
    partial class TestSortingAlgorithms
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
            this.numericUpDownNoOfElements = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDatatype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBoxTypeAlgorithm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownRangeFrom = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownRangeTo = new System.Windows.Forms.NumericUpDown();
            this.chkBoxViewResult = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeTo)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNoOfElements
            // 
            this.numericUpDownNoOfElements.Location = new System.Drawing.Point(14, 106);
            this.numericUpDownNoOfElements.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownNoOfElements.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownNoOfElements.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNoOfElements.Name = "numericUpDownNoOfElements";
            this.numericUpDownNoOfElements.Size = new System.Drawing.Size(152, 26);
            this.numericUpDownNoOfElements.TabIndex = 0;
            this.numericUpDownNoOfElements.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of elements";
            // 
            // comboBoxDatatype
            // 
            this.comboBoxDatatype.FormattingEnabled = true;
            this.comboBoxDatatype.Items.AddRange(new object[] {
            "Int",
            "Object (zeg het maar...)"});
            this.comboBoxDatatype.Location = new System.Drawing.Point(14, 161);
            this.comboBoxDatatype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDatatype.Name = "comboBoxDatatype";
            this.comboBoxDatatype.Size = new System.Drawing.Size(151, 28);
            this.comboBoxDatatype.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datatype";
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(359, 15);
            this.textBoxResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResults.Size = new System.Drawing.Size(455, 422);
            this.textBoxResults.TabIndex = 4;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(14, 199);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(152, 29);
            this.buttonSort.TabIndex = 5;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // comboBoxTypeAlgorithm
            // 
            this.comboBoxTypeAlgorithm.FormattingEnabled = true;
            this.comboBoxTypeAlgorithm.Items.AddRange(new object[] {
            "(all)",
            "Bubble Sort",
            "Insertion Sort",
            "Selection Sort",
            "Smart Bubble Sort"});
            this.comboBoxTypeAlgorithm.Location = new System.Drawing.Point(14, 48);
            this.comboBoxTypeAlgorithm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTypeAlgorithm.Name = "comboBoxTypeAlgorithm";
            this.comboBoxTypeAlgorithm.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTypeAlgorithm.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sorting algorithm(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "From";
            // 
            // numericUpDownRangeFrom
            // 
            this.numericUpDownRangeFrom.Location = new System.Drawing.Point(237, 112);
            this.numericUpDownRangeFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRangeFrom.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRangeFrom.Name = "numericUpDownRangeFrom";
            this.numericUpDownRangeFrom.Size = new System.Drawing.Size(91, 26);
            this.numericUpDownRangeFrom.TabIndex = 10;
            this.numericUpDownRangeFrom.ValueChanged += new System.EventHandler(this.numericUpDownRangeFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "To";
            // 
            // numericUpDownRangeTo
            // 
            this.numericUpDownRangeTo.Location = new System.Drawing.Point(237, 164);
            this.numericUpDownRangeTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRangeTo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRangeTo.Name = "numericUpDownRangeTo";
            this.numericUpDownRangeTo.Size = new System.Drawing.Size(91, 26);
            this.numericUpDownRangeTo.TabIndex = 12;
            this.numericUpDownRangeTo.ValueChanged += new System.EventHandler(this.numericUpDownRangeTo_ValueChanged);
            // 
            // chkBoxViewResult
            // 
            this.chkBoxViewResult.AutoSize = true;
            this.chkBoxViewResult.Location = new System.Drawing.Point(190, 48);
            this.chkBoxViewResult.Name = "chkBoxViewResult";
            this.chkBoxViewResult.Size = new System.Drawing.Size(151, 24);
            this.chkBoxViewResult.TabIndex = 13;
            this.chkBoxViewResult.Text = "View sort results";
            this.chkBoxViewResult.UseVisualStyleBackColor = true;
            // 
            // TestSortingAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 452);
            this.Controls.Add(this.chkBoxViewResult);
            this.Controls.Add(this.numericUpDownRangeTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownRangeFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTypeAlgorithm);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDatatype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownNoOfElements);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TestSortingAlgorithms";
            this.Text = "Test Sorting Algorithms";
            this.Resize += new System.EventHandler(this.testSortingAlgorithms_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownNoOfElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDatatype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBoxTypeAlgorithm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownRangeFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownRangeTo;
        private System.Windows.Forms.CheckBox chkBoxViewResult;
    }
}