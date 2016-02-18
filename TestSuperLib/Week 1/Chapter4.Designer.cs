namespace TestSuperLib.Week_1
{
    partial class Chapter4
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
            this.btnUnorderedBinary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUnorderedBinary
            // 
            this.btnUnorderedBinary.Location = new System.Drawing.Point(12, 39);
            this.btnUnorderedBinary.Name = "btnUnorderedBinary";
            this.btnUnorderedBinary.Size = new System.Drawing.Size(585, 40);
            this.btnUnorderedBinary.TabIndex = 15;
            this.btnUnorderedBinary.Text = "Execute binary search on an unordered set of data";
            this.btnUnorderedBinary.UseVisualStyleBackColor = true;
            this.btnUnorderedBinary.Click += new System.EventHandler(this.btnUnorderedBinary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Exercise 3";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(13, 117);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(585, 40);
            this.btnCompare.TabIndex = 17;
            this.btnCompare.Text = "Compare no comparisons made";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Exercise 4";
            // 
            // Chapter4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 416);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnorderedBinary);
            this.Controls.Add(this.label2);
            this.Name = "Chapter4";
            this.Text = "Chapter4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnorderedBinary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label1;
    }
}