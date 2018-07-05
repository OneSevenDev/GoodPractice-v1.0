using Practice01.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01.DAO
{
    class OrderDAO
    {
        #region Singleton
        private static readonly OrderDAO _instance = new OrderDAO();
        public static OrderDAO Instance {
            get { return OrderDAO._instance; }
        }
        #endregion Singleton

        #region Methods
        public List<Order> Order_ListAll()
        {
            SqlCommand command = null;
            SqlDataReader reader = null;
            List<Order> list = null;
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(); // add string connection
                command = new SqlCommand("new_sp_to_list", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                reader = command.ExecuteReader();
                list = new List<Order>();

                while (reader.Read())
                {
                    Order objOrder = new Order();
                    // Get columns
                    list.Add(objOrder);
                }
            }
            catch (Exception e) { throw e; }
            finally
            {
                command.Connection.Close();
                connection.Close();
            }

            return list;
        }
        #endregion Methods
    }
}
