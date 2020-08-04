using System;

class enum01{
    /*enum（列挙型）は、適当なデータを入力することができ
    その番号は0から振られる。1から割り振りたい時や、ある番号から振り分けることも可能*/
    enum Month{
        Jan=1,Feb,Mar,Apr,May,Jun,Aug,Sep,Oct,Nov,Dec
    };

    public static void Main(){
        //キャストすることで割り振られた数字を表示することができる
        Console.WriteLine("Aprは{0}月",(int)Month.Apr);
    }
}