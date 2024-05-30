using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopApp
{
    public class FullTicketObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Email { get; set; }
        public string Priority { get; set; }
        public Guid ShipmentId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }

        public Guid UUID { get; set; }

    }

    public class MiniTicketObject
    {
        public string Title { get; set; } = "New Ticket"; // Default value "New Ticket
        public string Description { get; set; } = "New Ticket";
        public string Category { get; set; } = "New Ticket";
        public string Priority { get; set; } = "New Ticket";
        public string Date { get; set; } = "New Ticket";
        public string Status { get; set; } = "New Ticket";
        public Guid UUID { get; set; }
    }
}
