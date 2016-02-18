namespace TestSuperLib.Week_1
{
    partial class Chapter3
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompare2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompare3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(12, 43);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(585, 40);
            this.btnCompare.TabIndex = 13;
            this.btnCompare.Text = "Compare chapter 3 sorts (random with 100 ints between 0-100)";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Exercise 1";
            // 
            // btnCompare2
            // 
            this.btnCompare2.Location = new System.Drawing.Point(12, 117);
            this.btnCompare2.Name = "btnCompare2";
            this.btnCompare2.Size = new System.Drawing.Size(585, 40);
            this.btnCompare2.TabIndex = 15;
            this.btnCompare2.Text = "Compare chapter 3 sorts (1000 ascending ints vs random)";
            this.btnCompare2.UseVisualStyleBackColor = true;
            this.btnCompare2.Click += new System.EventHandler(this.btnCompare2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Exercise 2";
            // 
            // btnCompare3
            // 
            this.btnCompare3.Location = new System.Drawing.Point(12, 194);
            this.btnCompare3.Name = "btnCompare3";
            this.btnCompare3.Size = new System.Drawing.Size(585, 40);
            this.btnCompare3.TabIndex = 17;
            this.btnCompare3.Text = "Compare chapter 3 sorts (1000 descending ints)";
            this.btnCompare3.UseVisualStyleBackColor = true;
            this.btnCompare3.Click += new System.EventHandler(this.btnCompare3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Exercise 3";
            // 
            // Chapter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 415);
            this.Controls.Add(this.btnCompare3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCompare2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label2);
            this.Name = "Chapter3";
            this.Text = "Chapter_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompare2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompare3;
        private System.Windows.Forms.Label label3;
    }
}