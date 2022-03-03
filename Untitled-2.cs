/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(string[] args) {
     string ad;  
    Console.Write("Bir ay adi gir : ");  
    ad=Console.ReadLine();  
    
    if (ad=="sentyabr")  
        Console.Write(ad+" 30 gundur");  
    else if (ad=="oktyabr")  
        Console.Write(ad+" 30 gundur");  
    else if (ad=="noyabr 30 gundur")  
        Console.Write(ad+" Mevsimindeki aylar Eylül Ekim Kasım");  
    else if (ad=="dekabr")  
        Console.Write(ad+"31 gundur");
    else if (ad=="yanvar")  
        Console.Write(ad+"31 gundur");
    else if (ad=="fevral")  
        Console.Write(ad+"28 gundur");
    else if (ad=="mart")  
        Console.Write(ad+"31 gundur");
    else if (ad=="aprel")  
        Console.Write(ad+"30 gundur");
    else if (ad=="may")  
        Console.Write(ad+"31 gundur");
    else if (ad=="iyun")  
        Console.Write(ad+"30 gundur");
    else if (ad=="iyul")  
        Console.Write(ad+"31 gundur");
    else if (ad=="avqust")  
        Console.Write(ad+"31 gundur");
    else  
        Console.Write("Ya sehv sey daxil etmisen. yadaki her hansisa herfi boyukle yazmisan, yazma brat");  
  
    Console.ReadLine(); 
  }
}