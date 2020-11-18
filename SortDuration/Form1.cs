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
        private int _size = 1;

        private SortableArray _array;

        private SortableArray _lastData;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _size = Convert.ToInt32(textBox1.Text);
                if (_size <= 0)
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong size!");
                return;
            }

            Enabled = false;

            dataGridView1.Rows.Clear();
            progressBar1.Maximum = _size;

            for (int i = 0; i < _size; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = $"{i + 1}";
                progressBar1.Value++;
            }

            labelSize.Text = $"Size: {_size}";

            progressBar1.Value = 0;

            Enabled = true;
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            _array = new SortableArray(_size);
            _array.FillRandomly();
            labelMedium.Text = $"Medium: {Sorts.Find(_array.Arr, _array.Arr.Length / 2)}";
            FillData(_array);
            _lastData = new SortableArray(_array.Arr.Length);
            Array.Copy(_array.Arr, _lastData.Arr, _array.Arr.Length);
        }

        private void FillData(SortableArray arr)
        {
            if(arr == null)
                return;

            for (int i = 0; i < _size; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = arr.Arr[i].ToString();
            }
        }

        private void buttonSort1_Click(object sender, EventArgs e)
        {
            if (_array == null)
                return;
            labelSort1.Text = _array.SortWithDuration(Sorts.QuickSort).ToString() + " ms";
            FillData(_array);
        }

        private void buttonSort2_Click(object sender, EventArgs e)
        {
            if (_array == null)
                return;
            labelSort2.Text = _array.SortWithDuration(Sorts.PyramidSort).ToString() + " ms";
            FillData(_array);
        }

        private void buttonSort3_Click(object sender, EventArgs e)
        {
            if (_array == null)
                return;
            labelSort3.Text = _array.SortWithDuration(Sorts.MergeSort).ToString() + " ms";
            FillData(_array);
        }

        private void buttonLastData_Click(object sender, EventArgs e)
        {
            if(_array == null)
                return;
            FillData(_lastData);
            labelMedium.Text = $"Medium: {Sorts.Find(_lastData.Arr, _lastData.Arr.Length / 2)}";
        }
    }
}
