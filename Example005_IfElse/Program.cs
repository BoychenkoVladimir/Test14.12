Console.Write("Ведите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() ==  "masha")
{
    Console.WriteLine ("Ура, этоже Маша!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}