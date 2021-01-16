using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a certified Instructor
    /// </summary>
    class Instructor
    {
        #region Properties
        /// <summary>
        /// Legal full name. First and Last
        /// , Example: Jane Doe
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Company Email Address
        /// , Example: Jane.Doe@cptc.edu
        /// </summary>
        public string Email { get; set; }
        #endregion
    }
}
