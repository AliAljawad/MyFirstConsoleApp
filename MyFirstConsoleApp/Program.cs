using MyFirstConsoleApp;

List<Phone> phones = new List<Phone>();
while (phones.Count < 10)
{

    try
    {
        Console.WriteLine("Choose one of the following options:");
        Console.WriteLine("1.Add a phone");
        Console.WriteLine("2.List the phones");
        Console.WriteLine("3.Update Phone info");
        Console.WriteLine("4.Delete Phone");
        Console.WriteLine("5.Exit App");

        var caseInput = Console.ReadLine();
        var @case = Convert.ToInt32(string.IsNullOrEmpty(caseInput) ? "0" : caseInput);

        switch (@case)
        {
            case 1:
                CreatePhone();
                break;
            case 2:
                ListPhones();
                break;
            case 3:
                UpdatePhone();
                break;

            case 4:
                DeletePhone();
                break;
            case 5:
                Environment.Exit(0);
                break;

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}
void CreatePhone()
{
    Console.WriteLine("starting the operation of creating a new phone");
    Console.WriteLine("Enter the phone's Brand");
    var brand = Console.ReadLine();
    Console.WriteLine("Enter the phone's name");
    var name = Console.ReadLine();
    Console.WriteLine("Enter the phone's color");
    var color = Console.ReadLine();
    Console.WriteLine("Enter the phone's imei");
    var imei = Convert.ToInt32(Console.ReadLine());
    bool duplicate = phones.Any(phone => phone.Id == imei);
    while (duplicate)
    {
        Console.WriteLine("Phone already exists");
        Console.WriteLine("Enter the phone's IMEI");
        imei = Convert.ToInt32(Console.ReadLine());
        duplicate = phones.Any(phone => phone.Id == imei);
    }
    phones.Add(new Phone(imei, brand, name, color));

}
void ListPhones()
{
    if (!phones.Any())
    {
        Console.WriteLine("No phones available.");
    }
    else
    {
        Console.WriteLine("List of phones:");
        foreach (var phone in phones)
        {
            Console.WriteLine(phone.ToString());
        }
    }
}
void UpdatePhone()
{
    Console.WriteLine("Enter the IMEI of the phone you want to update");
    var imei = Convert.ToInt32(Console.ReadLine());
    var phone = phones.FirstOrDefault(p => p.Id == imei);

    if (phone is null)
        Console.WriteLine("IMEI Does not exist");
    else
    {
        Console.WriteLine("Enter the new phone's Brand");
        var brand = Console.ReadLine();
        Console.WriteLine("Enter the new phone's name");
        var name = Console.ReadLine();
        Console.WriteLine("Enter the new phone's color");
        var color = Console.ReadLine();
        phone.Update(brand, name, color);
        Console.WriteLine("Phone updated successfully.");
    }
}
void DeletePhone()
{
    Console.WriteLine("Enter the imei of the phone you want to delete");
    var imei = Convert.ToInt32(Console.ReadLine());
    var phone = phones.FirstOrDefault(phone => phone.Id == imei);
    if (phone is null)
        Console.WriteLine("Phone does not exist");
    else
        phones.Remove(phone);
}