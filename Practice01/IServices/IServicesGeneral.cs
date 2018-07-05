using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01.IServices
{
    interface IServicesGeneral<T>
    {
        List<T> List();
        Boolean Save(T objEntity);
        Boolean Update(T objEntity);
        T GetById(Int32 Id);
    }
}
