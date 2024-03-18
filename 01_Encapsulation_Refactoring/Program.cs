// Інкапсуляція
// Вирішення проблеми, інкапсулюємо методи та створюємо public метод,
// як інтерфейс роботи користувача.

Document document = new Document();
document.CreateDocument();

internal class Document
{
    public void CreateDocument()
    {
        CreateHeader();
        CreateBody();
        CreateSignature();
    }

    private void CreateHeader()
    {
        Console.WriteLine("CreateHeader");
    }

    private void CreateBody()
    {
        Console.WriteLine("CreateBody");
    }

    private void CreateSignature()
    {
        Console.WriteLine("CreateSignature");
    }
}