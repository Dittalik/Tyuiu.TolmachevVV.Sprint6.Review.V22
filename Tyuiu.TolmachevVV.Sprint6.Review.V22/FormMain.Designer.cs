
namespace Tyuiu.TolmachevVV.Sprint6.Review.V22
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.groupBoxMatrixInput = new System.Windows.Forms.GroupBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.textBoxMatrixRows = new System.Windows.Forms.TextBox();
            this.groupBoxRange = new System.Windows.Forms.GroupBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxRangeInptTo = new System.Windows.Forms.TextBox();
            this.textBoxRangeInpFrom = new System.Windows.Forms.TextBox();
            this.buttonGetMatrix = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.groupBoxVRange = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRangeTo = new System.Windows.Forms.TextBox();
            this.textBoxRangeFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVarR = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.groupBoxMatrixInput.SuspendLayout();
            this.groupBoxRange.SuspendLayout();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxVRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.AllowUserToResizeColumns = false;
            this.dataGridViewMatrix.AllowUserToResizeRows = false;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.ColumnHeadersVisible = false;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.ReadOnly = true;
            this.dataGridViewMatrix.RowHeadersVisible = false;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(260, 260);
            this.dataGridViewMatrix.TabIndex = 0;
            // 
            // groupBoxMatrixInput
            // 
            this.groupBoxMatrixInput.Controls.Add(this.labelRows);
            this.groupBoxMatrixInput.Controls.Add(this.labelColumns);
            this.groupBoxMatrixInput.Controls.Add(this.textBoxColumns);
            this.groupBoxMatrixInput.Controls.Add(this.textBoxMatrixRows);
            this.groupBoxMatrixInput.Location = new System.Drawing.Point(278, 12);
            this.groupBoxMatrixInput.Name = "groupBoxMatrixInput";
            this.groupBoxMatrixInput.Size = new System.Drawing.Size(124, 102);
            this.groupBoxMatrixInput.TabIndex = 1;
            this.groupBoxMatrixInput.TabStop = false;
            this.groupBoxMatrixInput.Text = "Размер матрицы";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(7, 16);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(46, 13);
            this.labelRows.TabIndex = 2;
            this.labelRows.Text = "Строки:";
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(7, 55);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(54, 13);
            this.labelColumns.TabIndex = 2;
            this.labelColumns.Text = "Столбцы:";
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Location = new System.Drawing.Point(7, 74);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(100, 20);
            this.textBoxColumns.TabIndex = 1;
            this.textBoxColumns.Text = "5";
            this.textBoxColumns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxColumns_KeyPress);
            // 
            // textBoxMatrixRows
            // 
            this.textBoxMatrixRows.Location = new System.Drawing.Point(7, 32);
            this.textBoxMatrixRows.Name = "textBoxMatrixRows";
            this.textBoxMatrixRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatrixRows.TabIndex = 0;
            this.textBoxMatrixRows.Text = "5";
            this.textBoxMatrixRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMatrixRows_KeyPress);
            // 
            // groupBoxRange
            // 
            this.groupBoxRange.Controls.Add(this.labelFrom);
            this.groupBoxRange.Controls.Add(this.labelTo);
            this.groupBoxRange.Controls.Add(this.textBoxRangeInptTo);
            this.groupBoxRange.Controls.Add(this.textBoxRangeInpFrom);
            this.groupBoxRange.Location = new System.Drawing.Point(278, 120);
            this.groupBoxRange.Name = "groupBoxRange";
            this.groupBoxRange.Size = new System.Drawing.Size(124, 102);
            this.groupBoxRange.TabIndex = 1;
            this.groupBoxRange.TabStop = false;
            this.groupBoxRange.Text = "Диапазон";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(7, 16);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(23, 13);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "От:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(7, 55);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 13);
            this.labelTo.TabIndex = 2;
            this.labelTo.Text = "До:";
            // 
            // textBoxRangeInptTo
            // 
            this.textBoxRangeInptTo.Location = new System.Drawing.Point(7, 74);
            this.textBoxRangeInptTo.Name = "textBoxRangeInptTo";
            this.textBoxRangeInptTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxRangeInptTo.TabIndex = 1;
            this.textBoxRangeInptTo.Text = "5";
            this.textBoxRangeInptTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRangeInptTo_KeyPress);
            // 
            // textBoxRangeInpFrom
            // 
            this.textBoxRangeInpFrom.Location = new System.Drawing.Point(7, 32);
            this.textBoxRangeInpFrom.Name = "textBoxRangeInpFrom";
            this.textBoxRangeInpFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxRangeInpFrom.TabIndex = 0;
            this.textBoxRangeInpFrom.Text = "-5";
            this.textBoxRangeInpFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRangeInpFrom_KeyPress);
            // 
            // buttonGetMatrix
            // 
            this.buttonGetMatrix.Location = new System.Drawing.Point(278, 228);
            this.buttonGetMatrix.Name = "buttonGetMatrix";
            this.buttonGetMatrix.Size = new System.Drawing.Size(124, 44);
            this.buttonGetMatrix.TabIndex = 2;
            this.buttonGetMatrix.Text = "Создать матрицу";
            this.buttonGetMatrix.UseVisualStyleBackColor = true;
            this.buttonGetMatrix.Click += new System.EventHandler(this.buttonGetMatrix_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(408, 228);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(124, 44);
            this.buttonExecute.TabIndex = 2;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.groupBoxVRange);
            this.groupBoxCondition.Controls.Add(this.label1);
            this.groupBoxCondition.Controls.Add(this.textBoxVarR);
            this.groupBoxCondition.Location = new System.Drawing.Point(408, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(124, 160);
            this.groupBoxCondition.TabIndex = 3;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // groupBoxVRange
            // 
            this.groupBoxVRange.Controls.Add(this.label3);
            this.groupBoxVRange.Controls.Add(this.label2);
            this.groupBoxVRange.Controls.Add(this.textBoxRangeTo);
            this.groupBoxVRange.Controls.Add(this.textBoxRangeFrom);
            this.groupBoxVRange.Location = new System.Drawing.Point(7, 58);
            this.groupBoxVRange.Name = "groupBoxVRange";
            this.groupBoxVRange.Size = new System.Drawing.Size(111, 102);
            this.groupBoxVRange.TabIndex = 2;
            this.groupBoxVRange.TabStop = false;
            this.groupBoxVRange.Text = "Выч. Диапазон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "До:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "От:";
            // 
            // textBoxRangeTo
            // 
            this.textBoxRangeTo.Location = new System.Drawing.Point(6, 76);
            this.textBoxRangeTo.Name = "textBoxRangeTo";
            this.textBoxRangeTo.Size = new System.Drawing.Size(72, 20);
            this.textBoxRangeTo.TabIndex = 0;
            this.textBoxRangeTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRangeTo_KeyPress);
            // 
            // textBoxRangeFrom
            // 
            this.textBoxRangeFrom.Location = new System.Drawing.Point(6, 32);
            this.textBoxRangeFrom.Name = "textBoxRangeFrom";
            this.textBoxRangeFrom.Size = new System.Drawing.Size(72, 20);
            this.textBoxRangeFrom.TabIndex = 0;
            this.textBoxRangeFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRangeFrom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Строка";
            // 
            // textBoxVarR
            // 
            this.textBoxVarR.Location = new System.Drawing.Point(7, 31);
            this.textBoxVarR.Name = "textBoxVarR";
            this.textBoxVarR.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarR.TabIndex = 0;
            this.textBoxVarR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarR_KeyPress);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Location = new System.Drawing.Point(415, 194);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 280);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.groupBoxCondition);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonGetMatrix);
            this.Controls.Add(this.groupBoxRange);
            this.Controls.Add(this.groupBoxMatrixInput);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Name = "FormMain";
            this.Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.groupBoxMatrixInput.ResumeLayout(false);
            this.groupBoxMatrixInput.PerformLayout();
            this.groupBoxRange.ResumeLayout(false);
            this.groupBoxRange.PerformLayout();
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxVRange.ResumeLayout(false);
            this.groupBoxVRange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.GroupBox groupBoxMatrixInput;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.TextBox textBoxMatrixRows;
        private System.Windows.Forms.GroupBox groupBoxRange;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxRangeInptTo;
        private System.Windows.Forms.TextBox textBoxRangeInpFrom;
        private System.Windows.Forms.Button buttonGetMatrix;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVarR;
        private System.Windows.Forms.GroupBox groupBoxVRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRangeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRangeTo;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

