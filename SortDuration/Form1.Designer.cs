using System.Windows.Forms;

namespace SortDuration
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSize = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.labelMedium = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSort1 = new System.Windows.Forms.Button();
            this.buttonSort2 = new System.Windows.Forms.Button();
            this.buttonSort3 = new System.Windows.Forms.Button();
            this.labelSort1 = new System.Windows.Forms.Label();
            this.labelSort2 = new System.Windows.Forms.Label();
            this.labelSort3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonLastData = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(723, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelSize);
            this.flowLayoutPanel2.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(231, 418);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // labelSize
            // 
            this.labelSize.Location = new System.Drawing.Point(3, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(228, 23);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Size: 1";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.Size = new System.Drawing.Size(228, 380);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Element";
            this.Column1.Name = "Column1";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.textBox1);
            this.flowLayoutPanel3.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel3.Controls.Add(this.buttonFill);
            this.flowLayoutPanel3.Controls.Add(this.buttonLastData);
            this.flowLayoutPanel3.Controls.Add(this.labelMedium);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(240, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(204, 418);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "100000";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 29);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(197, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Create";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(3, 58);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(197, 23);
            this.buttonFill.TabIndex = 1;
            this.buttonFill.Text = "Fill";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // labelMedium
            // 
            this.labelMedium.Location = new System.Drawing.Point(3, 113);
            this.labelMedium.Name = "labelMedium";
            this.labelMedium.Size = new System.Drawing.Size(197, 23);
            this.labelMedium.TabIndex = 4;
            this.labelMedium.Text = "Medium: unknown";
            this.labelMedium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(450, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(270, 418);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSort1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSort2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSort3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSort1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSort2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSort3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonSort1
            // 
            this.buttonSort1.Location = new System.Drawing.Point(3, 3);
            this.buttonSort1.Name = "buttonSort1";
            this.buttonSort1.Size = new System.Drawing.Size(140, 21);
            this.buttonSort1.TabIndex = 0;
            this.buttonSort1.Text = "Quick sort";
            this.buttonSort1.UseVisualStyleBackColor = true;
            this.buttonSort1.Click += new System.EventHandler(this.buttonSort1_Click);
            // 
            // buttonSort2
            // 
            this.buttonSort2.Location = new System.Drawing.Point(3, 30);
            this.buttonSort2.Name = "buttonSort2";
            this.buttonSort2.Size = new System.Drawing.Size(140, 22);
            this.buttonSort2.TabIndex = 1;
            this.buttonSort2.Text = "Pyramid sort";
            this.buttonSort2.UseVisualStyleBackColor = true;
            this.buttonSort2.Click += new System.EventHandler(this.buttonSort2_Click);
            // 
            // buttonSort3
            // 
            this.buttonSort3.Location = new System.Drawing.Point(3, 58);
            this.buttonSort3.Name = "buttonSort3";
            this.buttonSort3.Size = new System.Drawing.Size(140, 23);
            this.buttonSort3.TabIndex = 2;
            this.buttonSort3.Text = "Merge sort";
            this.buttonSort3.UseVisualStyleBackColor = true;
            this.buttonSort3.Click += new System.EventHandler(this.buttonSort3_Click);
            // 
            // labelSort1
            // 
            this.labelSort1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSort1.Location = new System.Drawing.Point(149, 0);
            this.labelSort1.Name = "labelSort1";
            this.labelSort1.Size = new System.Drawing.Size(141, 27);
            this.labelSort1.TabIndex = 3;
            this.labelSort1.Text = "0 ms";
            this.labelSort1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSort2
            // 
            this.labelSort2.Location = new System.Drawing.Point(149, 27);
            this.labelSort2.Name = "labelSort2";
            this.labelSort2.Size = new System.Drawing.Size(141, 23);
            this.labelSort2.TabIndex = 4;
            this.labelSort2.Text = "0 ms";
            this.labelSort2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSort3
            // 
            this.labelSort3.Location = new System.Drawing.Point(149, 55);
            this.labelSort3.Name = "labelSort3";
            this.labelSort3.Size = new System.Drawing.Size(141, 23);
            this.labelSort3.TabIndex = 5;
            this.labelSort3.Text = "0 ms";
            this.labelSort3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 427);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(723, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // buttonLastData
            // 
            this.buttonLastData.Location = new System.Drawing.Point(3, 87);
            this.buttonLastData.Name = "buttonLastData";
            this.buttonLastData.Size = new System.Drawing.Size(197, 23);
            this.buttonLastData.TabIndex = 6;
            this.buttonLastData.Text = "Last data";
            this.buttonLastData.UseVisualStyleBackColor = true;
            this.buttonLastData.Click += new System.EventHandler(this.buttonLastData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Comparison of sorts";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Label labelMedium;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSort1;
        private System.Windows.Forms.Button buttonSort2;
        private System.Windows.Forms.Button buttonSort3;
        private System.Windows.Forms.Label labelSort1;
        private System.Windows.Forms.Label labelSort2;
        private System.Windows.Forms.Label labelSort3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private Button buttonLastData;
    }
}

