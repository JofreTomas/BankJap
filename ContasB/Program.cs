using ContasB.Model;

User ContJofre = new User()
{
    Id = 051,
    Name = "Jofre",
    Email = "jofre@gmail.com",
    agency = "1234",
    account = "1234-X"
};

Console.WriteLine(ContJofre.Id);
Console.WriteLine(ContJofre.Name);
Console.WriteLine(ContJofre.Email);
Console.WriteLine(ContJofre.agency);
Console.WriteLine(ContJofre.account);

CheckingAccount contaCorrJofre = new CheckingAccount()
{
    Id = 1,
    Balance = 50,
    UserId = ContJofre.Id,
    User = ContJofre
};

Console.WriteLine(contaCorrJofre.Balance);

Console.WriteLine("-------------------------------------------------------------------------");

User ContAdair = new User()
{
    Id = 025,
    Name = "Adair",
    Email = "Adair@gmail.com",
    agency = "5262",
    account = "9437-X"
};

Console.WriteLine(ContAdair.Id);
Console.WriteLine(ContAdair.Name);
Console.WriteLine(ContAdair.Email);
Console.WriteLine(ContAdair.agency);
Console.WriteLine(ContAdair.account);

CheckingAccount contaCorrAdair = new CheckingAccount()
{
    Id = 2,
    Balance = 200,
    UserId = ContAdair.Id,
    User = ContAdair
};

Console.WriteLine(contaCorrAdair.Balance);

Console.WriteLine("-------------------------------------------------------------------------");

contaCorrJofre.Deposit(100);

Console.WriteLine("-------------------------------------------------------------------------");

contaCorrJofre.Transfer(120, contaCorrAdair);
