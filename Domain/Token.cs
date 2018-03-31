using System;

namespace Popularity.Domain
{
    public class Token
    {
        public User Giver { get; set; }
        public User Recipient { get; set; }
        public DateTime GiveDate { get; set; }
        public int CreatedDate { get; set; }
    }
}
