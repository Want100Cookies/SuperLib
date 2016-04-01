namespace TestSuperLib
{
    partial class testBinarySearchTree
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
            this.btnStart = new System.Windows.Forms.Button();
            this.numericUpDownRandomStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRandomStop = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownNoItems = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.numericUpDownDelete = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 108);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(231, 47);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numericUpDownRandomStart
            // 
            this.numericUpDownRandomStart.Location = new System.Drawing.Point(123, 12);
            this.numericUpDownRandomStart.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownRandomStart.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownRandomStart.Name = "numericUpDownRandomStart";
            this.numericUpDownRandomStart.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownRandomStart.TabIndex = 1;
            // 
            // numericUpDownRandomStop
            // 
            this.numericUpDownRandomStop.Location = new System.Drawing.Point(123, 44);
            this.numericUpDownRandomStop.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownRandomStop.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownRandomStop.Name = "numericUpDownRandomStop";
            this.numericUpDownRandomStop.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownRandomStop.TabIndex = 2;
            this.numericUpDownRandomStop.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Random start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Random stop";
            // 
            // numericUpDownNoItems
            // 
            this.numericUpDownNoItems.Location = new System.Drawing.Point(123, 76);
            this.numericUpDownNoItems.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownNoItems.Name = "numericUpDownNoItems";
            this.numericUpDownNoItems.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownNoItems.TabIndex = 5;
            this.numericUpDownNoItems.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "No items";
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.Location = new System.Drawing.Point(249, 8);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(881, 619);
            this.Output.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "To delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(231, 47);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // numericUpDownDelete
            // 
            this.numericUpDownDelete.Location = new System.Drawing.Point(123, 220);
            this.numericUpDownDelete.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDelete.Name = "numericUpDownDelete";
            this.numericUpDownDelete.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownDelete.TabIndex = 8;
            this.numericUpDownDelete.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // testBinarySearchTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 639);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownDelete);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownNoItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownRandomStop);
            this.Controls.Add(this.numericUpDownRandomStart);
            this.Controls.Add(this.btnStart);
            this.Name = "testBinarySearchTree";
            this.Text = "testBinarySearchTree";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numericUpDownRandomStart;
        private System.Windows.Forms.NumericUpDown numericUpDownRandomStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownNoItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown numericUpDownDelete;
    }
}