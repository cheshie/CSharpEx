using System;

// Delegate method is like a virtual method in a sense it might 
// take any shape that is determined by method passed to its constructor as an
// argument
delegate int DelegateMethod(string msg);
namespace HelloWorldApp{
	class HelloWorld {
	
		public static void method1(string msg){
			Console.WriteLine(msg + " - method 1");	
		}	

		public static void method2(string msg){
			Console.WriteLine(msg + " - method 2");	
		}

		static void Main(string[] args){
			DelegateMethod m1 = new DelegateMethod(method1);
			DelegateMethod m2 = new DelegateMethod(method2);

			m1("123");
			m2("123");
		}
	
	}
}
