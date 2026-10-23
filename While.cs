namespace Ex9
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Nhap vao so tu nhien n!");
      int n = Convert.ToInt32(Console.ReadLine());
      int i = 1;

      while (i <= n)
      {
        Console.WriteLine(i);
        i++;
      }
      Console.ReadLine();
    }
  }
}
