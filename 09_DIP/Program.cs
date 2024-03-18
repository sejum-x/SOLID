// Принцип інверсії залежностей (Dependency Inversion Principle)
// Cкладається з двох тверджень:

// високорівневі модулі не повинні залежати від низькорівневих.
// І ті, і ті мають залежати від абстракцій;
// Aбстракції не мають залежати від деталей реалізації.
// Деталі реалізації повинні залежати від абстракцій.

ConsolePrinter consolePrinter = new ConsolePrinter();

Book book = new Book() { Text = "C# book", Printer = consolePrinter };
book.Print();

class Book
{
    public string? Text { get; set; }
    public ConsolePrinter? Printer { get; set; }

    public void Print()
    {
        Printer?.Print(Text);
    }
}

class ConsolePrinter
{
    public void Print(string? text)
    {
        Console.WriteLine(text);
    }
}

