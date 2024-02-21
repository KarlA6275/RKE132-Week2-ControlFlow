// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajalt valida tema sugu (m/f)
//Rakendus küsib kasutajalt sisestada tema perekonnanime
//Lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcom, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f)");

char userGender = Char.Parse(Console.ReadLine()); //Loeb konsoolist maha andmeid string (sõne) formaadis


Console.WriteLine("please, enter your name");

string userLastName = Console.ReadLine();


if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}");
}