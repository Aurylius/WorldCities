using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WorldCities.Data.Models
{
    public class Country
    {
        #region Constructor
        public Country()
        {
            // work...
        }
        #endregion

        #region
        /// <summary>
        /// Primary key
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ISO2 { get; set; }

        public string ISO3 { get; set; }
        #endregion

        #region Navigation Properties
        public virtual List<City> Cities { get; set; }
        #endregion
    }
}
