using System;

class prac1{
    public static void Main(){

        double height_min=160, height_max=180,height,weight,bmi=22.0;

        for(height=height_min; height <= height_max; height++){
                
                weight = ((height * height)/10000)*bmi;

                Console.WriteLine("BMIが22になる体重は{0}cmにおいて、{1}kgです。",height,weight,1);
        }
    }
}