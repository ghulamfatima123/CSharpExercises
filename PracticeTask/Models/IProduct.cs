using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask.Models
{
    internal interface IProduct
    {
        decimal Price { get; set; }
        void DisplayInfo();
    }
}
