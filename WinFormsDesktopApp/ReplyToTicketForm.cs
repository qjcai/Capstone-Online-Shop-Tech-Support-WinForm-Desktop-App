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
    public partial class ReplyToTicketForm : Form
    {
        private Guid ticketId;
        public ReplyToTicketForm(Guid ticketId)
        {
            InitializeComponent();
            this.ticketId = ticketId;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendReply();
        }

        async Task SendReply()
        {
            string endpoint = ClientInformation.ServerURL + "tickets/reply/";

            // Send HTTP POST request to reply to ticket
            // If successful, display a success message
            // If not, display an error message

            // Create a new ticket reply
            string reply = messageField.Text;

            // Create sender's name with first name and first letter of last name
            string sender = ClientInformation.FirstName + " " + ClientInformation.LastName[0];

            // Send HTTP POST request to reply to ticket
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
            {
                { "id", ticketId.ToString() },
                { "message", reply },
                { "sender", sender }
            };

            var content = new FormUrlEncodedContent(values);
            HttpResponseMessage response = await client.PostAsync(endpoint, content)    ;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Reply sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Failed to send reply.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
