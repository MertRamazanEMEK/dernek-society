using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace PresentationLayer
{
    public partial class PL_ZedGraphAidat : Form
    {
        private BusinessLayer.BL_ZedGraphUcret pl_tarih;
        public PL_ZedGraphAidat()
        {
            pl_tarih = new BusinessLayer.BL_ZedGraphUcret();
            InitializeComponent();

        }
        private void PL_ZedGraphAidat_Load(object sender, EventArgs e)
        {
            DisplayMonthlyMembershipFee();
        }

        public void DisplayMonthlyMembershipFee()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.CurveList.Clear();
            PointPairList monthlyMembershipFee = pl_tarih.GetMonthlyMembershipFee();
            LineItem myCurve = myPane.AddCurve("Aylık Aidat", monthlyMembershipFee, System.Drawing.Color.Blue, SymbolType.Circle);
            myPane.XAxis.Type = AxisType.Date;
            myPane.XAxis.Title.Text = "Tarih";
            myPane.XAxis.Scale.Format = "dd/MM/yyyy";
            myPane.YAxis.Title.Text = "Aidat Miktarı";

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
        }

    }
}
