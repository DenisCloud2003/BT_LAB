public class BTLAB
{
    public static void Main(string[] args)
    {
        //Bai 1
        int A, B;

        Console.WriteLine("Nhap so a: ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so b: ");
        B = Convert.ToInt32(Console.ReadLine());

        if (B == 0)
        {
            Console.WriteLine("Error: divide by zero.");
        }
        else
        {
            float C = (float) A / B;
            Console.WriteLine(C);
        }

        Console.WriteLine("--------------------------");

        //Bai 2
        int a, b, c;
        double x, x1, x2;

        Console.WriteLine("Nhap a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap c: ");
        c = Convert.ToInt32(Console.ReadLine());

        int delta = (b * b) - (4 * a * c);

        if (a == 0)
        {
            Console.WriteLine("a phai khac 0!");
        }
        else
        {
            if (delta > 0)
            {
                Console.WriteLine("Co 2 nghiem phan biet: ");
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1: " + x1);
                Console.WriteLine("x2: " + x2);
            }
            else if (delta == 0)
            {
                Console.WriteLine("Co nghiem kep: ");
                x = -b / (2 * a);
            }
            else Console.WriteLine("PT vo nghiem.");
        }
    }
}