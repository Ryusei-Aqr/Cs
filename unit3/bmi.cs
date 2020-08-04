using System;

class bmi{
    public static void Main(){
        Console.Write("身長(m)---");
        double hight=double.Parse(Console.ReadLine());
        Console.Write("体重(kg)---");
        double weight=double.Parse(Console.ReadLine());
        Console.WriteLine("BMI = {0:##.#}", weight/Math.Pow(hight,2.0));
    }
}

