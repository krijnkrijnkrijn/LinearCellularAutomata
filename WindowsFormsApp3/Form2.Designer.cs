namespace WindowsFormsApp3
{
    partial class Form2
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
            this.numericUpDownCells = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonB = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownGenerations = new System.Windows.Forms.NumericUpDown();
            this.buttonA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerations)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCells
            // 
            this.numericUpDownCells.Location = new System.Drawing.Point(12, 67);
            this.numericUpDownCells.Name = "numericUpDownCells";
            this.numericUpDownCells.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCells.TabIndex = 18;
            this.numericUpDownCells.Value = new decimal(new int[] {
            61,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cells";
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(12, 167);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(193, 23);
            this.buttonB.TabIndex = 16;
            this.buttonB.Text = "Case B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut.Location = new System.Drawing.Point(277, 14);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(843, 559);
            this.textBoxOut.TabIndex = 15;
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Location = new System.Drawing.Point(12, 113);
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(229, 20);
            this.textBoxSeed.TabIndex = 14;
            this.textBoxSeed.Text = "20,40";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Generations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seed (comma separated)";
            // 
            // numericUpDownGenerations
            // 
            this.numericUpDownGenerations.Location = new System.Drawing.Point(12, 14);
            this.numericUpDownGenerations.Name = "numericUpDownGenerations";
            this.numericUpDownGenerations.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGenerations.TabIndex = 11;
            this.numericUpDownGenerations.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(12, 138);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(193, 23);
            this.buttonA.TabIndex = 10;
            this.buttonA.Text = "Case A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 582);
            this.Controls.Add(this.numericUpDownCells);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxSeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownGenerations);
            this.Controls.Add(this.buttonA);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCells;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.TextBox textBoxSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownGenerations;
        private System.Windows.Forms.Button buttonA;
    }
}