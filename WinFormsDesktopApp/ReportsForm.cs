using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json.Linq;

namespace WinFormsDesktopApp
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {

            InitializeComponent();
            InitializeChart();
            // Populates months
            populateMonthList();

            UpdateData();

            // Removes border from month arrows
            leftMonthArrowButton.FlatAppearance.BorderColor = leftMonthArrowButton.Parent.BackColor;
            rightMonthArrowButton.FlatAppearance.BorderColor = rightMonthArrowButton.Parent.BackColor;

            /*
            Font font = new Font("Helvetica", 9F);
            monthList.Font = font;*/
        }

        // puts items into the monthList combobox and sets default selected value
        private void populateMonthList()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            for (int i = 0; i < months.Length; i++)
            {
                monthList.Items.Add(months[i]);
            }

            // gets current month on system
            int currentMonth = DateTime.Now.Month;

            // default selected month on list is the current month on the calender
            monthList.SelectedIndex = currentMonth - 1;
        }

        private void leftMonthArrowButton_Click(object sender, EventArgs e)
        {
            if (monthList.SelectedIndex > 0)
            {
                monthList.SelectedIndex--;
            }
            else
            {
                monthList.SelectedIndex = monthList.Items.Count - 1;
            }
            UpdateData();
        }

        private void rightMonthArrowButton_Click(object sender, EventArgs e)
        {
            if (monthList.SelectedIndex < monthList.Items.Count - 1)
            {
                monthList.SelectedIndex++;
            }
            else
            {
                monthList.SelectedIndex = 0;
            }
            UpdateData();
        }

        private void PieSize_Resize(object sender, EventArgs e)
        {
            if (this.Width >= 1500)
            {
                PriorityPie.Size = new Size(Convert.ToInt32(PriorityPie.Width * 1.75), Convert.ToInt32(PriorityPie.Height * 1.75));
                StatusPie.Location = new Point(531, 41);
                StatusPie.Size = new Size(Convert.ToInt32(StatusPie.Width * 1.75), Convert.ToInt32(StatusPie.Height * 1.75));
            }
            if (this.Height <= 1000)
            {
                PriorityPie.Size = new Size(Convert.ToInt32(300 * 1.50), Convert.ToInt32(300 * 1.50));
                StatusPie.Location = new Point(531, 41); ; //new Point(306, 41);
                StatusPie.Size = new Size(Convert.ToInt32(300 * 1.50), Convert.ToInt32(300 * 1.50));
            }
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthList.SelectedIndex != 1)
            {
                UpdateData();
            }
        }

        private ChartValues<double> _values;

        private void InitializeChart()
        {
            _values = new ChartValues<double>();
            var random = new Random();

            PriorityPie.Series = new SeriesCollection
            {

                new PieSeries
                {
                    Title = "High Priority",
                    Values = new ChartValues<double> {},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Normal Priority",
                    Values = new ChartValues<double> {},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Low Priority",
                    Values = new ChartValues<double> {},
                    DataLabels = true
                },
            };

            StatusPie.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Open Ticket",
                    Values = new ChartValues<double> {},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Closed Ticket",
                    Values = new ChartValues<double> {},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "On Hold Ticket",
                    Values = new ChartValues<double> {},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Waiting for Customer",
                    Values = new ChartValues<double> {},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "In Progress",
                    Values = new ChartValues<double> {},
                    DataLabels = true
                },
            };
        }

        private void AddDataPoint(double value)
        {
            // Add new data point to the chart
            _values.Clear(); // Clear previous values
            _values.Add(value);
        }

        private void UpdateData()
        {
            int activeTickets;
            int inactiveTickets;
            int onHoldTickets;
            int waitingForCustomerTickets;
            int inProgressTickets;
            int highPriority;
            int medPriority;
            int lowPriority;
            Random rnd = new Random();
            switch (monthList.Text)
            {
                case "January":
                case "February":
                case "March":
                case "April":
                case "May":
                case "June":
                case "July":
                case "August":
                case "September":
                case "October":
                case "November":
                case "December":
                    activeTickets = rnd.Next(10, 101);
                    inactiveTickets = rnd.Next(10, 101);
                    onHoldTickets = rnd.Next(10, 101);
                    waitingForCustomerTickets = rnd.Next(10, 101);
                    inProgressTickets = rnd.Next(10, 101);
                    highPriority = rnd.Next(10, 101);
                    medPriority = rnd.Next(10, 101);
                    lowPriority = rnd.Next(10, 101);
                    break;
                default:
                    activeTickets = 0;
                    inactiveTickets = 0;
                    onHoldTickets = 0;
                    waitingForCustomerTickets = 0;
                    inProgressTickets = 0;
                    highPriority = 0;
                    medPriority = 0;
                    lowPriority = 0;
                    break;
            }
            for (int i = 0; i < 3; i++)
            {
                ((PieSeries)PriorityPie.Series[i]).Values.Clear();
            }
            for (int i = 0; i < 5; i++)
            {
                ((PieSeries)StatusPie.Series[i]).Values.Clear();
            }
            ((PieSeries)PriorityPie.Series[0]).Values.Add((double)highPriority);
            ((PieSeries)PriorityPie.Series[1]).Values.Add((double)medPriority);
            ((PieSeries)PriorityPie.Series[2]).Values.Add((double)lowPriority);
            ((PieSeries)StatusPie.Series[0]).Values.Add((double)activeTickets);
            ((PieSeries)StatusPie.Series[1]).Values.Add((double)inactiveTickets);
            ((PieSeries)StatusPie.Series[2]).Values.Add((double)onHoldTickets);
            ((PieSeries)StatusPie.Series[3]).Values.Add((double)waitingForCustomerTickets);
            ((PieSeries)StatusPie.Series[4]).Values.Add((double)inProgressTickets);
            PriorityPie.LegendLocation = LegendLocation.Bottom; // Set legend location
            StatusPie.LegendLocation = LegendLocation.Bottom;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
