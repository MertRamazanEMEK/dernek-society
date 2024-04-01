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
using System.Data.OleDb;

namespace PresentationLayer
{
    public partial class PL_ZedGraphCity : Form
    {
        private BusinessLayer.BL_ZedGraphCity pl_zedgraphcity;

        public PL_ZedGraphCity()
        {
            pl_zedgraphcity = new BusinessLayer.BL_ZedGraphCity();
            InitializeComponent();
        }
        private void PL_ZedGraphCity_Load(object sender, EventArgs e)
        {
            DisplayGraph();
        }
        public void DisplayGraph()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;
            PointPairList list = pl_zedgraphcity.LoadGraphData();
            BarItem myBar = myPane.AddBar("Üye Sayısı", list, System.Drawing.Color.Black);
            myBar.Bar.Fill = new Fill(System.Drawing.Color.Brown);
            myBar.Label.IsVisible = true;
            myPane.XAxis.Type = AxisType.Text;
            myPane.XAxis.Scale.TextLabels = list.Select(p => p.Tag.ToString()).ToArray();

            myPane.XAxis.Title.Text = "Şehirler";
            myPane.YAxis.Title.Text = "Üye Sayısı";

            zedGraphControl1.AxisChange();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }
    }

}