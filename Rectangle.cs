using System;
public class Rectangle:Shape{
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