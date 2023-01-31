namespace ItsAllBackwards
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a word");
            string userWord = Console.ReadLine();
            int length = userWord.Length;
            char[] arr = userWord.ToCharArray();

            char[] result = ReverseString(arr, 0, length - 1);

            Console.WriteLine(new string(result));
        }


        static char[] ReverseString(char[] arr, int start, int end)
        {
            if (start >= end)
            {
                return arr;
            }
            else
            {
                char temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                ReverseString(arr, start + 1, end - 1);
                return arr;
            }
        }
    }
}
