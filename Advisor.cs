using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual college advisor
    /// </summary>
    public class Advisor
    {
        /// <summary>
        /// Legal first and legal last names
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Assigned work email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Building and room number of work office
        /// </summary>
        public string OfficeLocation { get; set; }
    }
}
