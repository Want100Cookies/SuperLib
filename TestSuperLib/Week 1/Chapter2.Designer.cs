namespace TestSuperLib.Week_1
{
    partial class Chapter2
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
            this.btnTestGradesArray = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTestGradesArray
            // 
            this.btnTestGradesArray.Location = new System.Drawing.Point(12, 40);
            this.btnTestGradesArray.Name = "btnTestGradesArray";
            this.btnTestGradesArray.Size = new System.Drawing.Size(376, 40);
            this.btnTestGradesArray.TabIndex = 13;
            this.btnTestGradesArray.Text = "Check GradesArray class works";
            this.btnTestGradesArray.UseVisualStyleBackColor = true;
            this.btnTestGradesArray.Click += new System.EventHandler(this.btnTestGradesArray_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Exercise 1 and 2";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(12, 121);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(376, 40);
            this.btnCompare.TabIndex = 15;
            this.btnCompare.Text = "Compare Array to ArrayList implemantation";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Exercise 3";
            // 
            // Chapter2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 456);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestGradesArray);
            this.Controls.Add(this.label2);
            this.Name = "Chapter2";
            this.Text = "Chapter2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chapter2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestGradesArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label1;
    }
}