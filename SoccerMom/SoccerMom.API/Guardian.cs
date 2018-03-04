using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerMom.API
{
    /// <summary>
    /// Represents the Guardian of a Player
    /// </summary>
    class Guardian
    {
        private string fullName;

        /// <summary>
        /// Gets or Sets the FullName of a Guardian
        /// </summary>
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
    }
}
