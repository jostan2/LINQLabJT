namespace LINQLabJT
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        public static void PrintList(List<int> input) //function to print list
        {
            for (int i = 0; i < input.Count; i++)
            {
                int num = input[i];
                Console.WriteLine($"{i}: {num}");
            }
        }

        public static void PrintListString(List<string> input) //function to print list
        {
            for (int i = 0; i < input.Count; i++)
            {
                string s = input[i];
                Console.WriteLine($"{i}: {s}");
            }
        }
    }
}