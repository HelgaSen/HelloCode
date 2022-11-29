Console.WriteLine("Введите имя пользоавтеля: ");
string? username = Console.ReadLine();

if(username!=null)
{
if(username.ToLower() == "lelinka")
{
    Console.WriteLine("Привет, детка! Ты круче всех! ;)");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
}