﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "настя")
{
    Console.WriteLine("Ура, это же Настюшка");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
