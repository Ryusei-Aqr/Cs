using System;

class switch1{
    public static void Main(){
        Console.WriteLine(" ******* Menu ******");
        Console.WriteLine("1:File");
        Console.WriteLine("2:Edit");
        Console.WriteLine("3:Display");
        Console.WriteLine("0:Termination");
        Console.WriteLine("********************");

        Console.Write("\n選択---");
        string strAns = Console.ReadLine();
        //int ans = Int16.Parse(strAns);

        switch(strAns){
            case "1":
                Console.WriteLine("ファイルが選択されました。");
                break;
            case "2":
                Console.WriteLine("編集が選択されました。");
                break;
            case "3":
                Console.WriteLine("表示が選択されました。");
                break;
            case "0":
                Console.WriteLine("終了が選択されました。");
                break;
            default:
                Console.WriteLine("入力ミス");
                break;
        }
    }
}