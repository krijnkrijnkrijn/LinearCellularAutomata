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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        int generations = 0;
        int[] gencurrent = null;

        /// <summary>
        /// An automaton of type A has the following fixed rule set
        /// If a cell is currently occupied, it remains occupied only if exactly one neighbor is occupied.
        /// If a cell is currently empty, it remains empty only if both neighbors are empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonA_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = "An automaton of type A has the following fixed rule set\r\n" +
            " If a cell is currently occupied, it remains occupied only if exactly one neighbor is occupied.\r\n" +
            " If a cell is currently empty, it remains empty only if both neighbors are empty.\r\n\r\n" +
            "Generations : " + generations + "Seed : " + textBoxSeed.Text + "\r\n\r\n";

            generations = (int)numericUpDownGenerations.Value;
            int cells = (int)numericUpDownCells.Value;
            string[] seed = textBoxSeed.Text.Split(',');
            
            gencurrent = new int[cells + 2]; //get rid of boundary conditions

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
                gencurrent = GenA(gencurrent);
            }
        }


        /// <summary>
        /// Check if condition 1 applies
        /// Check if condition 2 applies
        /// if both apply, or both do not apply, switch sign
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        private int[] GenA(int[] gencurrent)
        {
            int[] gennext = new int[gencurrent.Length];
            gennext[0] = 0;
            gennext[gencurrent.Length - 1] = 0;
            for (int i = 1; i < gencurrent.Length - 1; i++)
            {
                bool condition1 = false;
                bool condition2 = false;
                //If a cell is currently occupied, it remains occupied only if exactly one neighbor is occupied.
                if (gencurrent[i] == 1 && (gencurrent[i - 1] + gencurrent[i + 1]) == 1)
                {
                    condition1 = true;
                }
                //If a cell is currently empty, it remains empty only if both neighbors are empty.
                if (gencurrent[i] == 0 && (gencurrent[i - 1] + gencurrent[i + 1]) == 0)
                {
                    condition2 = true;
                }
                //flip? only if both conditions are true
                if (condition1 == condition2)
                {
                    if (gencurrent[i] == 1)
                    {
                        gennext[i] = 0;
                    }
                    else { gennext[i] = 1; }
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
                    printline = printline + " " + point.ToString();
                }
                else { printline = printline + "   "; }
            }
            textBoxOut.Text = textBoxOut.Text + printline + "\r\n";
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
            /// An automaton of type B has the following fixed rule set
            /// If a cell is currently occupied, it remains occupied only if the right neighbor is empty.
            /// If a cell is currently empty, it becomes occupied if exactly one neighbor is occupied.
            textBoxOut.Text = "An automaton of type B has the following fixed rule set\r\n" +
                " If a cell is currently occupied, it remains occupied only if the right neighbor is empty.\r\n" +
                " If a cell is currently empty, it becomes occupied if exactly one neighbor is occupied.\r\n\r\n" +
                "Generations : " + generations + "Seed : " + textBoxSeed.Text + "\r\n\r\n";

            generations = (int)numericUpDownGenerations.Value;
            int cells = (int)numericUpDownCells.Value;
            string[] seed = textBoxSeed.Text.Split(',');

            gencurrent = new int[cells + 2]; //get rid of boundary conditions

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
                gencurrent = GenB(gencurrent);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        private int[] GenB(int[] gencurrent)
        {
            int[] gennext = new int[gencurrent.Length];
            gennext[0] = 0;
            gennext[gencurrent.Length - 1] = 0;
            for (int i = 1; i < gencurrent.Length - 1; i++)
            {
                bool condition1 = false;
                bool condition2 = false;
                //If a cell is currently occupied, it remains occupied only if the right neighbor is empty.
                if (gencurrent[i] == 1 && gencurrent[i + 1] == 0)
                {
                    condition1 = true;
                }
                // If a cell is currently empty, it becomes occupied if exactly one neighbor is occupied.
                if (gencurrent[i] == 0 && (gencurrent[i - 1] + gencurrent[i + 1]) == 1)
                {
                    condition2 = true;
                }

                if (condition1 == true || condition2 == true)
                {
                    gennext[i] = 1;
                }
            }

            return gennext;
        }

 
    }
}