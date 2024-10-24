using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask.Models
{
     public class Electronics : Product
        {
            public int warrenty { get; set; }
            public Electronics(int warrenty, string name, int id)
            {
                this.Id = id;
                this.Name = name;
                this.warrenty = warrenty;
                this.Type = ProductType.Electonics;
            }



            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"warrenty is :{warrenty}");
            }

        }
    
}
