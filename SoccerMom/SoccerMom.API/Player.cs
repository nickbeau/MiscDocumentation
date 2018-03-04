using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SoccerMom.API
{
    /// <summary>
    /// Represents a Player
    /// </summary>
    class Player
    {
        private string fullName;
        private string playerNumber;
        private string playerAlias;
        private Guardian primaryCarer;
        private Collection<Guardian> guardians;
        private TimeSpan durationPlayed;

        
        private TimeSpan durationOff;
        private TimeSpan durationInGoal;

        /// <summary>
        /// Gets or Sets the Duration Played
        /// </summary>
        public TimeSpan DurationPlayed
        {
            get { return durationPlayed; }
            set { durationPlayed = value; }
        }

        /// <summary>
        /// Gets or Sets the collection of Guardians this player had
        /// </summary>
        internal Collection<Guardian> Guardians
        {
            get { return guardians; }
            set { guardians = value; }
        }
        /// <summary>
        /// Gets or Sets the primary Carer of the Player
        /// </summary>
        internal Guardian PrimaryCarer
        {
            get { return primaryCarer; }
            set { primaryCarer = value; }
        }

        /// <summary>
        /// Gets or sets the Alias or NickName of the Player
        /// </summary>
        public string PlayerAlias
        {
            get { return playerAlias; }
            set { playerAlias = value; }
        }

        /// <summary>
        /// Gets or Sets the Shirt Number of the Player
        /// </summary>
        public string PlayerNumber
        {
            get { return playerNumber; }
            set { playerNumber = value; }
        }

        /// <summary>
        /// Gets or Sets the full Name of the Player
        /// </summary>
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
    }
}
