namespace SkodaShop.Web.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class OrderViewModel
    {
        public int Id { get; set; }        

        public string ReceiverName { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}