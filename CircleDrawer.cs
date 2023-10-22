namespace CircleDrawer
{
    class CircleDrawer
    {
        public static void DrawCircle(int radius)
        {
            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    if (x * x + y * y <= radius * radius)
                        Console.Write("* ");
                    else
                        Console.Write(string.Empty); // Boşluk karakteri
                }
                Console.WriteLine();
            }
        }
    }
}
