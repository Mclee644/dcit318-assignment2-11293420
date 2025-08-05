using System;
public class Circle:Shape{
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