using System;

namespace HelloWorld{
	struct MyStruct
	{
		string MyProperty {get; set;}
	}

	class MyClass
	{
		string MyProperty {get; set;}
	}

	void changer(object input)
	{
		input.MyProperty = "new value";
	}


	public static void main(string args[]){
		MyClass  mc = new MyClass  {MyProperty = "initial state"};
		MyStruct ms = new MyStruct {MyProperty = "initial state"};
		
		// Reference types. MyProperty will change
		changer(mc);
		// Value types. Copy will change, original MyProperty stays the same
		changer(ms);
	}
}
