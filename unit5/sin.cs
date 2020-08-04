using System;

class sin{
    public static void Main(){
        double s;

        for(double a=0.0; a <= Math.PI; a += Math.PI / 45.0){
            s=Math.Sin(a);//正弦（sin）すなわち高さを長辺で割った値
            Console.Write("{0,7:#.#####}:",s);
            for(int i=1;i <= Math.Round(s * 50); i++){
                Console.Write("*");
            }
            Console.WriteLine();
            }
        }
    }