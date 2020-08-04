using System;

class string01{
    public static void Main(){
        string str="Today is good.";
        string mystr;
        char c;

        Console.WriteLine(str);
        Console.WriteLine("Length:{0}",str.Length);
        //文字型変数cに文字列strの5番目の文字を代入
        c=str[4];
        Console.WriteLine("the fifth of str:{0}",c);

        //コピー
        mystr=string.Copy(str);
        Console.WriteLine("mystr={0}",mystr);

        //検索
        int n=str.IndexOf("i");
        if((n+1)==7){
        Console.WriteLine("[i] is seventh.");
        }

    }
}