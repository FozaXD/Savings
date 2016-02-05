using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savings
{
    public partial class Breakdown : Form
    {
        public Breakdown()
        {
            InitializeComponent();

            SetLabels();
            SetCatTotals();
            LoadOverallChart();
            LoadCat1Chart();
            LoadCat2Chart();
            LoadCat3Chart();
            LoadCat4Chart();
        }

        public void SetLabels()
        {
            overallTotal.Visible = false;
            noCat1.Visible = false;
            noCat2.Visible = false;
            noCat3.Visible = false;
            noCat4.Visible = false;
            noValues.Visible = false;

            overallTotal.Text = Figures.overallTotal.ToString("C", CultureInfo.CurrentCulture);

            overallTotal.Visible = true;


        }

        public void SetCatTotals()
        {
            yearlyCat1Total.Visible = false;
            yearlyCat2Total.Visible = false;
            yearlyCat3Total.Visible = false;
            yearlyCat4Total.Visible = false;
            monthlyCat1Total.Visible = false;
            monthlyCat2Total.Visible = false;
            monthlyCat3Total.Visible = false;
            monthlyCat4Total.Visible = false;
            wantedCat1Total.Visible = false;
            wantedCat2Total.Visible = false;
            wantedCat3Total.Visible = false;
            wantedCat4Total.Visible = false;
            yearlyTotal.Visible = false;
            monthlyTotal.Visible = false;
            wantedTotal.Visible = false;

            yearlyCat1Total.Text = Figures.sumYearlyCat1.ToString("C", CultureInfo.CurrentCulture);
            yearlyCat2Total.Text = Figures.sumYearlyCat2.ToString("C", CultureInfo.CurrentCulture);
            yearlyCat3Total.Text = Figures.sumYearlyCat3.ToString("C", CultureInfo.CurrentCulture);
            yearlyCat4Total.Text = Figures.sumYearlyCat4.ToString("C", CultureInfo.CurrentCulture);

            monthlyCat1Total.Text = Figures.sumMonthlyCat1.ToString("C", CultureInfo.CurrentCulture);
            monthlyCat2Total.Text = Figures.sumMonthlyCat2.ToString("C", CultureInfo.CurrentCulture);
            monthlyCat3Total.Text = Figures.sumMonthlyCat3.ToString("C", CultureInfo.CurrentCulture);
            monthlyCat4Total.Text = Figures.sumMonthlyCat4.ToString("C", CultureInfo.CurrentCulture);

            wantedCat1Total.Text = Figures.sumWantedCat1.ToString("C", CultureInfo.CurrentCulture);
            wantedCat2Total.Text = Figures.sumWantedCat2.ToString("C", CultureInfo.CurrentCulture);
            wantedCat3Total.Text = Figures.sumWantedCat3.ToString("C", CultureInfo.CurrentCulture);
            wantedCat4Total.Text = Figures.sumWantedCat4.ToString("C", CultureInfo.CurrentCulture);

            yearlyTotal.Text = Figures.totalYearly.ToString("C", CultureInfo.CurrentCulture);
            monthlyTotal.Text = Figures.totalMonthly.ToString("C", CultureInfo.CurrentCulture);
            wantedTotal.Text = Figures.totalWanted.ToString("C", CultureInfo.CurrentCulture);



            yearlyCat1Total.Visible = true;
            yearlyCat2Total.Visible = true;
            yearlyCat3Total.Visible = true;
            yearlyCat4Total.Visible = true;
            monthlyCat1Total.Visible = true;
            monthlyCat2Total.Visible = true;
            monthlyCat3Total.Visible = true;
            monthlyCat4Total.Visible = true;
            wantedCat1Total.Visible = true;
            wantedCat2Total.Visible = true;
            wantedCat3Total.Visible = true;
            wantedCat4Total.Visible = true;
            yearlyTotal.Visible = true;
            monthlyTotal.Visible = true;
            wantedTotal.Visible = true;
        }

        public void LoadOverallChart()
        {
            if ((Figures.sumYearlyCat1 + Figures.sumMonthlyCat1 + Figures.sumWantedCat1) > 0)
            {
                chart1.Series["Breakdown"].Points.AddXY("Category 1", Figures.sumYearlyCat1 + Figures.sumMonthlyCat1 + Figures.sumWantedCat1);
            }
            if ((Figures.sumYearlyCat2 + Figures.sumMonthlyCat2 + Figures.sumWantedCat2) > 0)
            {
                chart1.Series["Breakdown"].Points.AddXY("Category 2", Figures.sumYearlyCat2 + Figures.sumMonthlyCat2 + Figures.sumWantedCat2);
            }
            if ((Figures.sumYearlyCat3 + Figures.sumMonthlyCat3 + Figures.sumWantedCat3) > 0)
            {
                chart1.Series["Breakdown"].Points.AddXY("Category 3", Figures.sumYearlyCat3 + Figures.sumMonthlyCat3 + Figures.sumWantedCat3);
            }
            if ((Figures.sumYearlyCat4 + Figures.sumMonthlyCat4 + Figures.sumWantedCat4) > 0)
            {
                chart1.Series["Breakdown"].Points.AddXY("Category 4", Figures.sumYearlyCat4 + Figures.sumMonthlyCat4 + Figures.sumWantedCat4);
            }
        }

        public void LoadCat1Chart()
        {
            if (Figures.sumYearlyCat1 > 0)
            {
                chart3.Series["Cat1Breakdown"].Points.AddXY("Yearly", Figures.sumYearlyCat1);
            }
            if (Figures.sumMonthlyCat1 > 0)
            {
                chart3.Series["Cat1Breakdown"].Points.AddXY("Monthly", Figures.sumMonthlyCat1);
            }
            if (Figures.sumWantedCat1 > 0)
            {
                chart3.Series["Cat1Breakdown"].Points.AddXY("Wanted", Figures.sumWantedCat1);
            }
            if (chart3.Series["Cat1Breakdown"].Points.Count == 0)
            {
                noCat1.Visible = true;
            }
        }

        public void LoadCat2Chart()
        {
            if (Figures.sumYearlyCat2 > 0)
            {
                chart2.Series["Cat2Breakdown"].Points.AddXY("Yearly", Figures.sumYearlyCat2);
            }
            if (Figures.sumMonthlyCat2 > 0)
            {
                chart2.Series["Cat2Breakdown"].Points.AddXY("Monthly", Figures.sumMonthlyCat2);
            }
            if (Figures.sumWantedCat2 > 0)
            {
                chart2.Series["Cat2Breakdown"].Points.AddXY("Wanted", Figures.sumWantedCat2);
            }
            if (chart2.Series["Cat2Breakdown"].Points.Count == 0)
            {
                noCat2.Visible = true;
            }
        }

        public void LoadCat3Chart()
        {
            if (Figures.sumYearlyCat3 > 0)
            {
                chart4.Series["Cat3Breakdown"].Points.AddXY("Yearly", Figures.sumYearlyCat3);
            }
            if (Figures.sumMonthlyCat3 > 0)
            {
                chart4.Series["Cat3Breakdown"].Points.AddXY("Monthly", Figures.sumMonthlyCat3);
            }
            if (Figures.sumWantedCat3 > 0)
            {
                chart4.Series["Cat3Breakdown"].Points.AddXY("Wanted", Figures.sumWantedCat3);
            }
            if (chart4.Series["Cat3Breakdown"].Points.Count == 0)
            {
                noCat3.Visible = true;
            }
        }

        public void LoadCat4Chart()
        {
            if (Figures.sumYearlyCat4 > 0)
            {
                chart5.Series["Cat4Breakdown"].Points.AddXY("Yearly", Figures.sumYearlyCat4);
            }
            if (Figures.sumMonthlyCat4 > 0)
            {
                chart5.Series["Cat4Breakdown"].Points.AddXY("Monthly", Figures.sumMonthlyCat4);
            }
            if (Figures.sumWantedCat4 > 0)
            {
                chart5.Series["Cat4Breakdown"].Points.AddXY("Wanted", Figures.sumWantedCat4);
            }
            if (chart5.Series["Cat4Breakdown"].Points.Count == 0)
            {
                noCat4.Visible = true;
            }
        }
    }
}
