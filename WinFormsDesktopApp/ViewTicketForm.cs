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

namespace WinFormsDesktopApp
{
    public partial class ViewTicketForm : Form
    {
        private Guid ticketId;
        private FullTicketObject ticket;
        public ViewTicketForm(Guid ticketId)
        {
            InitializeComponent();

            this.ticketId = ticketId;

            GrabTicket(ticketId);
        }

        async Task GrabTicket(Guid ticketId)
        {
            // Send HTTP request to get ticket data
            // If successful, display ticket data
            // If not, display an error message

            string endpoint = ClientInformation.ServerURL + "tickets/get/?id=" + ticketId;

            // Send HTTP request to get ticket data

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(endpoint);
            string responseBody = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(responseBody))
            {
                MessageBox.Show("Failed to download ticket data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse JSON response with Newtonsoft.Json
            ticket = JsonConvert.DeserializeObject<FullTicketObject>(responseBody);
            if (ticket == null)
            {
                MessageBox.Show("Failed to parse ticket data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Display ticket data
            ticketNameField.Text = ticket.Title;
            ticketDescField.Text = ticket.Description;
            categoryComboBox.Text = ticket.Category;
            contactEmailField.Text = ticket.Email;
            priorityComboBox.Text = ticket.Priority;
            shipmentIdField.Text = ticket.ShipmentId.ToString();
            orderIdField.Text = ticket.OrderId.ToString();
            productIdField.Text = ticket.ProductId.ToString();
            dateTimePicker.Value = DateTime.Parse(ticket.Date);
            statusComboBox.Text = ticket.Status;
        }

        async Task UpdateTicket()
        {
            // Create dictionary with updated ticket data
            Dictionary<string, string> updatedTicket = new Dictionary<string, string>
            {
                { "id", ticketId.ToString() },
                { "title", ticketNameField.Text },
                { "description", ticketDescField.Text },
                { "category", categoryComboBox.Text },
                { "email", contactEmailField.Text },
                { "priority", priorityComboBox.Text },
                { "shipmentId", shipmentIdField.Text },
                { "orderId", orderIdField.Text },
                { "productId", productIdField.Text },
                { "date", dateTimePicker.Value.ToString("yyyy-MM-dd")},
                { "status", statusComboBox.Text }
            };

            // Remove keys with values that match the original ticket data
            // This is to prevent the server from updating unchanged fields
            RemoveNonUpdatedValues(updatedTicket);

            Dictionary<string, string> dataToSend = new Dictionary<string, string>();
            dataToSend.Add("id", ticketId.ToString());
            dataToSend.Add("data", JsonConvert.SerializeObject(updatedTicket));

            // Send HTTP request to update ticket data
            // If successful, display success message
            // If not, display an error message

            string endpoint = ClientInformation.ServerURL + "tickets/update/";

            // Send HTTP POST request as FORM URL ENCODED CONTENT
            HttpClient client = new HttpClient();
            var content = new FormUrlEncodedContent(dataToSend);
            HttpResponseMessage response = await client.PostAsync(endpoint, content);
            string responseBody = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ticket updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveNonUpdatedValues(Dictionary<string, string> updatedTicket)
        {
            if (ticketNameField.Text == ticket.Title)
            {
                updatedTicket.Remove("title");
            }
            if (ticketDescField.Text == ticket.Description)
            {
                updatedTicket.Remove("description");
            }
            if (categoryComboBox.Text == ticket.Category)
            {
                updatedTicket.Remove("category");
            }
            if (contactEmailField.Text == ticket.Email)
            {
                updatedTicket.Remove("email");
            }
            if (priorityComboBox.Text == ticket.Priority)
            {
                updatedTicket.Remove("priority");
            }
            if (shipmentIdField.Text == ticket.ShipmentId.ToString())
            {
                updatedTicket.Remove("shipmentId");
            }
            if (orderIdField.Text == ticket.OrderId.ToString())
            {
                updatedTicket.Remove("orderId");
            }
            if (productIdField.Text == ticket.ProductId.ToString())
            {
                updatedTicket.Remove("productId");
            }
            if (dateTimePicker.Text == ticket.Date)
            {
                updatedTicket.Remove("date");
            }
            if (statusComboBox.Text == ticket.Status)
            {
                updatedTicket.Remove("status");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void fileSaveMenuButton_Click(object sender, EventArgs e)
        {
            UpdateTicket();
        }

        private void fileExitMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void replyAddMenuButton_Click(object sender, EventArgs e)
        {
            ReplyToTicketForm replyToTicketForm = new ReplyToTicketForm(ticketId);
            replyToTicketForm.ShowDialog();
        }

        private void replyViewMenuButton_Click(object sender, EventArgs e)
        {
            ResponsesForm responsesForm = new ResponsesForm(ticketId);
            responsesForm.ShowDialog();
        }

        private void fileDeleteMenuButton_Click(object sender, EventArgs e)
        {
            // Prompt user to confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this ticket?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteTicket();
            }
        }

        private async Task DeleteTicket()
        {
            // Send HTTP request to delete ticket
            // If successful, display success message
            // If not, display an error message

            string endpoint = ClientInformation.ServerURL + "tickets/delete/";
            
            // Send HTTP POST request to delete ticket
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
            {
                { "id", ticketId.ToString() }
            };

            var content = new FormUrlEncodedContent(values);
            HttpResponseMessage response = await client.PostAsync(endpoint, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ticket deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Failed to delete ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
