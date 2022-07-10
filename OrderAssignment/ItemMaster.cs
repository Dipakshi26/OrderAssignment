using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAssignment
{
    internal class ItemMaster
    {
        public static string sqlconnection = @"Data Source=DESKTOP-P3O2VMI\SQLEXPRESS;Initial Catalog=OrderDB;Integrated Security=True";
        public void Add()
        {
            Console.WriteLine("Enter the Item Name");
            string ItemName = Console.ReadLine();
            if (ItemName.Length == 0 || ItemName == null)
            {
                Console.WriteLine("Item name should not be Empty" + "\n" + "Please enter the Quantity");
                ItemName = Console.ReadLine();
            }
                Console.WriteLine("Enter the Price of a Item");
                int Price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Quantity of item");
                int Quantity = Convert.ToInt32(Console.ReadLine());

            #region 
            SqlConnection sqlConnection = new SqlConnection(sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter("Insert into ItemMaster values('" + ItemName + "'," + Price + ",'" + Quantity + "')", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            #endregion
        }
        public void update(string ItemName)
        {
            Console.WriteLine("Enter the Price of a Item");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of item");
            int Quantity = Convert.ToInt32(Console.ReadLine());

            #region 
            SqlConnection sqlConnection = new SqlConnection(sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter("update ItemMaster set Price=" + Price + ",Quantity='" + Quantity + "' where ItemName='" + ItemName + "'", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            #endregion
        }
        public void delete(string ItemName)
        {
            #region 
            SqlConnection sqlConnection = new SqlConnection(sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter("delete ItemMaster where Item='" + ItemName + "'", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            #endregion

        }
        public DataTable select()
        {
            #region 
            SqlConnection sqlConnection = new SqlConnection(sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter("select *from ItemMaster", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            #endregion
        }



    }
}
