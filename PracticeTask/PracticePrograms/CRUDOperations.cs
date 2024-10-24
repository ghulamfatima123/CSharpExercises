using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask.PracticePrograms
{
    /// <summary>
    /// ************STATIC CRUD OPERATION WITH DICTIONARY****************
    /// </summary>
    internal class CRUDOperations
    {
        static Dictionary<int, Dictionary<string, string>> books = new Dictionary<int, Dictionary<string, string>>();

        public static void Add()
        {
            Console.Write("Enter Book ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Book Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Book Author: ");
            string author = Console.ReadLine();

            books[id] = new Dictionary<string, string>
            {
                {"name", name },
                {"author", author}
            };
        }
        public static void Get()
        {
            Console.WriteLine("Books are : ");
            foreach (var book in books)
            {
                Console.WriteLine($"ID : {book.Key}, name :{book.Value["name"]}, author:{book.Value["author"]}");
            }
        }
        public static void GetById(int id)
        {
            Console.WriteLine("enter an id:");
            if (books.ContainsKey(id))
            {
                Console.WriteLine($"id : {id}, name:{books[id]["name"]}, author:{books[id]["author"]}");
            }
            else
            {
                Console.WriteLine("book not found");
            }

        }
        public static void update(int id)
        {
            if (books.ContainsKey(id))
            {
                Console.Write("Enter new name");
                string newName = Console.ReadLine();
                Console.Write("Enter new author ");
                string newAuthor = Console.ReadLine();

                books[id]["name"] = newName;
                books[id]["author"] = newAuthor;
            }
        }
        public static void delete(int id)
        {
            if (books.ContainsKey(id))
            {
                books.Remove(id);
            }
            else
            {
                Console.WriteLine("book id not found");
            }
        }

    }

}
