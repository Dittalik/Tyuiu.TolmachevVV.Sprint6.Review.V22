using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TolmachevVV.Sprint6.Review.V22.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Review.V22
{
    public partial class FormMain : Form
    {
        DataSerivce serivce = new DataSerivce();
        int[,] matrix;
        public FormMain()
        {
            InitializeComponent();
        }


        private void textBoxMatrixRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(int.TryParse(e.KeyChar.ToString(), out int number) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxColumns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(int.TryParse(e.KeyChar.ToString(), out int number) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxRangeInptTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(int.TryParse(e.KeyChar.ToString(), out int number)  || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxRangeInpFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(int.TryParse(e.KeyChar.ToString(), out int number) || e.KeyChar == '-' || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxVarR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(int.TryParse(e.KeyChar.ToString(), out int number) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxRangeFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(int.TryParse(e.KeyChar.ToString(), out int number) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxRangeTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(int.TryParse(e.KeyChar.ToString(), out int number) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void buttonGetMatrix_Click(object sender, EventArgs e)
        {
            int columns = Convert.ToInt32(textBoxColumns.Text);
            int rows = Convert.ToInt32(textBoxMatrixRows.Text);
            int n1 = Convert.ToInt32(textBoxRangeInpFrom.Text);
            int n2 = Convert.ToInt32(textBoxRangeInptTo.Text);
            dataGridViewMatrix.RowCount = rows;
            dataGridViewMatrix.ColumnCount = columns;
            for (int i = 0; i < dataGridViewMatrix.ColumnCount; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }
            matrix = serivce.GetMatrix(n1, n2, rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            int R = Convert.ToInt32(textBoxVarR.Text);
            int K = (textBoxRangeFrom.Text.Length != 0) ? Convert.ToInt32(textBoxRangeFrom.Text) : matrix.GetLength(0) + 2;
            int L = (textBoxRangeTo.Text.Length != 0) ? Convert.ToInt32(textBoxRangeFrom.Text) : matrix.GetLength(0) + 2;
            int n1 = Convert.ToInt32(textBoxRangeInpFrom.Text);
            int n2 = Convert.ToInt32(textBoxRangeInptTo.Text);
            textBoxResult.Text = serivce.CalculateMatrix(matrix, n1, n2, R, K, L).ToString();
        }
    }
}
