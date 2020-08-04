using System;

class if2{
    public static void Main(){
        /*ReadLine()メソットは、戻り値がString型なのでInt型に変換する必要がある*/
        Console.Write("所持金はいくらですか---");
        String st_money_in_hand = Console.ReadLine();
        int n_MoneyInHand = Int32.Parse(st_money_in_hand);

        Console.Write("単価はいくらですか---");
        String st_unitCost = Console.ReadLine();
        int n_unitCost = Int32.Parse(st_unitCost);

        Console.Write("何個書いますか---");
        String st_num = Console.ReadLine();
        int n_num = Int32.Parse(st_num);

        int sum = n_unitCost * n_num;

            if(n_MoneyInHand < sum){
                Console.WriteLine("所持金が足りません");
            }else{
                int spare = n_MoneyInHand - sum;
                Console.WriteLine("所持金は" + spare +"円残っています。");
            }
    }
}