class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Cümləni daxil edin: ");
        string cumle = Console.ReadLine();

        
        BasHarfleriCapEt(cumle);
    }

   //
    static void BasHarfleriCapEt(string cumle)
    {

        class Program
    {
        static void Main(string[] args)
        {
            
            double daireSahesi = DaireSahesi(6);
            Console.WriteLine("Çevrənin sahəsi: " + daireSahesi);

            
            double duzbucaqliSahesi = DuzbucaqliSahesi(5, 10);
            Console.WriteLine("Düzbucaqlının sahəsi: " + duzbucaqliSahesi);

            
            double paralelpipedSahesi = ParalelpipedSahesi(6, 8, 10);
            Console.WriteLine("Düzbucaqlı paralelpipedin sahəsi: " + paralelpipedSahesi);

            
            double ucgenSahesi = UcgenDaxilindekiDaireSahesi(2, 4, 6);
            Console.WriteLine("Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi: " + ucgenSahesi);
        }

        
        static double DaireSahesi(double r)
        {
            const double pi = 3.14;
            return pi * r * r;
        }

        
        static double DuzbucaqliSahesi(double a, double b)
        {
            return a * b;
        }

        // Düzbucaqlı paralelpipedin tam səthinin sahəsini hesablamaq üçün metod
        static double ParalelpipedSahesi(double a, double b, double c)
        {
            return 2 * (a * b + a * c + b * c);
        }

        // Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsini hesablamaq üçün metod
        static double UcgenDaxilinde