using DMECommerce.Web.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMECommerce.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DMECommerceDataContext db = new DMECommerceDataContext();

            var totalBrands = db.REFBrand.Count();

            Console.WriteLine("Total Brands: "+ totalBrands);
            Console.WriteLine("Thanks to Mr SAMIR RHOUASSI");
            
            Console.ReadLine();

        }
    }
}
