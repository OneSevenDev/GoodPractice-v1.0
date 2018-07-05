using Practice01.Entity;
using Practice01.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01.Services
{
    class OrderServices : GeneralAbstract<Order>
    {
        public override Order GetById(int Id)
        {
            return base.GetById(Id);
        }

        public override List<Order> List()
        {
            return base.List();
        }

        public override bool Save(Order objEntity)
        {
            return base.Save(objEntity);
        }

        public override bool Update(Order objEntity)
        {
            return base.Update(objEntity);
        }
    }
}
