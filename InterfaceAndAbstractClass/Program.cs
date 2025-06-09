
using InterfaceAndAbstractClass;

IBook book = new BookService();
book.Read();
book.Write("Hello, World!");

IBook bookTwo = new BookServiceTwo();
bookTwo.Read();
bookTwo.Write("Hello from BookServiceTwo!");