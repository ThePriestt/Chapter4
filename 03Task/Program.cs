using System;

// Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт и мениджър. Мениджърът има име, фамилия и телефонен номер. Напишете програма, 
// която чете информацията за фирмата и нейния мениджър и я отпечатва след това на конзолата.

class program
{
    static void Main()
    {
        Console.Write("Моля въведете името на фирмата: ");
        string companyName = Console.ReadLine();

        Console.Write("Моля въведете адреса на фирмата: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Моля въведете телефонния номер на фирмата: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Моля въведете факс номера на фирмата: ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Моля въведете Уеб сайта на фирмата: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Моля въведете името на мениджъра на фирмата: ");
        string companyManagerName = Console.ReadLine();


        Console.Write("Моля въведете името на мениджъра: ");
        string managerName = Console.ReadLine();

        Console.Write("Моля въведете фамилията на мениджъра: ");
        string managerFamilyName = Console.ReadLine();

        Console.Write("Моля въведете телефона на мениджъра: ");
        string managerPhoneNumber = Console.ReadLine();


        Console.WriteLine("Информация за фирма: Име: {0}, Адрес: {1}, Телефон: {2}, Факс: {3}, Уеб сайт: {4}, Мениджър: {5}", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite, companyManagerName);
        Console.WriteLine("Информация за мениджър: Име: {0}, Фамилията: {1}, Телефон: {2}", managerName, managerFamilyName, managerPhoneNumber);
    }
}

