//Array

//int[,] numbers = {{ 1, 2, 3, 4, 5 },
//                 { 1, 2, 3, 4, 5 }};

//int[,] numbers2 = new int[3, 5] {{ 1, 2, 3, 4, 5 },
//                 { 1, 2, 3, 4, 5 },
//                 { 1, 2, 3, 4, 5 }};

//int[,] numbers3 = new int[,] {{ 1, 2, 3, 4, 5 },
//                 { 1, 2, 3, 4, 5 },
//                 { 1, 2, 3, 4, 5 }};


//int res = 0;
//foreach (var number in numbers2)
//    res += number;

//Console.WriteLine($"natija: {res}");

//for(int i = 0; i < 2; i++)
//    for(int j = 0; j < 5; j++)
//        Console.WriteLine($"{numbers[i, j]}");


//Methods
//int addTwoNumbers(int a, int b)
//{
//    return a + b;
//}

//int addThreeNumbers(int a, int b, int c)
//    => a + b + c;

//void addFourNumbers(double a, double b, double c, double d)
//    => Console.WriteLine($"3 - natija: {a + b + c + d}");

//int s1, s2, s3;
//double s4;
//Console.WriteLine("3 - ta natural son kiriting: ");
//s1 = Convert.ToInt32(Console.ReadLine());
//s2 = Convert.ToInt32(Console.ReadLine());
//s3 = Convert.ToInt32(Console.ReadLine());
//s4 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"1 - natija: {addTwoNumbers(s1, s2)}");
//Console.WriteLine($"1 - natija: {addThreeNumbers(s1, s2, s3)}");
//addFourNumbers(s1, s2, s3, s4);

//type methodName(parameter1, parameter2, ...) { operators }
//void print(string[] fruits)
//{
//    foreach(var fruit in fruits)
//        Console.WriteLine(fruit);
//}


//string[] fruits = { "olma", "behi", "anor", "nok", "gilos"};
//print(fruits);