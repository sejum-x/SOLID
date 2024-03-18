// Інкапсуляція — це принцип ООП, який полягає в приховуванні
// деталей реалізації об'єктів від «зовнішнього світу».
// Цей принцип стверджує, що вся важлива інформація міститься
// всередині об’єкта, а назовні доступна тільки вибрана інформація. 

// Проблема (користувацький код має знати послідовність виклику)

Document document = new Document();
document.CreateBody();
document.CreateHeader();
document.CreateSignature();

internal class Document
{
    public void CreateHeader()
    {
        Console.WriteLine("CreateHeader");
    }

    public void CreateBody()
    {
        Console.WriteLine("CreateBody");
    }
    public void CreateSignature()
    {
        Console.WriteLine("CreateSignature");
    }
}