using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic2;
namespace bank_DatabaseADO
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            BusinessLogic BL = new BusinessLogic();
            while (choice != 6)
            {
                Console.WriteLine("enter your choice : \n\n 1: All Customer Details \n 2:Add Customer \n 3:Search by ID \n 4:Deposit \n 5: Withdraw\n 6: Exit \n\n");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                    BL.Fetch();
                else if (choice == 2)
                    BL.Add();
                else if (choice == 3)
                    BL.Calling_Search();
                else if (choice == 4)
                    BL.Deposit();
                else if (choice == 5)
                    BL.Withdraw();
                else if (choice == 6)
                    break;
                else
                    Console.WriteLine("invalid entry!");
            }
        }
    }
}
