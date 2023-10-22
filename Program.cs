class Program
{
    static void Main()
    {
        /*
           Kullanıcıdan alınan yarıçapa göre console'a Daire çizen uygulamayı yazınız.           
           Dikkat Edilmesi Gereken Noktalar :           
           Kod tekrarından kaçınılmalı
           Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.
         */

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
