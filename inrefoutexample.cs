using System.IO;
using System;

//https://www.pluralsight.com/guides/csharp-in-out-ref-parameters
//https://www.tutorialspoint.com/What-are-the-differences-between-ref-and-out-parameters-in-Chash

using System.IO;
using System;

//https://www.pluralsight.com/guides/csharp-in-out-ref-parameters
//https://www.tutorialspoint.com/What-are-the-differences-between-ref-and-out-parameters-in-Chash
public class Program {
	static void change(ref Coord cd){
    // Modifying possible, will also change param outside function
    cd.X=1; cd.Y=2;
   }
	
   static void update(out Coord cd){
    // value must be initialized before it could be used
    // (like it did not exist before)
    cd = new Coord();
    cd.X = 5;
   }
	
   static void rtrn(in Coord cd){
    // in was created for performance reasons
    // initializing variable will throw an error
    //cd = new Coord();
    //cd.X = 10;
	int x = cd.X;
   }
	
   public static void Main(string[] args) {
	 Program p1 = new Program();
     var cd = new Coord(){X=0, Y=0};
     change(ref cd);
     // cd is now (1,2)
     update(out cd);
     // cd is now (5, null)
	   
	 // print results
     Console.WriteLine("::{0} : {1}", cd.X, cd.Y); // Use $ for string interpolation
      
     // Another example of using out: 
     int x;
     Int32.TryParse("3", out x);
   }
	
	// public main is required in a public class? 
	class Coord { 
	  public int X {get;set;}
	  public int Y {get;set;}
	}
}
