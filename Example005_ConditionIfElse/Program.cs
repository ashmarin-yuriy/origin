Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "криска")
{
    Console.WriteLine("Ура, это же КРИСКА");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}