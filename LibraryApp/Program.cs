using LibraryApp;

Book otganKunlar = new Book("O'tgan kunlar", "Abdulla Qodiriy", 1926, true);
Book sariqDevniMinib = new Book("Sariq devni minib", "Abdulla Qodiriy", 1928, true);

LibraryService.AddBook(otganKunlar);
LibraryService.AddBook(sariqDevniMinib);

while (true)
{
    Console.Write($"1. Mavjud kitoblarni ko'rsatish\r\n2. Kitob ijaraga olish\r\n3. Kitobni qaytarish\r\n4. Dasturdan chiqish\nTanlang: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            var books = LibraryService.GetBooks();
            Console.WriteLine("Mavjud kitoblar\n--------------------------------------");
            foreach (var book in books)
            {
                Console.WriteLine($"- {book.GetTitle()}, yozuvchi: {book.GetAuthor()} ({book.GetYear()}) - ichara: {(book.GetAvailability() == true ? "mavjud" : "ijarada")}");
            }
            Console.WriteLine("--------------------------------------");
            break;

        case 2:
            Console.Write("Kitob nomini kiriting: ");
            string borrowTitle = Console.ReadLine();
            if (LibraryService.BorrowBook(borrowTitle))
                Console.WriteLine("Kitob ijaraga olindi!");
            else
                Console.WriteLine("Kitob ijaraga berib yuborilgan yoki mavjud emas ekan!");
            break;

        case 3:
            Console.Write("Qaytariladigan kitob nomini kiriting: ");
            string returnTitle = Console.ReadLine();
            if (LibraryService.ReturnBook(returnTitle))
                Console.WriteLine("Kitob qaytarildi!");
            else
                Console.WriteLine("Bu kitob ijaraga olinmagan yoki mavjud emas!");
            break;

        case 4:
            Console.WriteLine("Dasturdan chiqish...");
            return; 
    }
}
