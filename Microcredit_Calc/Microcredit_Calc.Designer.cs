
namespace Microcredit_Calc
{
    partial class Microcredit_Calc
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
            this.label2 = new System.Windows.Forms.Label();
            this.sumCredit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.GroupBox();
            this.butSaveAsCSV = new System.Windows.Forms.Button();
            this.percentSum = new System.Windows.Forms.TextBox();
            this.effectivRate = new System.Windows.Forms.TextBox();
            this.allSum = new System.Windows.Forms.TextBox();
            this.creditTerm = new System.Windows.Forms.NumericUpDown();
            this.butPriceGo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGrafik = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.percRate = new System.Windows.Forms.NumericUpDown();
            this.Columns1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columns2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columns3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columns4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btClear = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btPrecent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sumCredit)).BeginInit();
            this.Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditTerm)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percRate)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Сумма займа";
            this.label2.UseMnemonic = false;
            // 
            // sumCredit
            // 
            this.sumCredit.Location = new System.Drawing.Point(173, 30);
            this.sumCredit.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.sumCredit.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sumCredit.Name = "sumCredit";
            this.sumCredit.Size = new System.Drawing.Size(120, 20);
            this.sumCredit.TabIndex = 1;
            this.sumCredit.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sumCredit.ValueChanged += new System.EventHandler(this.sumCredit_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок займа (Дней)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Общая сумма выплаты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сумма процентов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Эффективная ставка";
            // 
            // Result
            // 
            this.Result.Controls.Add(this.butSaveAsCSV);
            this.Result.Controls.Add(this.percentSum);
            this.Result.Controls.Add(this.effectivRate);
            this.Result.Controls.Add(this.allSum);
            this.Result.Controls.Add(this.label4);
            this.Result.Controls.Add(this.label5);
            this.Result.Controls.Add(this.label6);
            this.Result.Location = new System.Drawing.Point(493, 12);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(318, 183);
            this.Result.TabIndex = 6;
            this.Result.TabStop = false;
            this.Result.Text = "Результат";
            // 
            // butSaveAsCSV
            // 
            this.butSaveAsCSV.Location = new System.Drawing.Point(77, 145);
            this.butSaveAsCSV.Name = "butSaveAsCSV";
            this.butSaveAsCSV.Size = new System.Drawing.Size(145, 23);
            this.butSaveAsCSV.TabIndex = 9;
            this.butSaveAsCSV.Text = "экспорт рассчетов";
            this.butSaveAsCSV.UseVisualStyleBackColor = true;
            this.butSaveAsCSV.Click += new System.EventHandler(this.butSaveAsCSV_Click);
            // 
            // percentSum
            // 
            this.percentSum.BackColor = System.Drawing.SystemColors.Window;
            this.percentSum.Location = new System.Drawing.Point(147, 103);
            this.percentSum.Name = "percentSum";
            this.percentSum.ReadOnly = true;
            this.percentSum.Size = new System.Drawing.Size(120, 20);
            this.percentSum.TabIndex = 8;
            // 
            // effectivRate
            // 
            this.effectivRate.BackColor = System.Drawing.SystemColors.Window;
            this.effectivRate.Location = new System.Drawing.Point(147, 59);
            this.effectivRate.Name = "effectivRate";
            this.effectivRate.ReadOnly = true;
            this.effectivRate.Size = new System.Drawing.Size(120, 20);
            this.effectivRate.TabIndex = 7;
            // 
            // allSum
            // 
            this.allSum.BackColor = System.Drawing.SystemColors.Window;
            this.allSum.Location = new System.Drawing.Point(147, 13);
            this.allSum.Name = "allSum";
            this.allSum.ReadOnly = true;
            this.allSum.Size = new System.Drawing.Size(120, 20);
            this.allSum.TabIndex = 6;
            // 
            // creditTerm
            // 
            this.creditTerm.Location = new System.Drawing.Point(172, 69);
            this.creditTerm.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.creditTerm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.creditTerm.Name = "creditTerm";
            this.creditTerm.Size = new System.Drawing.Size(120, 20);
            this.creditTerm.TabIndex = 7;
            this.creditTerm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.creditTerm.ValueChanged += new System.EventHandler(this.creditTerm_ValueChanged);
            // 
            // butPriceGo
            // 
            this.butPriceGo.Location = new System.Drawing.Point(115, 158);
            this.butPriceGo.Name = "butPriceGo";
            this.butPriceGo.Size = new System.Drawing.Size(167, 22);
            this.butPriceGo.TabIndex = 8;
            this.butPriceGo.Text = "Рассчитать";
            this.butPriceGo.UseVisualStyleBackColor = true;
            this.butPriceGo.Click += new System.EventHandler(this.butPriceGo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGrafik);
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 319);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "График платежей";
            // 
            // dgvGrafik
            // 
            this.dgvGrafik.AllowUserToDeleteRows = false;
            this.dgvGrafik.AllowUserToResizeColumns = false;
            this.dgvGrafik.AllowUserToResizeRows = false;
            this.dgvGrafik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columns1,
            this.Columns2,
            this.Columns3,
            this.Columns4});
            this.dgvGrafik.Location = new System.Drawing.Point(6, 16);
            this.dgvGrafik.Name = "dgvGrafik";
            this.dgvGrafik.ReadOnly = true;
            this.dgvGrafik.Size = new System.Drawing.Size(635, 302);
            this.dgvGrafik.TabIndex = 0;
            this.dgvGrafik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrafik_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Процентная ставка (%)";
            // 
            // percRate
            // 
            this.percRate.DecimalPlaces = 2;
            this.percRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.percRate.Location = new System.Drawing.Point(172, 111);
            this.percRate.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.percRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.percRate.Name = "percRate";
            this.percRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.percRate.Size = new System.Drawing.Size(120, 20);
            this.percRate.TabIndex = 12;
            this.percRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.percRate.ValueChanged += new System.EventHandler(this.percRate_ValueChanged);
            // 
            // Columns1
            // 
            this.Columns1.HeaderText = "День";
            this.Columns1.Name = "Columns1";
            this.Columns1.ReadOnly = true;
            // 
            // Columns2
            // 
            this.Columns2.HeaderText = "Ставка (%)";
            this.Columns2.Name = "Columns2";
            this.Columns2.ReadOnly = true;
            this.Columns2.Width = 150;
            // 
            // Columns3
            // 
            this.Columns3.HeaderText = "Накопительно (Руб)";
            this.Columns3.Name = "Columns3";
            this.Columns3.ReadOnly = true;
            this.Columns3.Width = 150;
            // 
            // Columns4
            // 
            this.Columns4.HeaderText = "Сумма выплат (Руб)";
            this.Columns4.Name = "Columns4";
            this.Columns4.ReadOnly = true;
            this.Columns4.Width = 200;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(309, 157);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(309, 66);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(103, 23);
            this.btLoad.TabIndex = 14;
            this.btLoad.Text = "загрузить дни";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btPrecent
            // 
            this.btPrecent.Location = new System.Drawing.Point(309, 113);
            this.btPrecent.Name = "btPrecent";
            this.btPrecent.Size = new System.Drawing.Size(122, 23);
            this.btPrecent.TabIndex = 15;
            this.btPrecent.Text = "загрузить проценты";
            this.btPrecent.UseVisualStyleBackColor = true;
            this.btPrecent.Click += new System.EventHandler(this.btPrecent_Click);
            // 
            // Microcredit_Calc
            // 
            this.ClientSize = new System.Drawing.Size(815, 636);
            this.Controls.Add(this.btPrecent);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.percRate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butPriceGo);
            this.Controls.Add(this.creditTerm);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sumCredit);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Microcredit_Calc";
            this.Text = "Microcredit_Calc";
            ((System.ComponentModel.ISupportInitialize)(this.sumCredit)).EndInit();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditTerm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sumCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.TextBox percentSum;
        private System.Windows.Forms.TextBox effectivRate;
        private System.Windows.Forms.TextBox allSum;
        private System.Windows.Forms.NumericUpDown creditTerm;
        private System.Windows.Forms.Button butPriceGo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGrafik;
        private System.Windows.Forms.Button butSaveAsCSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown percRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columns1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columns2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columns3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columns4;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btPrecent;
    }
}

