using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avery_Operations
{

    using OxyPlot;
    using OxyPlot.Series;

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            plotYield(100,0);
            
        }


        private void plotYield(int Buenas, int Malas)
        {
            var plotView1 = new PlotModel { Title = "Yield: " };

            dynamic seriesP1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

            seriesP1.Slices.Add(new PieSlice("Piezas Buenas", Buenas) { IsExploded = false, Fill = OxyColors.PaleVioletRed });
            seriesP1.Slices.Add(new PieSlice("Piezas Malas" , Malas) { IsExploded = true });

            plotView1.Series.Add(seriesP1);
            this.plotView1.Model = plotView1;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int Totalvalue;
            float Yieldvalue;
            bool Total = Int32.TryParse(txtTotal.Text, out Totalvalue);
            bool Yield = float.TryParse(txtYield.Text, out Yieldvalue);
            if (Total & Yield)
            {
                var Buenas = Totalvalue * (Yieldvalue / 100);
                var Malas = Totalvalue - Buenas;
                plotYield((int)Buenas, (int)Malas);

                lblBuenas.Text = ((int)Buenas).ToString();
                lblMalas.Text = ((int)Malas).ToString();

                MessageBox.Show("Correcto!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Dato Invalido", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
