using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                entry.SaveEntry(outputFile);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            List<string> fields = ParseCsvLine(line);

            string date = fields[0];
            string promptText = fields[1];
            string entryText = fields[2];

            Entry newEntry = new Entry(date, promptText, entryText);
            _entries.Add(newEntry);
        }
    }

    private List<string> ParseCsvLine(string line)
    {
        List<string> fields = new List<string>();
        StringBuilder currentField = new StringBuilder();
        bool insideQuotes = false;

        int i = 0;
        while (i < line.Length)
        {
            char currentChar = line[i];

            if (insideQuotes)
            {
                if (currentChar == '"')
                {
                    bool isEscapedQuote = (i + 1 < line.Length) && (line[i + 1] == '"');
                    if (isEscapedQuote)
                    {
                        currentField.Append('"');
                        i++;
                    }
                    else
                    {
                        insideQuotes = false;
                    }
                }
                else
                {
                    currentField.Append(currentChar);
                }
            }
            else
            {
                if (currentChar == '"')
                {
                    insideQuotes = true;
                }
                else if (currentChar == ',')
                {
                    fields.Add(currentField.ToString());
                    currentField.Clear();
                }
                else
                {
                    currentField.Append(currentChar);
                }
            }

            i++;
        }

        fields.Add(currentField.ToString());

        return fields;
    }
}