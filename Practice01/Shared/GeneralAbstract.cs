using Practice01.Entity;
using Practice01.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01.Shared
{
    abstract class GeneralAbstract<T> : IServicesGeneral<T>
    {
        public virtual T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> List()
        {
            throw new NotImplementedException();
        }

        public virtual bool Save(T objEntity)
        {
            throw new NotImplementedException();
        }

        public virtual bool Update(T objEntity)
        {
            throw new NotImplementedException();
        }
    }
}
