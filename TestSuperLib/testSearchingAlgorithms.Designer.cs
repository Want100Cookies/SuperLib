namespace TestSuperLib
{
    partial class TestSearchingAlgorithms
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownValueToSearch = new System.Windows.Forms.NumericUpDown();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.numericUpDownRangeTo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownRangeFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValueToSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNoOfElements
            // 
            this.numericUpDownNoOfElements.Location = new System.Drawing.Point(172, 11);
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
            this.numericUpDownNoOfElements.Size = new System.Drawing.Size(135, 26);
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
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of elements";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(18, 284);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(84, 29);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value to search";
            // 
            // numericUpDownValueToSearch
            // 
            this.numericUpDownValueToSearch.Location = new System.Drawing.Point(173, 254);
            this.numericUpDownValueToSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownValueToSearch.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.numericUpDownValueToSearch.Minimum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            -2147483648});
            this.numericUpDownValueToSearch.Name = "numericUpDownValueToSearch";
            this.numericUpDownValueToSearch.Size = new System.Drawing.Size(135, 26);
            this.numericUpDownValueToSearch.TabIndex = 4;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(314, 11);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(419, 434);
            this.textBoxOutput.TabIndex = 5;
            // 
            // numericUpDownRangeTo
            // 
            this.numericUpDownRangeTo.Location = new System.Drawing.Point(172, 119);
            this.numericUpDownRangeTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRangeTo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRangeTo.Name = "numericUpDownRangeTo";
            this.numericUpDownRangeTo.Size = new System.Drawing.Size(135, 26);
            this.numericUpDownRangeTo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "To";
            // 
            // numericUpDownRangeFrom
            // 
            this.numericUpDownRangeFrom.Location = new System.Drawing.Point(172, 70);
            this.numericUpDownRangeFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRangeFrom.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRangeFrom.Name = "numericUpDownRangeFrom";
            this.numericUpDownRangeFrom.Size = new System.Drawing.Size(135, 26);
            this.numericUpDownRangeFrom.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Range";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(18, 157);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(98, 29);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // TestSearchingAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 461);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.numericUpDownRangeTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownRangeFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.numericUpDownValueToSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownNoOfElements);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TestSearchingAlgorithms";
            this.Text = "testSearchingAlgorithms";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValueToSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownNoOfElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownValueToSearch;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.NumericUpDown numericUpDownRangeTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownRangeFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerate;
    }
}