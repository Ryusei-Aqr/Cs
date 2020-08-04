/*unit4までは算術演算子なので飛ばした*/
using System;

class bitwise01{
    /*
    論理演算子
    and>>> &
    or>>>> |
    xor>>> ˆ
    */
    public static void Main(){
        bool a=true,b=false;
        Console.WriteLine(a&b);
        Console.WriteLine(a|b);
        Console.WriteLine(a^b);
    }
}