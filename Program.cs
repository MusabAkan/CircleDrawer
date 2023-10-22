class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Dairenin yarıçapını girin: ");
            int radius = int.Parse(Console.ReadLine());

            if (radius <= 0)
            {
                Console.WriteLine("Geçersiz yarıçap. Pozitif bir tamsayı girin.");
                return;
            }

            CircleDrawer.CircleDrawer.DrawCircle(radius);
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz giriş. Bir tamsayı girin.");
        }
    }
}
