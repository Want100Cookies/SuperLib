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
            this.btnChapter1 = new System.Windows.Forms.Button();
            this.btnChapter2 = new System.Windows.Forms.Button();
            this.btnChapter3 = new System.Windows.Forms.Button();
            this.btnChapter4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChapter1
            // 
            this.btnChapter1.Location = new System.Drawing.Point(118, 12);
            this.btnChapter1.Name = "btnChapter1";
            this.btnChapter1.Size = new System.Drawing.Size(163, 39);
            this.btnChapter1.TabIndex = 0;
            this.btnChapter1.Text = "Chapter 1";
            this.btnChapter1.UseVisualStyleBackColor = true;
            this.btnChapter1.Click += new System.EventHandler(this.btnChapter1_Click);
            // 
            // btnChapter2
            // 
            this.btnChapter2.Location = new System.Drawing.Point(287, 12);
            this.btnChapter2.Name = "btnChapter2";
            this.btnChapter2.Size = new System.Drawing.Size(163, 39);
            this.btnChapter2.TabIndex = 1;
            this.btnChapter2.Text = "Chapter 2";
            this.btnChapter2.UseVisualStyleBackColor = true;
            this.btnChapter2.Click += new System.EventHandler(this.btnChapter2_Click);
            // 
            // btnChapter3
            // 
            this.btnChapter3.Location = new System.Drawing.Point(456, 12);
            this.btnChapter3.Name = "btnChapter3";
            this.btnChapter3.Size = new System.Drawing.Size(163, 39);
            this.btnChapter3.TabIndex = 2;
            this.btnChapter3.Text = "Chapter 3";
            this.btnChapter3.UseVisualStyleBackColor = true;
            this.btnChapter3.Click += new System.EventHandler(this.btnChapter3_Click);
            // 
            // btnChapter4
            // 
            this.btnChapter4.Location = new System.Drawing.Point(625, 12);
            this.btnChapter4.Name = "btnChapter4";
            this.btnChapter4.Size = new System.Drawing.Size(163, 39);
            this.btnChapter4.TabIndex = 3;
            this.btnChapter4.Text = "Chapter 4";
            this.btnChapter4.UseVisualStyleBackColor = true;
            this.btnChapter4.Click += new System.EventHandler(this.btnChapter4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Week 1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChapter4);
            this.Controls.Add(this.btnChapter3);
            this.Controls.Add(this.btnChapter2);
            this.Controls.Add(this.btnChapter1);
            this.Name = "Main";
            this.Text = "Test for SuperLib";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChapter1;
        private System.Windows.Forms.Button btnChapter2;
        private System.Windows.Forms.Button btnChapter3;
        private System.Windows.Forms.Button btnChapter4;
        private System.Windows.Forms.Label label1;
    }
}

