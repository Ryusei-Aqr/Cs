using System;


class method{
    public static void Main(){
        addClass a = new addClass();
        int sum;

        sum = a.Add(100, 100);
        Console.WriteLine("sum={0}", sum);

    }
}
class addClass{
        public int Add(int x, int y){
            int z;

            z = x + y;
            return z;
        }
}