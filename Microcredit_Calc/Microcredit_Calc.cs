using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Microcredit_Calc
{
    public partial class Microcredit_Calc : Form
    {
        public Microcredit_Calc()
        {
            InitializeComponent();
        }

        private void percRate_ValueChanged(object sender, EventArgs e)
        {}

        private void dgvGrafik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void butPriceGo_Click(object sender, EventArgs e)
        {
            Payment();
        }
        private void Payment()
        {

            decimal AllSum = 0;
            decimal SumNakop = 0;
            for (int i = 0; i < creditTerm.Value; ++i)
            {   
                decimal Nakop = (sumCredit.Value / 100) / creditTerm.Value + SumNakop;
                dgvGrafik.Rows.Add();
                dgvGrafik[0, i].Value = i + 1; // день
                dgvGrafik[1, i].Value = percRate.Value / creditTerm.Value;//находит процент на один день
                dgvGrafik[2, i].Value = Nakop;// накопительная. те взял цену поделил на 100 и пожделил на процентную ставку
                dgvGrafik[3, i].Value = sumCredit.Value + Nakop;// накоп + займ
                SumNakop = Convert.ToDecimal (dgvGrafik[2, i].Value);
                if (i == creditTerm.Value - 1)
                {
                    AllSum = Convert.ToDecimal(dgvGrafik[3, i].Value);
                    allSum.Text = Convert.ToString(AllSum);
                    effectivRate.Text = Convert.ToString(Convert.ToDecimal (dgvGrafik[1, i].Value) * creditTerm.Value / creditTerm.Value);
                    percentSum.Text = Convert.ToString(AllSum - Convert.ToDecimal(sumCredit.Value));


                }

            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            allSum.Clear();
            effectivRate.Clear();
            percentSum.Clear();
            sumCredit.Value = sumCredit.Minimum;
            creditTerm.Value = creditTerm.Minimum;
            percRate.Value = percRate.Minimum;
            dgvGrafik.Rows.Clear();
        }

        private void butSaveAsCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTableAsCSV = new SaveFileDialog();
            saveTableAsCSV.Filter = "Документ CSV (*.csv) |*.csv";
            saveTableAsCSV.Title = "Сохранить результат расчетов";
            if (saveTableAsCSV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(saveTableAsCSV.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(file, Encoding.Default);
                    sw.Write("Общая сумма выплаты:" + ";" + allSum.Text);
                    sw.WriteLine();
                    sw.Write("Сумма переплаты:" + ";" + percentSum.Text);
                    sw.WriteLine();
                    sw.Write("День:" + ";" + "Ставка (%)" + ";" + " Накопительно (руб)" + ";" + "Сумма выплат(руб)" + ";");
                    sw.WriteLine();
                    for (int i = 0; i < dgvGrafik.RowCount; i++)
                    {
                        for (int j = 0; j < dgvGrafik.ColumnCount; j++)
                        {
                            sw.Write(Convert.ToDouble(dgvGrafik.Rows[i].Cells[j].Value));
                            if (j < dgvGrafik.ColumnCount - 1)
                                sw.Write(";");
                        }
                        sw.WriteLine();
                    }
                    sw.Close();
                }
                catch
                { }
            }
        }

        private void sumCredit_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (sumCredit.Value >= 300000 || sumCredit.Value <= 1000)
                {
                    MessageBox.Show("Нельзя запрашивать в долг больше 300000 или меньше 1000");
                    throw new ArgumentNullException();
                }
            }
            catch 
            {
                MessageBox.Show("Подставьте правильные значения");
            }
            
        }

        private void creditTerm_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (creditTerm.Value > 365 || creditTerm.Value < 1)
                {
                    MessageBox.Show("Нельзя брать кредит больше чем на год или меньше 1 дней");
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                MessageBox.Show("Подставьте правильные значения");
            }
        }
    }
}
