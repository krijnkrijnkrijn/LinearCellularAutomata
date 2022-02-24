namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numericUpDownCells = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonB = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownGenerations = new System.Windows.Forms.NumericUpDown();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CELL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEFT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RIGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.toolTip1.SetToolTip(this.buttonB, resources.GetString("buttonB.ToolTip"));
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label2.Location = new System.Drawing.Point(12, 9);
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
            this.numericUpDownGenerations.Location = new System.Drawing.Point(12, 27);
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
            this.toolTip1.SetToolTip(this.buttonA, resources.GetString("buttonA.ToolTip"));
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(12, 196);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(193, 23);
            this.buttonC.TabIndex = 19;
            this.buttonC.Text = "Execute";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CELL,
            this.LEFT,
            this.RIGHT,
            this.EVAL});
            this.dataGridView1.Location = new System.Drawing.Point(13, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 223);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CELL
            // 
            this.CELL.HeaderText = "CELL";
            this.CELL.Name = "CELL";
            this.CELL.ReadOnly = true;
            // 
            // LEFT
            // 
            this.LEFT.HeaderText = "LEFT";
            this.LEFT.Name = "LEFT";
            this.LEFT.ReadOnly = true;
            // 
            // RIGHT
            // 
            this.RIGHT.HeaderText = "RIGHT";
            this.RIGHT.Name = "RIGHT";
            this.RIGHT.ReadOnly = true;
            // 
            // EVAL
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EVAL.DefaultCellStyle = dataGridViewCellStyle4;
            this.EVAL.HeaderText = "EVAL";
            this.EVAL.Name = "EVAL";
            this.EVAL.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.numericUpDownCells);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxSeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownGenerations);
            this.Controls.Add(this.buttonA);
            this.Name = "Form1";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEFT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RIGHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EVAL;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}