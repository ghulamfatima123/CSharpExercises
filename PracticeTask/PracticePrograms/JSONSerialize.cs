using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PracticeTask.PracticePrograms
{
    internal class JSONSerialize
    {
        public void SerializeData(Category category)
        {

            string json = JsonSerializer.Serialize(category);
            Console.WriteLine(json);
        }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
