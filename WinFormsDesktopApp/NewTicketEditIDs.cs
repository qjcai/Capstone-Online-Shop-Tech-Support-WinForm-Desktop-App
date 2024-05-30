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
    public partial class NewTicketEditIDs : Form
    {
        public Guid productID { get; set; }  
        public Guid orderID { get; set; }
        public Guid shipmentID { get; set; }

        public NewTicketEditIDs()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Check if all fields are valid as UUIDs
            if (!Guid.TryParse(productIdField.Text, out var productGuid))
            {
                MessageBox.Show("Product ID is not a valid UUID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Guid.TryParse(orderIdField.Text, out var orderIdGuid))
            {
                MessageBox.Show("Order ID is not a valid UUID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Guid.TryParse(shipmentIdField.Text, out var shipmentIdGuid))
            {
                MessageBox.Show("Shipment ID is not a valid UUID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            productID = productGuid;
            orderID = orderIdGuid;
            shipmentID = shipmentIdGuid;

            // Return OK result
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
