using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace MovieRentalStoreManager.BLL.Entities
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }

        public string Director { get; set; }

        public string MovieKind { get; set; }

        public string Description { get; set; }

        [Range(1, 360, ErrorMessage = "Movie must be between 1 to 260 minutes")]
        public int Duration { get; set; }

        public int AgeGroup { get; set; }

        [JsonIgnore]
        public virtual Rental Rentals { get; set; }

        public double RentalValue { get; set; }
    }
}
