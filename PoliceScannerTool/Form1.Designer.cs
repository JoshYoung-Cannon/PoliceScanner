
namespace PoliceScannerTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputWindow = new System.Windows.Forms.RichTextBox();
            this.LatitudeInput = new System.Windows.Forms.NumericUpDown();
            this.LongitudeInput = new System.Windows.Forms.NumericUpDown();
            this.YearInput = new System.Windows.Forms.NumericUpDown();
            this.MonthInput = new System.Windows.Forms.NumericUpDown();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LatitiudeLabel = new System.Windows.Forms.Label();
            this.LongitudeLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LatitudeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongitudeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputWindow
            // 
            this.OutputWindow.Location = new System.Drawing.Point(100, 129);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.ReadOnly = true;
            this.OutputWindow.Size = new System.Drawing.Size(579, 263);
            this.OutputWindow.TabIndex = 0;
            this.OutputWindow.Text = "";
            // 
            // LatitudeInput
            // 
            this.LatitudeInput.DecimalPlaces = 7;
            this.LatitudeInput.Location = new System.Drawing.Point(100, 103);
            this.LatitudeInput.Maximum = new decimal(new int[] {
            61,
            0,
            0,
            0});
            this.LatitudeInput.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.LatitudeInput.Name = "LatitudeInput";
            this.LatitudeInput.Size = new System.Drawing.Size(120, 20);
            this.LatitudeInput.TabIndex = 1;
            this.LatitudeInput.Value = new decimal(new int[] {
            514423427,
            0,
            0,
            458752});
            // 
            // LongitudeInput
            // 
            this.LongitudeInput.DecimalPlaces = 7;
            this.LongitudeInput.Location = new System.Drawing.Point(226, 103);
            this.LongitudeInput.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.LongitudeInput.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.LongitudeInput.Name = "LongitudeInput";
            this.LongitudeInput.Size = new System.Drawing.Size(120, 20);
            this.LongitudeInput.TabIndex = 2;
            this.LongitudeInput.Value = new decimal(new int[] {
            25003052,
            0,
            0,
            -2147024896});
            // 
            // YearInput
            // 
            this.YearInput.Location = new System.Drawing.Point(352, 103);
            this.YearInput.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.YearInput.Minimum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.YearInput.Name = "YearInput";
            this.YearInput.Size = new System.Drawing.Size(120, 20);
            this.YearInput.TabIndex = 3;
            this.YearInput.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.YearInput.ValueChanged += new System.EventHandler(this.YearInput_ValueChanged);
            // 
            // MonthInput
            // 
            this.MonthInput.Location = new System.Drawing.Point(478, 103);
            this.MonthInput.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MonthInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonthInput.Name = "MonthInput";
            this.MonthInput.Size = new System.Drawing.Size(120, 20);
            this.MonthInput.TabIndex = 4;
            this.MonthInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(604, 100);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LatitiudeLabel
            // 
            this.LatitiudeLabel.AutoSize = true;
            this.LatitiudeLabel.Location = new System.Drawing.Point(100, 87);
            this.LatitiudeLabel.Name = "LatitiudeLabel";
            this.LatitiudeLabel.Size = new System.Drawing.Size(47, 13);
            this.LatitiudeLabel.TabIndex = 6;
            this.LatitiudeLabel.Text = "Latitiude";
            // 
            // LongitudeLabel
            // 
            this.LongitudeLabel.AutoSize = true;
            this.LongitudeLabel.Location = new System.Drawing.Point(223, 87);
            this.LongitudeLabel.Name = "LongitudeLabel";
            this.LongitudeLabel.Size = new System.Drawing.Size(54, 13);
            this.LongitudeLabel.TabIndex = 7;
            this.LongitudeLabel.Text = "Longitude";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(349, 87);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 8;
            this.YearLabel.Text = "Year";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(475, 87);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(37, 13);
            this.MonthLabel.TabIndex = 9;
            this.MonthLabel.Text = "Month";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.LongitudeLabel);
            this.Controls.Add(this.LatitiudeLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MonthInput);
            this.Controls.Add(this.YearInput);
            this.Controls.Add(this.LongitudeInput);
            this.Controls.Add(this.LatitudeInput);
            this.Controls.Add(this.OutputWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LatitudeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongitudeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputWindow;
        private System.Windows.Forms.NumericUpDown LatitudeInput;
        private System.Windows.Forms.NumericUpDown LongitudeInput;
        private System.Windows.Forms.NumericUpDown MonthInput;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label LatitiudeLabel;
        private System.Windows.Forms.Label LongitudeLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.NumericUpDown YearInput;
    }
}

