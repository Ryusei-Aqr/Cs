using System;

class prac4{
    public static void Main(){
        int cat=1, rat=2, dog=4;
        
        int pet=cat | dog;

        Console.WriteLine("I have a cat--{0}",(pet&cat)!=0);
        Console.WriteLine("I have a dog--{0}",(pet&dog)!=0);
        Console.WriteLine("I have a rat--{0}",(pet&rat)!=0);
    }
}