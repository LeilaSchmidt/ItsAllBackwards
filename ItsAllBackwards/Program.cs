namespace ItsAllBackwards
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a word");
            string userWord = Console.ReadLine();
            int length = userWord.Length - 1;
            char[] arr = new char[length];
            
            FibonaciCalculations(arr, 0, length-1);

            Console.WriteLine(string.Join(',', arr));
        }

       
        static char[] FibonaciCalculations(char[] arr, int start, int end)
        {
            while (start != end)
            {
                char temp = arr[end];
                arr[end] = arr[start];
                arr[start] = temp;

                FibonaciCalculations(arr, start + 1, end - 1);


            }
            return arr;
        }
    }
}
