using InstantiatedClasses;

//   Creating ⬇ from this blueprint ⬇
//PersonModel person = new PersonModel();

//List<PersonModel> people = new List<PersonModel>();

//PersonModel person = new PersonModel();

//person.firstName = "David";
//people.Add(person);

//person = new PersonModel();
//person.firstName = "Tim";
//people.Add(person);

//foreach (PersonModel p in people)
//{
//    Console.WriteLine(p.firstName);
//}


List<PersonModel> people = new List<PersonModel>();
string firstName = string.Empty;
string lastName = string.Empty;

do
{
    Console.Write($"What is your first name (or type 'exit' to stop): ");
    firstName = Console.ReadLine();

    Console.Write($"What is your last name (or type 'exit' to stop): ");
    lastName = Console.ReadLine();

    if (firstName.ToLower() != "exit" && lastName.ToLower() != "exit")
    {
        PersonModel person = new PersonModel();
        person.FirstName = firstName;
        person.LastName = lastName;
        people.Add( person );
    }
}
while (firstName.ToLower() != "exit" && lastName.ToLower() != "exit");


foreach (PersonModel person in people)
{
    //Console.WriteLine($"{person.FirstName} {person.LastName}");
    ProcessPerson.GreetPerson( person );
}
Console.ReadLine();