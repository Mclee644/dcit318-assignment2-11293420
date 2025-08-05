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


		title = """

		|	ABSTRACT CLASSES AND METHODS	|

		""";
		Console.WriteLine(title);

		Circle nkrumahCircle = new Circle(20);
		Console.WriteLine($"Area of the Circle: {nkrumahCircle.GetArea()}");

		Rectangle smallRectange = new Rectangle(10,15);
		Console.WriteLine($"Area of the Rectangle: {smallRectange.GetArea()}");

		title = """

		|	INTERFACES	|

		""";
		Console.WriteLine(title);

		Car lapazToyota = new Car();
		lapazToyota.Move();

		Bicycle bmx = new Bicycle();
		bmx.Move();
	}
}