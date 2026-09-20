using System;
using System.Net.Cache;
using System.Runtime.InteropServices;
/*
              Array 
..what is the Array
..why Array
..Declaration 
..initialization
..index_(Zero Dased Index)
..Elenment
..Display Array by using (for,foreach)
                      what&why is the Array:
we last study variables but,when there are Large numbers of variables it is problem like
      int age1=30;
      int age2=37;
      int age3=21;
  we summarize that in Array like:
int []ages={30,37,21}
then, Array is some of elements have the same Data Type

 */
class Program
{
    static void Main()
    {
        Array array = new Array();
        array.Aray();
        array.Print1();
        array.Print2();

    }
}
class Array
{
    int[] Ages = new int[4];  //4 is number of elements in Array 
    int[] Ages2 = { 10, 20, 30, 40, 50 };
    public void Aray()
    {
        // we have 2Arrays (Ages,Ages2)
        Console.WriteLine(Ages[2]);   //print the third  element 
        // it print "0" it is default
        Console.WriteLine(Ages2[2]);
        //         Zero based indexing 
        // in Array index number start from (0)
    }
    //                  print All elements in Array by using two method 
    public void Print1()
    {
        
        for (int i =0; i < Ages.Length; i++)
        {
            Console.WriteLine(Ages[i]);
        }
    }
    public void Print2()
    {
        foreach (int Age in Ages2 )
        {
            Console.WriteLine(Age);
        }
    }
}
 
