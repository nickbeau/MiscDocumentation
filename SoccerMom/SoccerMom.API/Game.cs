using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoccerMom.API
{
    /// <summary>
    /// Represents a Game
    /// </summary>
    public class Game
    {
        private string address;
        private DateTime date;
        private string field;

        /// <summary>
        /// Gets or Sets the field that the game will be held in
        /// </summary>
        public string Field
        {
            get { return field; }
            set { field = value; }
        }

        /// <summary>
        /// gets or sets the date and time of the game
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Gets or Sets the Physical Address of the Game
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

    }
}
