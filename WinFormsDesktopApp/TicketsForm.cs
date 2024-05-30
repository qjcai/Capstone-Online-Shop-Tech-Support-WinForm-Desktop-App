using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsDesktopApp
{
    public partial class TicketsForm : Form
    {
        private List<MiniTicketObject> tickets = new List<MiniTicketObject>();

        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            PullTickets();
        }

        private void newTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTicketForm newTicketForm = new NewTicketForm();
            newTicketForm.ShowDialog();
        }

        private async Task PullTickets()
        {
            ticketsLayoutPanel.Controls.Clear();

            string url = ClientInformation.ServerURL + "tickets/list/";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine("Response:" + responseBody);


            if (string.IsNullOrWhiteSpace(responseBody))
            {
                MessageBox.Show("Failed to download tickets.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine("Response body: " + responseBody);

            // Parse JSON response with Newtonsoft.Json
            tickets = JsonConvert.DeserializeObject<List<MiniTicketObject>>(responseBody);

            DisplayTickets();
        }

        private void DisplayTickets()
        {
            foreach (MiniTicketObject ticket in tickets)
            {
                TicketUserControl ticketUserControl = new TicketUserControl(ticket);
                ticketsLayoutPanel.Controls.Add(ticketUserControl);

                // Force control to match parent width
                ticketUserControl.Width = ticketsLayoutPanel.Width;
            }
        }

        private void refreshTicketsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PullTickets();
        }
    }
}
