namespace Ex8
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Nhap vao so tu nhien n: ");
      int n = Convert.ToInt32(Console.ReadLine());

      for (int i = 1; i <= n; i++)
      {
        Console.WriteLine(i);
      }

      Console.ReadLine();
    }
  }
}
