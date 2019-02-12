using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Houthandel
{
    public partial class Form1 : Form
    {
        private WoodClass _newWoodClass1, _newWoodClass2, _newWoodClass3;
        private List<WoodClass> woodClasses;
        private DateTime dateStart, dateEnd;
        private double _priceTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _newWoodClass1 = new WoodClass("klasse 1", 300, 0.60, 1);
            _newWoodClass2 = new WoodClass("klasse 2", 500, 0.60, 1);
            _newWoodClass3 = new WoodClass("klasse 3", 450, 0.60, 1);

            woodClasses = new List<WoodClass>();

            woodClasses.Add(_newWoodClass1);
            woodClasses.Add(_newWoodClass2);
            woodClasses.Add(_newWoodClass3);

            // Displays name property
            listBoxClass.DataSource = woodClasses;
            listBoxClass.DisplayMember = "Name";


            // Fills numericupdowns
            foreach (NumericUpDown control in panelYear.Controls)
            {
                control.Maximum = DateTime.Today.Year + 20;
                control.Minimum = DateTime.Today.Year;
                control.Value = DateTime.Today.Year;
            }

            foreach (NumericUpDown control in panelMonth.Controls)
            {
                control.Minimum = DateTime.Today.Month;
                control.Value = DateTime.Today.Month;
            }

            foreach (NumericUpDown control in panelDay.Controls)
            {
                control.Minimum = DateTime.Today.Day;
                control.Value = DateTime.Today.Day;
            }

            // Displays calculation, total
            labelTicketsTotal.Text = $@"(houtprijs * volume + schaafloon * opp) * korting";
            labelPriceTotal.Text = $@"Totaal: € {Math.Round(_priceTotal, 2):0.00},-";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            WoodClass tempWoodClass = (WoodClass)listBoxClass.SelectedItem;
            double woodCosts = 0;
            double planWage = 0;

            if (int.TryParse(textBoxVolume.Text, out int resultVolume) && resultVolume > 0)
            {
                if (int.TryParse(textBoxSurface.Text, out int resultSurface) && resultSurface > 0)
                {
                    if (ValidateDate())
                    {
                        int deliveryTime = (int)(dateEnd - dateStart).TotalDays;

                        _priceTotal += tempWoodClass.Price * resultVolume;
                        planWage += tempWoodClass.PlanWage;
                        woodCosts += planWage * resultSurface;

                        // Checks if wood costs >= 200
                        if (woodCosts >= 200)
                        {
                            woodCosts = 0;
                            planWage = 0;
                            woodCosts = planWage * resultSurface;
                        }

                        _priceTotal += woodCosts;

                        switch (deliveryTime)
                        {
                            case int d when (d >= 28):
                                tempWoodClass.Discount = 0.975;
                                //Console.WriteLine($"I am 28 or above: {d}");
                                break;

                            case int d when (d < 28 && d >= 21):
                                tempWoodClass.Discount = 0.98;
                                //Console.WriteLine($"I am between 27 and 21: {d}");
                                break;

                            case int d when (d < 21 && d >= 14):
                                tempWoodClass.Discount = 0.99;
                                //Console.WriteLine($"I am between 20 and 14: {d}");
                                break;
                        }

                        _priceTotal = _priceTotal * tempWoodClass.Discount;

                        // Displays calculation, total
                        labelTicketsTotal.Text = $@"(houtprijs € {tempWoodClass.Price} * volume {resultVolume}m3 + schaafloon € {planWage:0.00} * opp {resultSurface}m2) * korting {(1-tempWoodClass.Discount)*100}%";
                        labelPriceTotal.Text = $@"Totaal: € {Math.Round(_priceTotal, 2):0.00},-";
                    }
                }
                else
                {
                    MessageBox.Show($@"Oppervlakte must contain only numbers > 0");
                }
            }
            else
            {
                MessageBox.Show($@"Volume must contain only numbers > 0");
            }
        }

        private bool ValidateDate()
        {
            int checkDay1 = DateTime.DaysInMonth((int)numericUpDownYear1.Value, (int)numericUpDownMonth1.Value);
            int checkDay2 = DateTime.DaysInMonth((int)numericUpDownYear2.Value, (int)numericUpDownMonth2.Value);
            
            // Checks if selected day is a valid option per month
            if ((int)numericUpDownDay1.Value <= checkDay1 && (int)numericUpDownDay2.Value <= checkDay2)
            {
                // Checks if the dates are in the correct order
                dateStart = new DateTime((int)numericUpDownYear1.Value, (int)numericUpDownMonth1.Value, (int)numericUpDownDay1.Value);
                dateEnd = new DateTime((int)numericUpDownYear2.Value, (int)numericUpDownMonth2.Value, (int)numericUpDownDay2.Value);
                if (dateStart < dateEnd)
                {
                    
                    return true;
                }
                else
                {
                    MessageBox.Show($"Please fill the dates in the correct order \nstart date < end date");
                    return false;
                }
            }
            else
            {
                MessageBox.Show($@"Please select the correct day of the month");
                return false;
            }
        }
    }
}
