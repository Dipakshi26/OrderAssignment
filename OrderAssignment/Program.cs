using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace OrderAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Welcome to Order Assignment*******");
            Console.WriteLine("Select any one Options:\n");
            Console.WriteLine("\t\tPress 1 for Item Master");
            Console.WriteLine("\t\tPress 2 for Customer Master");
            Console.WriteLine("\t\tPress 3 to Exit");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            switch (choice1)
            {


                case 1:

                Portal:

                    ItemMaster itemMaster = new ItemMaster();
                    Console.WriteLine("******Welcome to Item Portal*****");
                   // itemMaster.Add();
                    itemMaster.update("Apples");
                    //itemMaster.delete("Mangoes");
                    DataTable dataTable = itemMaster.select();
                    Console.WriteLine("Item" + "\t" + "Rate" + "\t" + "Quantity");
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            Console.Write(dataTable.Rows[i][j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;
            
            case 2:

                    CustomerMaster customerMaster = new CustomerMaster();

        portal1:

            Console.WriteLine("****Welcome to Customer Portal****");
            Console.WriteLine("Select any one Options :\n");
            Console.WriteLine("\t\tPress 1 to Insert New Customer.");
            Console.WriteLine("\t\tPress 2 to Update Customer.");
            Console.WriteLine("\t\tPress 3 to Delete Customer.");
            Console.WriteLine("\t\tPress 4 to all Customer Table data.");
            Console.WriteLine("\t\tPress 5 to Exit");
            int choice3 = Convert.ToInt32(Console.ReadLine());
            switch (choice3)
            {
                case 1:
                    customerMaster.AddCustomer();
                    goto portal1;

                    break;

                case 2:
                    customerMaster.UpdateCustomer();
                    goto Portal;


                    break;

                case 3:
                    customerMaster.DeleteCustomer();
                    goto portal1;

                    break;


                case 4:
                    customerMaster.ListAllCustomers();
                    goto portal1;
                    break;


                case 5:
                    break;
            }
            Console.ReadLine();
                    break;

                case 3:
                    break;

            }
        }
    }
}





