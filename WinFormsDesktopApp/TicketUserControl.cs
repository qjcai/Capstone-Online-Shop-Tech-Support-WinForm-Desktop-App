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


    public partial class TicketUserControl : UserControl
    {
        private MiniTicketObject ticketObject;
        public TicketUserControl(MiniTicketObject ticketObject)
        {
            InitializeComponent();

            this.ticketObject = ticketObject;

            ticketNameLabel.Text = ticketObject.Title;
            ticketDescLabel.Text = ticketObject.Description;
            ticketMiscLabel.Text = ticketObject.Category;
            //ticketPriorityLabel.Text = ticketObject.Priority;
            //ticketPriorityLabel.ForeColor = ticketObject.Priority == "High" ? Color.Red : ticketObject.Priority == "Medium" ? Color.Gold : Color.Blue;
        }

        private void ShowTicket()
        {
            ViewTicketForm viewTicketForm = new ViewTicketForm(ticketObject.UUID);
            viewTicketForm.ShowDialog();
        }

        private void ticketNameLabel_Click(object sender, EventArgs e)
        {
            ShowTicket();
        }
    }
}
