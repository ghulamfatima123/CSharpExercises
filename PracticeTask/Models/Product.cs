using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticeTask.ShoppingCart;
namespace PracticeTask.Models
{
    
    public class Product : IProduct
    {
        public enum ProductType
        {
            Electonics,
            Accessories,
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public ProductType Type { get; set; }

        /// <summary>
        // ******AS WE HAVE TO IMPLEMENT INTERFACE WHICH IS Price AND DisplayInfo()*******
        /// </summary>

        public decimal Price { get ; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product id is {Id} name is {Name} and type is {Type}");
        }

       


    }
}
