using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            decimal SumNakop = 0;
            for (int i = 0; i < creditTerm.Value; ++i)
            {   
                decimal Nakop = (sumCredit.Value / 100) / creditTerm.Value + SumNakop;
                dgvGrafik.Rows.Add();
                dgvGrafik[0, i].Value = i + 1; //номер месяца
                dgvGrafik[1, i].Value = percRate.Value / creditTerm.Value;
                dgvGrafik[2, i].Value = Nakop;
                dgvGrafik[3, i].Value = sumCredit.Value + Nakop;
                SumNakop = Convert.ToDecimal (dgvGrafik[2, i].Value);

            }
        }
    }
}
