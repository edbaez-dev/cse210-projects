using System;
using System.IO;

public class Entry

{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }

    public void SaveEntry(StreamWriter outputFile)
    {
        string csvLine = $"{EscapeCsvField(_date)},{EscapeCsvField(_promptText)},{EscapeCsvField(_entryText)}";
        outputFile.WriteLine(csvLine);
    }

    private string EscapeCsvField(string field)
    {
        string escapedField = field.Replace("\"", "\"\"");
        return $"\"{escapedField}\"";
    }
}