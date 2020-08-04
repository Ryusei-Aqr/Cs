using System;

class prac3_2{
    public static void Main(){
        int r;
        double area;

        Console.Write("半径を入力してください:");
        r=int.Parse(Console.ReadLine());

        area=r*r*Math.PI;

        Console.WriteLine("半径が{0}の面積は{1}です。",r,area);
    }
}