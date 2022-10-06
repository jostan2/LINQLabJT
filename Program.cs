using System.Diagnostics.Tracing;
using System.Linq;

namespace LINQLabJT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For nums:");
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            int minimumNums = nums.Min(); //Find minimum value in list
            Console.WriteLine("The minimum value is: {0}", minimumNums);
            Console.WriteLine();

            int maxNums = nums.Max(); //find the maximum value
            Console.WriteLine("The maximum value is: {0}", maxNums);
            Console.WriteLine();

            int maxThanNums = nums.Where(num => num < 10000).Max(); //max value < 10000
            Console.WriteLine("The maximum value that is less than 10,000 is: {0}", maxThanNums);
            Console.WriteLine();

            List<int> betweenNums = nums.Where(num => num > 10 && num < 100).ToList(); // 10 < values < 100
            Console.WriteLine("The numbers inbetween 10 and 100 are:");
            PrintList(betweenNums); //should be none?
            Console.WriteLine();

            List<int> inclusiveNums = nums.Where(num => num >= 10000 && num <= 999999).ToList(); // 1000 <= values <= 999999 (inclusive)
            Console.WriteLine("The numbers inbetween 10000 and 999999 are:");
            PrintList(inclusiveNums);
            Console.WriteLine();

            List<int> evenNums = nums.Where(num => num % 2 == 0).ToList(); //all even numbers
            Console.WriteLine("The even values are:");
            PrintList(evenNums);
            Console.WriteLine();

            //order numbers from greatest to least (in decending order, from greatest to least)
            //Array.Sort(nums); //will give ascending order
            nums = nums.OrderByDescending(n => n).ToArray();
            Console.WriteLine();
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();


            Console.WriteLine("For Students:");
            Console.WriteLine();

            List<Student> students = new List<Student>(); //creating new list using Student.cs and below values.
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            List<Student> drinkingAge = students.Where(s => s.Age > 20).ToList();
            Console.WriteLine("Students who are 21 years old and above:");
            printStudents(drinkingAge);
            Console.WriteLine();

            int oldestAge = students.Max(s => s.Age); //Find oldest student
            Student oldestName = students.Where(s => s.Age == oldestAge).First();
            Console.WriteLine($"The student with the oldest age: {oldestName.Name}, {oldestAge}");
            Console.WriteLine();

            int youngestAge = students.Min(s => s.Age); //Find youngest student
            Student youngestName = students.Where(s => s.Age == youngestAge).First();
            Console.WriteLine($"The student with the oldest age: {youngestName.Name}, {youngestAge}");
            Console.WriteLine();

            List<Student> underTF = students.Where(s => s.Age < 25).ToList(); //Finding oldest student <25 yr
            int underTFOldest = underTF.Max(s => s.Age);
            Student oldUnderTF = students.Where(s => s.Age == underTFOldest).First();
            Console.WriteLine($"The oldest student under 25 is {oldUnderTF.Name}, {oldUnderTF.Age}");
            Console.WriteLine();

            List<Student> ageEven = students.Where(s => s.Age % 2 == 0).ToList(); //everybody with even number
            List<Student> overTOEven = ageEven.Where(s => s.Age > 21).ToList();
            Console.WriteLine("The students who are over 21 and have even ages are:");
            printStudents(overTOEven);
            Console.WriteLine();

            List<Student> teenAge = students.Where(s => s.Age > 12 && s.Age < 20).ToList(); //find all students ages 13-19
            Console.WriteLine("The students who are teenagers (ages 13-19) are:");
            printStudents(teenAge);
            Console.WriteLine();

            //7) vowel -- see piglatin vowel list
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            IEnumerable<Student> vowelNames = students.Where(s => s.Name[0] == 'a' || s.Name[0] == 'e' || s.Name[0] == 'i' || s.Name[0] == 'o' || s.Name[0] == 'u' || s.Name[0] == 'A' || s.Name[0] == 'E' || s.Name[0] == 'I' || s.Name[0] == 'O' || s.Name[0] == 'U');
            List<Student> vowelStudents = vowelNames.OrderBy(s => s.Name).ToList();

            Console.WriteLine("The students' names listed by vowel are:");
            printStudents(vowelStudents);
            Console.WriteLine();

            List<Student> sort = students.OrderBy(s => s.Age).ToList(); //list students by ages in ascending order.
            Console.WriteLine("The students sorted by age in ascending order are:");
            printStudents(sort);
            Console.WriteLine();

        }

        public static void PrintList(List<int> input) //function to print list
        {
            for (int i = 0; i < input.Count; i++)
            {
                int num = input[i];
                Console.WriteLine($"{i}: {num}");
            }
        }

        public static void printStudents(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Student s = students[i];
                Console.WriteLine($" {s.Name}, {s.Age}");
            }
        }
    }
}