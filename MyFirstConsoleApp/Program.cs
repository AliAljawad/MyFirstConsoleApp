using MyFirstConsoleApp;

List<Phone>phones=new List<Phone>();

        Console.WriteLine("Choose one of the following options:");
        Console.WriteLine("1.Add a phone");
        Console.WriteLine("2.List the phones");
        Console.WriteLine("3.Update Phone info");
        Console.WriteLine("4.Delete Phone");
        Console.WriteLine("5.Exit App");
while (phones.Count < 10)
{
    var Case = Convert.ToInt32(Console.ReadLine());
    switch (Case)
    {
        case 1:
            createPhone();
            break;
        case 2:
            ListPhones();
            break;
        case 3:
            updatePhone();
            break;

        case 4:
            deletePhone();
            break;
        case 5:
            Environment.Exit(0);
            break;

    } 
}
void createPhone()
{
        Console.WriteLine("starting the operation of creating a new phone");
        Console.WriteLine("Enter the phone's Brand");
        string brand = Console.ReadLine();
        Console.WriteLine("Enter the phone's name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the phone's color");
        string color = Console.ReadLine();
        Console.WriteLine("Enter the phone's imei");
        var imei = Convert.ToInt32(Console.ReadLine());
    bool duplicate = phones.FirstOrDefault(phone => phone.IMEI == imei) != null;

    while (duplicate)
    {
        Console.WriteLine("Phone already exists");
        Console.WriteLine("Enter the phone's IMEI");
        imei = Convert.ToInt32(Console.ReadLine());
        duplicate = phones.FirstOrDefault(phone => phone.IMEI == imei) != null;
    }

    phones.Add(new Phone (brand, name, color, imei));

   }
void ListPhones()
{
    if (phones.Count == 0)
    {
        Console.WriteLine("No phones available.");
    }
    else
    {
        Console.WriteLine("List of phones:");
        foreach (Phone phone in phones)
        {
            Console.WriteLine(phone.ToString());
        }
    }
}
void updatePhone()
{
    Console.WriteLine("Enter the IMEI of the phone you want to update");
    var imei = Convert.ToInt32(Console.ReadLine());

    foreach (Phone phone in phones)
    {
        if (phone.IMEI == imei)
        {
            Console.WriteLine("Enter the new phone's Brand");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter the new phone's name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the new phone's color");
            string color = Console.ReadLine();
            phone.Brand = brand;
            phone.Name = name;
            phone.Color = color;
            Console.WriteLine("Phone updated successfully.");
            break;
        }
    }
}
void deletePhone()
{
    Console.WriteLine("Enter the imei of the phone you want to delete");
    var imei = Convert.ToInt32(Console.ReadLine());
    foreach (Phone phone in phones)
    {
        if (phone.IMEI == imei)
        {
            phones.Remove(phone);
            break;
        }
    }
}