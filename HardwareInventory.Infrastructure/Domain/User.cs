using System;
using System.Collections.Generic;
using System.Text;

namespace HardwareInventory.Infrastructure.Domain
{
    public class User
    {
        public User() { }
        public int UserID { get; set; }
        public Guid UserKey { get; set; }
        public string UserName { get; set; }

    }
}
