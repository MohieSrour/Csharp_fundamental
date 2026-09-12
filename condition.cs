/*condion :
1.. if -else if -else 
2.. nasted condtion 
3.. (&&,||,!)
4.. short circut evalution 
5.. contional operator (?)
6.. swich 
*/
using System;
class Programm
{
    static void Main()
    {
        Condition condition = new Condition();
        condition.condition();
        Conditional conditional = new Conditional();
        conditional.conditional();
        Switch SW = new Switch();
        SW.print();
    }
}
// condition help the programm to take a dision 

class Condition
{
    int Age =20;
    bool Adult = true;
    public void condition()
    {
        if(Age >= 18 && Adult)
        {
            Console.WriteLine("is Adult");
        }
        else if (Age < 18 || !Adult)
        {
            Console.WriteLine("is child");
        }
        else
        {
            Console.WriteLine("un defined");
        }
    }
//How compiler take action with if-condition ?
//it path across every condition if done ,it carry out the order and brak program    
}
/* we use (&&,||,!) in the last method of condion ,but what is the Mean?
 (&&)---> it mean And 
 (||)---> it mean Or
 (!)---> it is negation
                           Short circut 
 in logical condition (&&,||) :
 in (||)--> if the first condition is true then the result is true
 in (&&)--> if the first condition is false then the result is false 
 */
//condional operator (?)....it summarize the if condition in one line 
class Conditional
{
    int Age=20;
    bool Adult = true;
    string Result;
    public void conditional()
    {
        /*if (Age >=18 && Adult)
        {
            Console.WriteLine("is Adult ");
        }
        else
        {
            Console.WriteLine("is child");
        }*/
        string Result = Age >= 18 ? "is Adult " : "is child ";
        Console.WriteLine(Result);
    }

        
}
// swich is used to compare one value with more of cases
class Switch
{
    int day=6;
    public void print()
    {
        switch (day)
        {
            case 1:
                Console.WriteLine("sat");
                break;
            case 2:
                Console.WriteLine("sunn");
                break;
            case 3:
                Console.WriteLine("Mon");
                break;
            case 4:
                Console.WriteLine("tues");
                break;
            case 5:
                Console.WriteLine("wedn");
                break;
            case 6:
                Console.WriteLine("trus");
                break;
            case 7:
                Console.WriteLine("fri");
                break;
            default:
                Console.WriteLine("Invalid day ");
                break;
        }
        

    }
}

