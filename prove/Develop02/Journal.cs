using System;
using System.Globalization;

public class Journal
{
    private List<Entry> _journal = new List<Entry>();

    public void WriteJournal(Entry entry) {
        
        _journal.Add(entry);
    }

    public string DisplayJournal() {

        string output;
        
        if (_journal.Count == 0) {
            output = "No entries found.";
            return output;
        }

        output = "Previous entries:\n";
        
        foreach (Entry entry in _journal) {
            output = output + entry.ToDisplay() +"\n\n";
        }
        return output;
    }

    public void SaveJournal(string filename) {

        if (File.Exists(filename)) {
            File.Delete(filename);
        }
        
        foreach (Entry entry in _journal) {
            File.AppendAllText(filename, $"{entry}\n");
        }
    }

    public int Count() {
        return _journal.Count;
    }

    public string LoadJournal(string filename) {
        

        if (!File.Exists(filename)) {
            return "No journal file found.";
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                
                DateTime dateGenerated = DateTime.ParseExact(parts[0], "MM/dd/yyyy", CultureInfo.InvariantCulture);
                string prompt = parts[1];
                string message = parts[2];
                string location = parts[3];

                Entry entry = new Entry(prompt, message, location, dateGenerated);
                _journal.Add(entry);
            }
        }
        return $"Loaded {_journal.Count} entries.";
    }
}