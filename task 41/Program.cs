/*** Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.Clear();
Console.WriteLine("Введите некотрое количество чисел через пробел:");
string st = Console.ReadLine();
int [] GetArrayFromString (string st){
    string[] num = st.Split(" ");
    int[] res = new int[num.Length];
    for (int i =0; i<num.Length; i++)
    {
        res[i] = int.Parse(num[i]);
    }
return res;
}
int metod (int[] res){
    int result = 0;
    for (int i =0; i<res.Length; i++){
        if (res[i] >0)
        {
          result++;
        }
    }
    return result;
}
Console.WriteLine($"{metod(GetArrayFromString(st))}");