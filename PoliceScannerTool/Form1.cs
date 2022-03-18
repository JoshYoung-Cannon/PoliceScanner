using PoliceScannerTool.Dtos;
using PoliceScannerTool.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceScannerTool
{
    public partial class Form1 : Form
    {
        private FormDate LatestDate { get; set; }
        private FormDate EarliestDate { get; set; }
        private int StartMonth { get; }
        private int EndMonth { get; }

        public Form1()
        {
            InitializeComponent();

            // set date limits
            StartMonth = 1;
            EndMonth = 12;
            SetupServices setup = new SetupServices();
            LatestDate = setup.GetLatestUpdate();
            EarliestDate = new FormDate(2019, 2);

            this.YearInput.Maximum = LatestDate.Year;
            this.YearInput.Minimum = EarliestDate.Year;
            this.YearInput.Value = LatestDate.Year;

            this.MonthInput.Maximum = LatestDate.Month;
            this.MonthInput.Minimum = StartMonth;
            this.MonthInput.Value = LatestDate.Month;
        }

        private void YearInput_ValueChanged(object sender, EventArgs e)
        {
            // Update valid month selections
            int selectedYear = Convert.ToInt32(this.YearInput.Value);

            if (selectedYear == LatestDate.Year)
            {
                this.MonthInput.Maximum = LatestDate.Month;
                this.MonthInput.Minimum = StartMonth;
                this.MonthInput.Value = StartMonth;
            }
            else if (selectedYear > EarliestDate.Year)
            {
                this.MonthInput.Maximum = EndMonth;
                this.MonthInput.Minimum = StartMonth;
                this.MonthInput.Value = StartMonth;
            }
            else
            {
                this.MonthInput.Maximum = EndMonth;
                this.MonthInput.Minimum = EarliestDate.Month;
                this.MonthInput.Value = EarliestDate.Month;
            }
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Get and format inputs
            // Send API request
            // Display result
        }
    }
}
