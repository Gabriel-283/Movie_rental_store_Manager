using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalStoreManager.BLL.Entities
{
    public class Rental : BaseEntity
    {
        public int MovieId { get; set; }
        public int CustomerId { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime RentalDateStart { get; set; }
        public DateTime RentalForeseenDateEnd { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
