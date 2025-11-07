using System;
using System.Collections.Generic;
using System.IO;   

namespace JournalProgram
{
    public class Journal   
{
     private List<Entry> _entries = new List<Entry>();

     void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    void DisplayALL()
    {
        foreach (Entry enter in _entries)
        {
            enter.Display();
        }
    }

     void SaveToFile(string file)
    {
        using (StreamWriter  writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{DateTime.Now}| {entry}");
            }
        }
    }
    void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

}

