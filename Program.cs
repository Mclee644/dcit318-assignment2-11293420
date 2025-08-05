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

class Circle:Shape{
	public double area ;
	public double radius;
	public double PI = 3.14159;

	public Circle(int radius){
		this.radius = radius;
	}

	public override double GetArea(){
		return area = PI * (radius*radius);
	}
}

class Rectangle:Shape{
	public double length;
	public double width;
	public double area;

	public Rectangle(double length, double width){
		this.length = length;
		this.width = width;
	}

	public override double GetArea(){
		return area = length*width;
	}
	

}

class Car:IMovable{
	public void Move(){
		Console.WriteLine("Car is moving");
	}

}

class Bicycle:IMovable{
	public void Move(){
		Console.WriteLine("Bicycle is moving");
	}

}