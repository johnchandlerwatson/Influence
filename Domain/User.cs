using System.Collections.Generic;

namespace Popularity.Domain
{
    public class User 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Influence { get; set; }
        public List<Token> Tokens { get; set; }
    }
}
