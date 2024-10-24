using PracticeTask.PracticePrograms;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            //Password Checker
            PasswordChecker checker = new PasswordChecker();
            checker.CheckPasswordStrength();

            // CRUD operations
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- Book Management ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Get Book by ID");
                Console.WriteLine("4. Update Book");
                Console.WriteLine("5. Delete Book");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CRUDOperations.Add();
                        break;
                    case "2":
                        CRUDOperations.Get();
                        break;
                    case "3":
                        Console.WriteLine("Enter the book ID:");
                        int id = int.Parse(Console.ReadLine());
                        CRUDOperations.GetById(id);
                        break;
                    case "4":
                        Console.WriteLine("Enter the book ID to update:");
                        int updateId = int.Parse(Console.ReadLine());
                        CRUDOperations.update(updateId);
                        break;
                    case "5":
                        Console.WriteLine("Enter the book ID to delete:");
                        int deleteId = int.Parse(Console.ReadLine());
                        CRUDOperations.delete(deleteId);
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        
            //json data serializer 
           JSONSerialize jSONSerialize = new JSONSerialize();
            var category = new Category
            {
                Id = 1,
                Name = "Electronics",
                Description = "Devices and gadgets."
            };
            jSONSerialize.SerializeData(category);
        
        
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input format.");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("ALL TASK COMPLETED ");
        }
    }
}
