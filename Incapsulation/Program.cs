using Incapsulation;

List<Person> persons = new List<Person>();

while (true)
{
    char choose;
    Console.Write("1. Barcha odamlarning malumotlarini ko'rish\n2. Registratsiyadan o'tqazish\tchiqish\ntanlang: ");

    choose = char.Parse(Console.ReadLine());

    switch (choose)
    {
        case '1':
            if (persons.Any())
            {
                foreach(var item in persons)
                    item.PrintInfo();
            }
            else
            {
                Console.WriteLine("Hozirda odamlarning malumotlari yo'q");
            }
            break;

        case '2':
            Person person = new Person();

            Console.Write("Ism familyangizni kiriting: ");
            person.SetFullName(Console.ReadLine());

            Console.Write("Yoshingizni kiriting: ");
            person.SetAge(int.Parse(Console.ReadLine()));

            Console.Write("Telefon raqamingizni kiriting: ");
            person.SetPhoneNumber(Console.ReadLine());

            Console.WriteLine("Yashash manzilingizni kiriting: ");
            person.SetAddress(Console.ReadLine());

            persons.Add(person);

            Console.WriteLine("Odam registratsiyadan o'tqazildi");

            break;

        case '3':
            Console.WriteLine("Dasturdan chiqyapsiz");
            return;
    }
}
