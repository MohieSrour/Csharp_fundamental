using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("programm is started");
        Arthimetic.Print();
        Assignment AS = new Assignment();
        AS.print_As();
        Compresion co = new Compresion();
        co.print_comp();
        Logical lo  = new Logical();
        lo.print_lo();


    }
}
/*                                operators 
               it is code use to tell compiler to do specific operate 
                    like:  (+)------>that tell compiler to add variables
note the diffrenate:
 operator----->(+),(-)..
 operaned ----->the variable or value like (x,y ) in (x+y)
 statment ------->(int result =x+y)
 expresion ------->(x+y)
 */
public  class Arthimetic
{
   
    public static void Print()
    {
        int x = 10;
        int y = 20;
        double x1 = 10;
        double y1 = 20;
        Console.WriteLine(x + y);
        Console.WriteLine(x1 + y1);
        Console.WriteLine(x - y);
        Console.WriteLine(x / y);
        Console.WriteLine(x * y);
        Console.WriteLine(x % y);
    }

}  
public class Assignment
{
    //assignment operator (=,+=,-=,*=,/=,%=)
    int Ass = 20;
    public void print_As()
    {
        Ass = 30;  // Assignment Ass---->30
        Ass += 3;  //Ass=Ass+3
        Ass = Ass + 3;
        Console.WriteLine(Ass);
        Ass -=3;  //Ass=Ass-3
        Ass = Ass -3;
        Console.WriteLine(Ass);
        Ass *= 3; //Ass=Ass*3
        Console.WriteLine(Ass);
    }
}
// compersion use to compare between two or more values 
class Compresion
{
    int comp = 12;
    public void print_comp()
    {
        Console.WriteLine(comp == 5);
        Console.WriteLine(comp != 5);
        Console.WriteLine(comp > 5);
        Console.WriteLine(comp < 5);
        Console.WriteLine(comp <= 5);
        Console.WriteLine(comp >= 5);
    }
}
// compersion use one condition but when two or more conditions we use Logical
class Logical
{
    int comp1 = 12;

    bool comp2 = true;
    public void print_lo()
    {
        Console.WriteLine(comp1 == 12 && comp2==true);
        Console.WriteLine(comp1 == 12 || comp2 == true);
        Console.WriteLine(!comp2 );

    }
}