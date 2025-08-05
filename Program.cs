using System;

class Program{
	static void Main(string[] args){
		string title = """

		|	INHERITANCE AND METHOD OVERRIDING	|

		""";

		Console.WriteLine(title);
		Animal onipa = new Animal();
		onipa.MakeSound();

		Dog adom = new Dog();
		adom.MakeSound();

		Cat puss = new Cat();
		puss.MakeSound();
	}
}

class Animal{
	public virtual void MakeSound(){
		Console.WriteLine("Some generic sound");
	}
}

class Dog:Animal{
	public override void MakeSound(){
		Console.WriteLine("Bark");
	}
}

class Cat:Animal{
	public override void MakeSound(){
		Console.WriteLine("Meow");
	}
}