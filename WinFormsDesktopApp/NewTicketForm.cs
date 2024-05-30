using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace WinFormsDesktopApp
{
    public partial class NewTicketForm : Form
    {
        private string title;
        private string description;
        private string category;
        private string contactEmail;
        private string priority;
        private Guid shipmentId;
        private Guid orderId;
        private Guid productId;
        private string dateCreated;
        private string status;

        public NewTicketForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Send HTTP request to create a new ticket
            // If successful, close the form
            // If not, display an error message

            // Create a new ticket
            title = ticketNameField.Text;
            description = ticketDescField.Text;
            category = categoryComboBox.Text;
            contactEmail = contactEmailField.Text;
            priority = priorityComboBox.Text;
            dateCreated = dateTimePicker.Value.ToString("yyyy-MM-dd");
            status = statusComboBox.Text;

            SendTicketPostRequest();


        }

        private async Task SendTicketPostRequest()
        {
            Console.WriteLine("Creating ticket...");

            string url = ClientInformation.ServerURL + "tickets/add/";

            HttpResponseMessage response;
            string responseBody;

            // Send HTTP POST Request with HTML Forms Enclosed
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "title", title },
                    { "description", description },
                    { "category", category },
                    { "email", contactEmail },
                    { "priority", priority },
                    { "shipmentid", shipmentId.ToString() },
                    { "orderid", orderId.ToString() },
                    { "productid", productId.ToString() },
                    { "date", dateCreated },
                    { "status", status }
                };

                var content = new FormUrlEncodedContent(values);
                response = await client.PostAsync(url, content);
                responseBody = await response.Content.ReadAsStringAsync();
            }

            Console.WriteLine(responseBody);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ticket created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateIdsButton_Click(object sender, EventArgs e)
        {
            NewTicketEditIDs editIdsForm = new NewTicketEditIDs();
            DialogResult result = editIdsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                shipmentId = editIdsForm.shipmentID;
                orderId = editIdsForm.orderID;
                productId = editIdsForm.productID;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
