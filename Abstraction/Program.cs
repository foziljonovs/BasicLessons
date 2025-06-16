using Abstraction;

Book sariqDevniMinib = new Book
{
    Title = "Sariq devni minib",
    Page = 1,
    Author = "Muhammadkarim To'xtaboyev"
};

sariqDevniMinib.Read();
Console.WriteLine("Kitob haqida\n ----------------------------------");
Console.WriteLine($"kitob nomi: {sariqDevniMinib.GetTitle()}\t" +
    $"varoqlar soni: {sariqDevniMinib.Page}\tyozuvchi: {sariqDevniMinib.Author}");