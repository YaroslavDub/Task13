// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>0) {
while (a > 999) {
a = a / 10;
}
if (a > 99 && a < 1000) {
a = a % 10;
Console.WriteLine(a);
}
else {
Console.WriteLine("3 Числа нет");
}
}
else {
    while (a < -1000) {
        a = a / 10;
    }
    if (a > -1000 && a < -99){
        a = a % -10;
        Console.WriteLine(a);
    }
    else {
        Console.WriteLine("3 Числа нет");
    }
}
