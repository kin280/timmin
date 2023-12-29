internal class Program
{
    private static void Main(string[] args)
    {
    
            int[] arr = { 4, 12, 7, 8, 1, 6, 9 };
            
            Console.WriteLine("The smallest element in the array is: " + MinValue(arr));
     }

    static int MinValue(int[] array)
    {

        int min = array[0];
      

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
              
            }
        }

        return min;
    }







}