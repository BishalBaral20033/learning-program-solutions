using System;

// Document interface
public interface IDocument
{
    void Open();
}

// Concrete document classes
public class WordDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening a Word Document.");
}

public class PdfDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening a PDF Document.");
}

public class ExcelDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening an Excel Document.");
}

// Abstract factory
public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

// Concrete factories
public class WordFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new WordDocument();
}

public class PdfFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new PdfDocument();
}

public class ExcelFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new ExcelDocument();
}

// Client code
class Program
{
    static void Main()
    {
        DocumentFactory wordFactory = new WordFactory();
        IDocument word = wordFactory.CreateDocument();
        word.Open();

        DocumentFactory pdfFactory = new PdfFactory();
        IDocument pdf = pdfFactory.CreateDocument();
        pdf.Open();

        DocumentFactory excelFactory = new ExcelFactory();
        IDocument excel = excelFactory.CreateDocument();
        excel.Open();
    }
}
