using ClassTasj.Models;

namespace ClassTasj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Student student1 = new Student("Dostuyev Rauf");
                Console.WriteLine(student1);

                Student student2 = new Student("Ulvi Abdullazada");
                Console.WriteLine(student2);

                Student student3 = new Student("Sabir Guliyev");
                Console.WriteLine(student3);
            }

        }
    }
    
}
