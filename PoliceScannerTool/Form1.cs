using PoliceScannerTool.Dtos;
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

        public Form1()
        {
            InitializeComponent();
            // get date limits
            // set date limits
        }

        private void YearInput_ValueChanged(object sender, EventArgs e)
        {
            // Update valid month selections
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Get and format inputs
            // Send API request
            // Display result
        }
    }
}
