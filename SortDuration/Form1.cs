using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortDuration
{
    public partial class Form1 : Form
    {
        private int size = 1;
        private int alreadyAdded = 0;

        private SortableArray _array;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                size = Convert.ToInt32(textBox1.Text);
                if (size <= 0)
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong size!");
                return;
            }

            Enabled = false;

            dataGridView1.Rows.Clear();
            progressBar1.Maximum = size;

            for (int i = 0; i < size; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = $"{i + 1}";
                progressBar1.Value++;
            }

            labelSize.Text = $"Size: {size}";

            progressBar1.Value = 0;

            Enabled = true;
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            _array = new SortableArray(size);
            _array.FillRandomly();
            labelMedium.Text = $"Medium: {Sorts.Find(_array.arr, _array.arr.Length / 2)}";
            FillData();
        }

        private void FillData()
        {
            if(_array == null)
                return;

            for (int i = 0; i < size; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = _array.arr[i].ToString();
            }
        }

        private void buttonSort1_Click(object sender, EventArgs e)
        {
            if (_array == null)
                return;
            labelSort1.Text = _array.SortWithDuration(Sorts.QuickSort).ToString() + " ms";
            FillData();
        }

        private void buttonSort2_Click(object sender, EventArgs e)
        {
            if (_array == null)
                return;
            labelSort2.Text = _array.SortWithDuration(Sorts.PyramidSort).ToString() + " ms";
            FillData();
        }

        private void buttonSort3_Click(object sender, EventArgs e)
        {
            if (_array == null)
                return;
            labelSort3.Text = _array.SortWithDuration(Sorts.MergeSort).ToString() + " ms";
            FillData();
        }
    }
}
