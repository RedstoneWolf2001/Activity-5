namespace Activity_5
{
    partial class Form1
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
            this.FileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.firstTB = new System.Windows.Forms.TextBox();
            this.lastTB = new System.Windows.Forms.TextBox();
            this.longestTB = new System.Windows.Forms.TextBox();
            this.mostTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileDialogue
            // 
            this.FileDialogue.FileName = "FileDialogue";
            // 
            // firstTB
            // 
            this.firstTB.Location = new System.Drawing.Point(141, 13);
            this.firstTB.Name = "firstTB";
            this.firstTB.Size = new System.Drawing.Size(226, 20);
            this.firstTB.TabIndex = 0;
            // 
            // lastTB
            // 
            this.lastTB.Location = new System.Drawing.Point(141, 40);
            this.lastTB.Name = "lastTB";
            this.lastTB.Size = new System.Drawing.Size(226, 20);
            this.lastTB.TabIndex = 1;
            // 
            // longestTB
            // 
            this.longestTB.Location = new System.Drawing.Point(141, 67);
            this.longestTB.Name = "longestTB";
            this.longestTB.Size = new System.Drawing.Size(226, 20);
            this.longestTB.TabIndex = 2;
            // 
            // mostTB
            // 
            this.mostTB.Location = new System.Drawing.Point(141, 94);
            this.mostTB.Name = "mostTB";
            this.mostTB.Size = new System.Drawing.Size(226, 20);
            this.mostTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Word Alphabetically";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Word Alphabetically";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Longest Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Word with Most Vowels";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 130);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostTB);
            this.Controls.Add(this.longestTB);
            this.Controls.Add(this.lastTB);
            this.Controls.Add(this.firstTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog FileDialogue;
        private System.Windows.Forms.TextBox firstTB;
        private System.Windows.Forms.TextBox lastTB;
        private System.Windows.Forms.TextBox longestTB;
        private System.Windows.Forms.TextBox mostTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

