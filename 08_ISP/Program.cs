// Принцип розділення інтерфейсів (Interface Segregation Principle, ISP)
// є одним з принципів SOLID і стверджує, що клас не повинен виживати методи,
// які він не використовує. Коли клас реалізує інтерфейс, інтерфейс повинен бути
// таким, щоб його клієнти знали лише ті методи, які їм дійсно потрібні.

EmailMessage emailMessage = new EmailMessage();
emailMessage.Voice = new byte[0];

interface IMessage
{
    void Send();
    string Text { get; set; }
    string Subject { get; set; }
    string ToAddress { get; set; }
    string FromAddress { get; set; }
    byte[] Voice { get; set; }
}

class EmailMessage : IMessage
{
    public string Subject { get; set; } = "";
    public string Text { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public string ToAddress { get; set; } = "";
    public byte[] Voice 
    { 
        get => throw new NotImplementedException(); 
        set => throw new NotImplementedException(); 
    }

    public void Send() 
    {
        Console.WriteLine($"Отправляем Email-сообщение: {Text}");
    }
}

class SmsMessage : IMessage
{
    public string Text { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public string ToAddress { get; set; } = "";

    public string Subject
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public byte[] Voice 
    { 
        get => throw new NotImplementedException(); 
        set => throw new NotImplementedException(); 
    }

    public void Send()
    {
        Console.WriteLine($"Отправляем Sms-сообщение: {Text}");
    }
}

class VoiceMessage : IMessage
{
    public string ToAddress { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public byte[] Voice { get; set; } = new byte[] { };

    public string Text
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string Subject
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public void Send()
    {
        Console.WriteLine("Передача голосовой почты");
    }
}