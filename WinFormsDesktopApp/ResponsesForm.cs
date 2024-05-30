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
    public partial class ResponsesForm : Form
    {
        private Guid ticketId;
        public ResponsesForm(Guid ticketId)
        {
            InitializeComponent();
            this.ticketId = ticketId;

            FetchResponses();
        }

        async Task FetchResponses()
        {
            // Fetch responses for the ticket with the given ticketId
            // Display the responses in the form
            // Use bold for names and regular text for messages

            string endpoint = ClientInformation.ServerURL + "tickets/get/responses/?id=" + ticketId;

            // Send HTTP request to get ticket responses
            HttpClient client = new HttpClient();
            HttpResponseMessage webResponse = await client.GetAsync(endpoint);
            string responseBody = await webResponse.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(responseBody))
            {
                MessageBox.Show("Failed to download ticket responses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse JSON response with Newtonsoft.Json
            List<Dictionary<string,string>> responses = JsonConvert.DeserializeObject<List<Dictionary<string,string>>>(responseBody);

            if (responses == null)
            {
                MessageBox.Show("Failed to parse ticket responses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Display ticket responses
            foreach (var response in responses)
            {
                string sender = response["sender"];
                string message = response["message"];

                // Use bold for sender's name
                richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
                richTextBox.AppendText(sender + ": ");
                richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular);
                richTextBox.AppendText(message + Environment.NewLine);
            }
        }
    }
}
