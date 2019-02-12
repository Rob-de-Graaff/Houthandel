namespace Houthandel
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
            this.panelLayout = new System.Windows.Forms.Panel();
            this.panelDay = new System.Windows.Forms.Panel();
            this.numericUpDownDay2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxSurface = new System.Windows.Forms.TextBox();
            this.labelSurface = new System.Windows.Forms.Label();
            this.listBoxClass = new System.Windows.Forms.ListBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.panelYear = new System.Windows.Forms.Panel();
            this.numericUpDownYear1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYear2 = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTicketsTotal = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.numericUpDownMonth2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth1 = new System.Windows.Forms.NumericUpDown();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.panelLayout.SuspendLayout();
            this.panelDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).BeginInit();
            this.panelYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).BeginInit();
            this.panelMonth.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLayout
            // 
            this.panelLayout.Controls.Add(this.panelMonth);
            this.panelLayout.Controls.Add(this.panelDay);
            this.panelLayout.Controls.Add(this.textBoxSurface);
            this.panelLayout.Controls.Add(this.labelSurface);
            this.panelLayout.Controls.Add(this.listBoxClass);
            this.panelLayout.Controls.Add(this.labelVolume);
            this.panelLayout.Controls.Add(this.textBoxVolume);
            this.panelLayout.Controls.Add(this.panelYear);
            this.panelLayout.Controls.Add(this.buttonCalculate);
            this.panelLayout.Controls.Add(this.labelTicketsTotal);
            this.panelLayout.Controls.Add(this.labelPriceTotal);
            this.panelLayout.Location = new System.Drawing.Point(12, 12);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(561, 209);
            this.panelLayout.TabIndex = 27;
            // 
            // panelDay
            // 
            this.panelDay.Controls.Add(this.numericUpDownDay1);
            this.panelDay.Controls.Add(this.numericUpDownDay2);
            this.panelDay.Location = new System.Drawing.Point(337, 3);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(47, 56);
            this.panelDay.TabIndex = 29;
            // 
            // numericUpDownDay2
            // 
            this.numericUpDownDay2.Location = new System.Drawing.Point(0, 31);
            this.numericUpDownDay2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay2.Name = "numericUpDownDay2";
            this.numericUpDownDay2.ReadOnly = true;
            this.numericUpDownDay2.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownDay2.TabIndex = 29;
            this.numericUpDownDay2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDay1
            // 
            this.numericUpDownDay1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownDay1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay1.Name = "numericUpDownDay1";
            this.numericUpDownDay1.ReadOnly = true;
            this.numericUpDownDay1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownDay1.TabIndex = 26;
            this.numericUpDownDay1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxSurface
            // 
            this.textBoxSurface.Location = new System.Drawing.Point(109, 111);
            this.textBoxSurface.MaxLength = 7;
            this.textBoxSurface.Name = "textBoxSurface";
            this.textBoxSurface.Size = new System.Drawing.Size(96, 22);
            this.textBoxSurface.TabIndex = 62;
            this.textBoxSurface.Text = "0";
            // 
            // labelSurface
            // 
            this.labelSurface.AutoSize = true;
            this.labelSurface.Location = new System.Drawing.Point(10, 114);
            this.labelSurface.Name = "labelSurface";
            this.labelSurface.Size = new System.Drawing.Size(93, 17);
            this.labelSurface.TabIndex = 61;
            this.labelSurface.Text = "Oppervlakte :";
            // 
            // listBoxClass
            // 
            this.listBoxClass.FormattingEnabled = true;
            this.listBoxClass.ItemHeight = 16;
            this.listBoxClass.Location = new System.Drawing.Point(6, 3);
            this.listBoxClass.Name = "listBoxClass";
            this.listBoxClass.Size = new System.Drawing.Size(199, 68);
            this.listBoxClass.TabIndex = 60;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(10, 86);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(63, 17);
            this.labelVolume.TabIndex = 56;
            this.labelVolume.Text = "Volume :";
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(109, 83);
            this.textBoxVolume.MaxLength = 7;
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(96, 22);
            this.textBoxVolume.TabIndex = 55;
            this.textBoxVolume.Text = "0";
            // 
            // panelYear
            // 
            this.panelYear.Controls.Add(this.numericUpDownYear1);
            this.panelYear.Controls.Add(this.numericUpDownYear2);
            this.panelYear.Location = new System.Drawing.Point(486, 2);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(67, 57);
            this.panelYear.TabIndex = 25;
            // 
            // numericUpDownYear1
            // 
            this.numericUpDownYear1.Location = new System.Drawing.Point(1, 1);
            this.numericUpDownYear1.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDownYear1.Minimum = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            this.numericUpDownYear1.Name = "numericUpDownYear1";
            this.numericUpDownYear1.ReadOnly = true;
            this.numericUpDownYear1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownYear1.TabIndex = 24;
            this.numericUpDownYear1.Value = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            // 
            // numericUpDownYear2
            // 
            this.numericUpDownYear2.Location = new System.Drawing.Point(1, 32);
            this.numericUpDownYear2.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDownYear2.Minimum = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            this.numericUpDownYear2.Name = "numericUpDownYear2";
            this.numericUpDownYear2.ReadOnly = true;
            this.numericUpDownYear2.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownYear2.TabIndex = 27;
            this.numericUpDownYear2.Value = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(462, 172);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(89, 33);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "show price";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelTicketsTotal
            // 
            this.labelTicketsTotal.AutoSize = true;
            this.labelTicketsTotal.Location = new System.Drawing.Point(3, 155);
            this.labelTicketsTotal.Name = "labelTicketsTotal";
            this.labelTicketsTotal.Size = new System.Drawing.Size(13, 17);
            this.labelTicketsTotal.TabIndex = 22;
            this.labelTicketsTotal.Text = "-";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Location = new System.Drawing.Point(3, 172);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(13, 17);
            this.labelPriceTotal.TabIndex = 21;
            this.labelPriceTotal.Text = "-";
            // 
            // numericUpDownMonth2
            // 
            this.numericUpDownMonth2.Location = new System.Drawing.Point(0, 31);
            this.numericUpDownMonth2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth2.Name = "numericUpDownMonth2";
            this.numericUpDownMonth2.ReadOnly = true;
            this.numericUpDownMonth2.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownMonth2.TabIndex = 28;
            this.numericUpDownMonth2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMonth1
            // 
            this.numericUpDownMonth1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownMonth1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth1.Name = "numericUpDownMonth1";
            this.numericUpDownMonth1.ReadOnly = true;
            this.numericUpDownMonth1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownMonth1.TabIndex = 25;
            this.numericUpDownMonth1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelMonth
            // 
            this.panelMonth.Controls.Add(this.numericUpDownMonth1);
            this.panelMonth.Controls.Add(this.numericUpDownMonth2);
            this.panelMonth.Location = new System.Drawing.Point(412, 3);
            this.panelMonth.Name = "panelMonth";
            this.panelMonth.Size = new System.Drawing.Size(47, 56);
            this.panelMonth.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLayout.ResumeLayout(false);
            this.panelLayout.PerformLayout();
            this.panelDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).EndInit();
            this.panelYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).EndInit();
            this.panelMonth.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.ListBox listBoxClass;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.Panel panelYear;
        private System.Windows.Forms.NumericUpDown numericUpDownYear1;
        private System.Windows.Forms.NumericUpDown numericUpDownYear2;
        private System.Windows.Forms.NumericUpDown numericUpDownDay2;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth2;
        private System.Windows.Forms.NumericUpDown numericUpDownDay1;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTicketsTotal;
        private System.Windows.Forms.Label labelPriceTotal;
        private System.Windows.Forms.TextBox textBoxSurface;
        private System.Windows.Forms.Label labelSurface;
        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.Panel panelMonth;
    }
}

