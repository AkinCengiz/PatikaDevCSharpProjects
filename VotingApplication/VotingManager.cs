using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApplication
{
    public class VotingManager
    {
        public List<Voting> _votings;

        private CategoryManager categoryManager = new CategoryManager();
        public VotingManager()
        {
            _votings = new List<Voting>()
            {
                new Voting() { Id = 1, VotingCategory = categoryManager.GetCategory(1), VotAmount = 0 },
                new Voting() { Id = 2, VotingCategory = categoryManager.GetCategory(2), VotAmount = 0 },
                new Voting() { Id = 3, VotingCategory = categoryManager.GetCategory(3), VotAmount = 0 },
                new Voting() { Id = 4, VotingCategory = categoryManager.GetCategory(4), VotAmount = 0 },
                new Voting() { Id = 5, VotingCategory = categoryManager.GetCategory(5), VotAmount = 0 }
            };
        }

        public List<Voting> GetAll()
        {
            return _votings;
        }

        public void AddVot(Voting voting)
        {
            voting.VotAmount++;
        }

    }
}
