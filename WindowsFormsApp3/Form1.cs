using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int generations = 0;
      

        /// <summary>
        /// An automaton of type A has the following fixed rule set
        /// If a cell is currently occupied, it remains occupied only if exactly one neighbor is occupied.
        /// If a cell is currently empty, it remains empty only if both neighbors are empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonA_Click(object sender, EventArgs e)
        {
            ScenarioA();
        }
        /// <summary>
        /// An automaton of type B has the following fixed rule set
        /// If a cell is currently occupied, it remains occupied only if the right neighbor is empty.
        /// If a cell is currently empty, it becomes occupied if exactly one neighbor is occupied.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonB_Click(object sender, EventArgs e)
        {
            ScenarioB();
        }


        /// <summary>
        /// execute algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            generations = (int)numericUpDownGenerations.Value;
            int cells = (int)numericUpDownCells.Value;
            string[] seed = textBoxSeed.Text.Split(',');

            textBoxOut.Text = " Generations : " + generations + "  Seed : " + textBoxSeed.Text + "\r\n\r\n";

            int[] gencurrent = new int[cells + 2]; //get rid of boundary conditions

            gencurrent[0] = 0;
            gencurrent[cells + 1] = 0;
            for (int i = 1; i < cells; i++)
            {
                foreach (string seedval in seed)
                {
                    if (int.Parse(seedval) == i)
                    {
                        gencurrent[i] = 1;
                        break;
                    }
                    else { gencurrent[i] = 0; }
                }
            }

            for (int j = 0; j < generations; j++)
            {
                Print(gencurrent);
                gencurrent = Generator(gencurrent);
            }
        }

        private void ScenarioA()
        {
            numericUpDownGenerations.Value = 10;
            numericUpDownCells.Value = 11;
            textBoxSeed.Text = "6";

            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows.Add(1, 1, 0, 1);
            this.dataGridView1.Rows.Add(1, 0, 1, 1);
            this.dataGridView1.Rows.Add(1, 0, 0, 0);
            this.dataGridView1.Rows.Add(1, 1, 1, 0);

            this.dataGridView1.Rows.Add(0, 1, 0, 1);
            this.dataGridView1.Rows.Add(0, 0, 1, 1);
            this.dataGridView1.Rows.Add(0, 0, 0, 0);
            this.dataGridView1.Rows.Add(0, 1, 1, 1);
        }

        private void ScenarioB()
        {
            numericUpDownGenerations.Value = 20;
            numericUpDownCells.Value = 61;
            textBoxSeed.Text = "20,40";

            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows.Add(1, 1, 0, 1);
            this.dataGridView1.Rows.Add(1, 0, 1, 0);
            this.dataGridView1.Rows.Add(1, 0, 0, 1);
            this.dataGridView1.Rows.Add(1, 1, 1, 0);

            this.dataGridView1.Rows.Add(0, 1, 0, 1);
            this.dataGridView1.Rows.Add(0, 0, 1, 1);
            this.dataGridView1.Rows.Add(0, 0, 0, 0);
            this.dataGridView1.Rows.Add(0, 1, 1, 0);

        }


        /// <summary>
        /// Compare conditions to matrix
        /// </summary>
        /// <param name="seed">Current values</param>
        /// <returns>Results</returns>
        private int[] Generator(int[] gencurrent)
        {
            int[] gennext = new int[gencurrent.Length];

            for (int i = 1; i < gencurrent.Length - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((int)row.Cells[0].Value == gencurrent[i] &&
                        (int)row.Cells[1].Value == gencurrent[i - 1] &&
                        (int)row.Cells[2].Value == gencurrent[i + 1])
                    {
                        gennext[i] = (int)row.Cells[3].Value;
                    }
                }
            }

            return gennext;
        }


        private void Print(int[] line)
        {
            string printline = "";
            foreach (int point in line)
            {
                if (point == 1)
                {
                    printline = printline + "O";// + point.ToString();
                }
                else { printline = printline + " "; }
            }
            textBoxOut.Text = textBoxOut.Text + printline + "\r\n";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3 || e.RowIndex == -1) { return; }

            int curval = (int)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (curval == 1) { dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0; }
            else { dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1; }
        }
    }
}