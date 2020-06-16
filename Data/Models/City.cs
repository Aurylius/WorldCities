using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCities.Data.Models
{
    public class City
    {
        #region Constructor
        public City()
        {
            // work...
        }
        #endregion

        #region Properties
        /// <summary>
        /// Primary key for this entity
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Name_ASCII { get; set; }

        /// <summary>
        /// Latitude
        /// </summary>
        public decimal Lat { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        public decimal Lon { get; set; }        

        /// <summary>
        /// Foreign key
        /// </summary>        
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Country Country { get; set; }
        #endregion
    }
}
