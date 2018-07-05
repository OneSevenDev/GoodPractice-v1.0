using Practice01.DAO;
using Practice01.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01.BL
{
    class OrderBL
    {
        #region Singleton
        private static readonly OrderBL _instance = new OrderBL();
        public static OrderBL Instance {
            get { return OrderBL._instance; }
        }
        #endregion Singleton

        public List<Order> ListAll()
        {
            return OrderDAO.Instance.Order_ListAll();
        }
    }
}
