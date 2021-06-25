
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
            this.allSum = new System.Windows.Forms.TextBox();
            this.effectivRate = new System.Windows.Forms.TextBox();
            this.percentSum = new System.Windows.Forms.TextBox();
            this.creditTerm = new System.Windows.Forms.NumericUpDown();
            this.butPriceGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sumCredit)).BeginInit();
            this.Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Сумма займа";
            this.label2.UseMnemonic = false;
            // 
            // sumCredit
            // 
            this.sumCredit.Location = new System.Drawing.Point(129, 31);
            this.sumCredit.Maximum = new decimal(new int[] {
            100000,
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок займа";
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
            this.Result.Controls.Add(this.percentSum);
            this.Result.Controls.Add(this.effectivRate);
            this.Result.Controls.Add(this.allSum);
            this.Result.Controls.Add(this.label4);
            this.Result.Controls.Add(this.label5);
            this.Result.Controls.Add(this.label6);
            this.Result.Location = new System.Drawing.Point(493, 12);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(318, 140);
            this.Result.TabIndex = 6;
            this.Result.TabStop = false;
            this.Result.Text = "Результат";
            // 
            // allSum
            // 
            this.allSum.Location = new System.Drawing.Point(147, 13);
            this.allSum.Name = "allSum";
            this.allSum.Size = new System.Drawing.Size(120, 20);
            this.allSum.TabIndex = 6;
            // 
            // effectivRate
            // 
            this.effectivRate.Location = new System.Drawing.Point(147, 59);
            this.effectivRate.Name = "effectivRate";
            this.effectivRate.Size = new System.Drawing.Size(120, 20);
            this.effectivRate.TabIndex = 7;
            // 
            // percentSum
            // 
            this.percentSum.Location = new System.Drawing.Point(147, 103);
            this.percentSum.Name = "percentSum";
            this.percentSum.Size = new System.Drawing.Size(120, 20);
            this.percentSum.TabIndex = 8;
            // 
            // creditTerm
            // 
            this.creditTerm.Location = new System.Drawing.Point(129, 94);
            this.creditTerm.Maximum = new decimal(new int[] {
            365,
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
            // 
            // butPriceGo
            // 
            this.butPriceGo.Location = new System.Drawing.Point(308, 193);
            this.butPriceGo.Name = "butPriceGo";
            this.butPriceGo.Size = new System.Drawing.Size(167, 22);
            this.butPriceGo.TabIndex = 8;
            this.butPriceGo.Text = "Рассчитать";
            this.butPriceGo.UseVisualStyleBackColor = true;
            // 
            // Microcredit_Calc
            // 
            this.ClientSize = new System.Drawing.Size(823, 400);
            this.Controls.Add(this.butPriceGo);
            this.Controls.Add(this.creditTerm);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sumCredit);
            this.Controls.Add(this.label2);
            this.Name = "Microcredit_Calc";
            this.Text = "Microcredit_Calc";
            ((System.ComponentModel.ISupportInitialize)(this.sumCredit)).EndInit();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditTerm)).EndInit();
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
    }
}

