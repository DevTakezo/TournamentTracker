using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// Represents one team in matchup.///
        public TeamModel TeamCompeting { get; set; }

        /// Represents score of this team. ///
        public double Score { get; set; }

        /// Represents the matchup that this team came from as the winner.///

        public MatchupModel ParentMatchup { get; set; }
    }
}
