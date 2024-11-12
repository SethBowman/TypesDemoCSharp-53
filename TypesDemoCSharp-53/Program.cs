namespace TypesDemoCSharp_53;

class Program
{
    static void Main(string[] args)
    {
        // this is comment
        
        // variables
        
        // type - name - value
        
        // variables are camel case - sethsName
        
        // word types

        string sethsName = "Seth";

        char sethsMiddleInitial = 'S';

        // number types
        
        int sethsAge = 30;
        
        double sethsHeight = 5.8;
        
        decimal myAccountBalance = 1000.00m;
        
        // fact type

        bool isCoding = true;
        
        // value and reference types
        
        // value types

        int a = 5;
        int b = a;

        a = 10;

        Console.WriteLine(a);
        Console.WriteLine(b);
        
        // reference types
        
        Point p1 = new Point();

        p1.X = 5;

        Point p2 = p1;

        p2.X = 10;

        Console.WriteLine(p1.X);
        Console.WriteLine(p2.X);

        int? number = null;
    }
}