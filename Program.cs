namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {


            int sonuc =Topla(7,3);
            Console.WriteLine(sonuc);
            Console.ReadLine();

        }

        static public int Topla(int sayi1, int sayi2)
        {
            double sonuc = Bol(45, 13);
            return sayi1 + sayi2;
        }

         static public double Bol(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }

    }
}