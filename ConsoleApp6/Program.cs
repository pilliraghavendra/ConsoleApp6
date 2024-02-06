using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer;
namespace ConsoleApp6
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.Address.State = "TG";
            //employee.Address.zipCode = "509210";

            //Console.WriteLine(employee.Address.State);
            //Console.WriteLine(employee.Address.zipCode);

            ProductBl productBl= new ProductBl();

            List<Product> result = productBl.GetListForDb();

            foreach (Product p in result)
            {
                Console.WriteLine(p.Name + " " +p.Description + " " +p.Category + " " +p.Prize);
            }

            Console.ReadLine();
        }
    }
}
