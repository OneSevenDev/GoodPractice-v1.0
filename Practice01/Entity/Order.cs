using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01.Entity
{
    class Order : BaseEntity
    {
        public Int64 LegacyNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int32 DistibutorId { get; set; }
        public Decimal OrderTotal { get; set; }

        public Order(Int64 legacyNumber, DateTime createdDate, Int32 distributorId)
        {
            this.LegacyNumber = legacyNumber;
            this.CreatedDate = createdDate;
            this.DistibutorId = distributorId;
        }

        public Order()
        {

        }
    }
}
