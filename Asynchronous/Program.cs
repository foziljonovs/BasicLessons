//Thread thread1 = new Thread(() =>
//{
//    Thread.Sleep(3000);
//    Console.WriteLine("Thread 1: Salom");
//});

//Thread thread2 = new Thread(() =>
//{
//    Thread.Sleep(2000);
//    Console.WriteLine("Thread 2: Qalaysiz");
//});

//Thread thread3 = new Thread(() =>
//{
//    Thread.Sleep(1000);
//    Console.WriteLine("Thread 3: Hayr");
//});
//void Salom()
//{
//    Thread.Sleep(1500);
//    Console.WriteLine("Salom");
//}

//Thread salom = new Thread(Salom);

//salom.Start();
//thread1.Start();
//thread2.Start();
//thread3.Start();

//Task task1 = Task.Run(async () =>
//{
//    await Task.Delay(3000);
//    Console.WriteLine("Task 1: Salom");
//});

//Task task2 = Task.Run(async () =>
//{
//    await Task.Delay(2000);
//    Console.WriteLine("Task 2: Qalaysiz");
//});

//Task task3 = Task.Run(async () =>
//{
//    await Task.Delay(1000);
//    Console.WriteLine("Task 3: Hayr");
//});

//await Task.WhenAll(
//    task1,
//    task2,
//    task3);

//async Task Salom()
//{
//    await Task.Delay(3000);
//    Console.WriteLine("Task 1: Salom");
//}

//async Task Qalaysiz()
//{
//    await Task.Delay(2000);
//    Console.WriteLine("Task 2: Qalaysiz");
//}

//async Task Hayr()
//{
//    await Task.Delay(1000);
//    Console.WriteLine("Task 3: Hayr");
//}

//await Salom();
//await Qalaysiz();
//await Hayr();

int i = 10;

async Task Salom()
{
    await Task.Delay(3000);
    Console.WriteLine("Salom");
}

Thread thread1 = new Thread(() =>
{
    Thread.Sleep(3000);
    Console.WriteLine("Thread 1: Salom");
});

thread1.Start();

if (i > 5)
    Console.WriteLine($"{i} > 5");
else
    Console.WriteLine($"{i} < 5");

await Salom();

if (i > 5)
    Console.WriteLine($"{i} > 5");
else
    Console.WriteLine($"{i} < 5");



