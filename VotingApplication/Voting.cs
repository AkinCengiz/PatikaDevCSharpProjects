using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace VotingApplication
{
    public class Voting
    {
        public int Id { get; set; }
        //public User VotingUser { get; set; }
        public Category VotingCategory { get; set; }
        public int VotAmount { get; set; }
    }
}
