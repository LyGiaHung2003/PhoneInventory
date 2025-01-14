﻿namespace PhoneWarehouse.Models
{
    public class User : IModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string  Gender { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
    }
}
