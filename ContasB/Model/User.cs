using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasB.Model
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string agency { get; set; }
        public required string account { get; set; }



        public List<Account> Accounts { get; set; } = new List<Account>();
    }
}
