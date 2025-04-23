//Value type
//int, float, double, decimal, char, bool, enum, struct, nullable types


//natural sonlar bilan ishlovchi type
//int son1;
//int son2 = 10;

//son1 = int.Parse(Console.ReadLine());
//Console.WriteLine(son1 + son2);


//kasrli va natural sonlar bilan ishlovchi type
//float son1 = float.Parse(Console.ReadLine());
//float son2 = 3.14f;

//Console.WriteLine(son1 + son2);


//kasrli va natural sonlar bilan ishlovchi type
//double son1 = double.Parse(Console.ReadLine());
//double son2 = 5.4;

//Console.WriteLine($"natija: {son1 + son2}, bizning xizmatimizdan foydalanganingiz uchun sps");


//o'ta katta kasrli va natural sonlar bilan ishlovchi type
//decimal son1 = decimal.Parse(Console.ReadLine());
//decimal son2 = 1.0123781632836172368e19m;

//Console.WriteLine($"natija: {son1 + son2}");


//matn bilan ishlovchi type
//string matn1 = Console.ReadLine();
//string matn2 = "Assalomu aleykum!";

//Console.WriteLine($"{matn2} {matn1}, xush kelibsiz bro.");


//Operatorlar
//int son1, son2, res = 0;
//son1 = Convert.ToInt32(Console.ReadLine());
//son2 = int.Parse(Console.ReadLine());

//res = son1 + son2;
//Console.WriteLine($"qo'shish amali natijasi: {res}");

//res = son1 - son2;
//Console.WriteLine($"ayirish amali natijasi: {res}");

//res = son1 * son2;
//Console.WriteLine($"ko'paytirish amali natijasi: {res}");

//res = son1 / son2;
//Console.WriteLine($"bo'lish amali natijasi: {res}");


//int n1, n2, res = 0;
//n1 = Convert.ToInt32(Console.ReadLine());
//n2 = Convert.ToInt32(Console.ReadLine());

//if (n1 > n2)
//    Console.WriteLine($"{n1} son {n2} sondan katta.");
//else if (n1 == n2)
//    Console.WriteLine($"{n1} va {n2} sonlar teng.");
//else if (n1 == 0 && n2 == 0)
//    Console.WriteLine($"{n1} va {n2} sonlar 0 ga teng.");
//else
//    Console.WriteLine($"{n1} son {n2} sondan kichik.");


//tekshirish operatorlari (<, >, <=, >=, ==, !=)
//tanlash operatori (switch)
//takrorlash operatori (for, while, do while, foreach)


//string ism;
//Console.Write("1.Mirafzal\n2.Zikrillo\nO'quvchining ismi: ");
//ism = Console.ReadLine();

//switch (ism)
//{
//    case "Mirafzal": Console.WriteLine("Mirafzal bugun darsga keldi"); break;
//    case "Zikrillo": Console.WriteLine("Zikrillo bugun darsga keldi"); break;
//    default: Console.WriteLine("Bunday o'quvchi darsga kelmadi"); break;
//}


//Console.Write("Sonlarning yig'indisini topish uchun\n2ta n - son kiriting: ");
//double n = Convert.ToDouble(Console.ReadLine());
//double n1 = Convert.ToDouble(Console.ReadLine());

//switch ((n, n1))
//{
//    case (0, 0) when n == n1: Console.WriteLine("Sonlar 0 ga teng"); break;
//    case (< 0, < 0): Console.WriteLine("Musbat son kiritildi va bunday amalni bajara olmayman!"); break;
//    case (> 0, > 0): Console.WriteLine($"Sonning yig'indisi: {n + n1}"); break;
//    case (> 0, < 0): Console.WriteLine($"Sonning yig'indisi {n - n1}"); break;
//    default: Console.WriteLine("Bunday amalni bajara olmayman!"); break;
//}


/*int n = int.Parse(Console.ReadLine());
int n1 = int.Parse(Console.ReadLine());

switch ((n, n1))
{
    case (> 0, > 0) when n == n1:
        Console.WriteLine($"{n} va {n1} musbat sonlar va o'zaro teng");
        break;
    case (> 0, > 0):
        Console.WriteLine($"{n} va {n1} musbat sonlar");
        break;
    default:
        Console.WriteLine("Bunday amalni bajara olmayman!");
        break;
}*/

//Console.WriteLine("2 - ta natural son kiriting: ");
//int n1 = int.Parse(Console.ReadLine());
//int n2 = int.Parse(Console.ReadLine());

//Console.WriteLine("+, -, *, / amallaridan birini tanlang: ");
//char belgi = char.Parse(Console.ReadLine());

//int res = belgi switch
//{
//    '+' when (n1 > 0 && n2 > 0) => n1 + n2,
//    '-' when (n1 > 0 && n2 > 0) => n1 - n2,
//    '*' when (n1 > 0 && n2 > 0) => n1 * n2,
//    '/' when (n1 > 0 && n2 > 0) => n1 / n2,
//    _ => 0 //default vazifasini bajaradi
//};

//Console.WriteLine($"natija: {res}");

//Console.Write("Baxoni kiriting: ");
//int grade = int.Parse(Console.ReadLine());

//Console.Write("Imtiyozingiz bormi? Ha/Yo'q : ");
//string privalege = Console.ReadLine();

//bool hasPrivilege = privalege == "Ha" ? true : false;

//switch (grade)
//{
//    case (>= 90) when hasPrivilege == true:
//        Console.WriteLine("A+");
//        break;

//    case (>= 90) when hasPrivilege == false:
//        Console.WriteLine("A");
//        break;

//    case (>= 80):
//        Console.WriteLine("B");
//        break;

//    case (>= 70):
//        Console.WriteLine("C");
//        break;

//    default:
//        Console.WriteLine("F");
//        break;
//}



//Console.WriteLine("2 - ta natural son kiriting: ");
//int n = int.Parse(Console.ReadLine());
//int n1 = int.Parse(Console.ReadLine());

//switch((n, n1))
//{
//    case (< 0, < 0) when n == n1:
//        Console.WriteLine("2 la son ham manfiy va teng!");
//        break;

//    case (< 0, < 0):
//        Console.WriteLine("2 la son ham manfiy!");
//        break;

//    case (0, > 0): 
//        Console.WriteLine("0 va musbat son kiritildi");
//        break;

//    case ( > 0, 0):
//        Console.WriteLine("Musbat son va 0 kiritildi");
//        break;

//    default:
//        Console.WriteLine("Bunday amalni bajara olmayman!");
//        break;
//}



//for(int i = 0; i < 10; i++)
//    Console.WriteLine($"{i} - marta ishladi");

//int i = 0;
//while(i < 10)
//{
//    i++;
//    Console.WriteLine($"{i} - marta ishladi");
//}

//int i = 100;
//do
//{
//    i--;
//    if (i == 10)
//        break;
//    else if (i % 2 == 0)
//        Console.WriteLine($"{i} - juft son");
//    else
//        Console.WriteLine($"{i} - toq son");
//}
//while (i > 0);


//int[] sonlar = { 1, 2, 3, 4, 5, 6, 7, 8};

//foreach (int son in sonlar)
//{
//    if(son % 2 == 0)
//        Console.WriteLine($"{son} - juft son");
//    else
//        Console.WriteLine($"{son} - toq son");
//}