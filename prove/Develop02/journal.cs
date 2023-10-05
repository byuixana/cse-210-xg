using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public Entry _entry;
    public List<Entry> _entryList;
    public string _filename;

    public Journal ()
    {
        _entryList = new List<Entry>();
    }
        public List<Entry> createList()
        {
            List<Entry> entryList = new List<Entry>();
            return entryList;
        }

        public List<Entry> addEntry(Entry entry)
        {
            _entryList.Add(entry);
            return _entryList;
        }
        
        //Writes to text file.
        public void CreateFile(string file)
        {
            Console.WriteLine("Saving to file...");
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                // You can add text to the file with the WriteLine method
                foreach (Entry entry in _entryList)
                {
                    outputFile.WriteLine(entry.entryFormat());
                }
                    
            }
        }

        public Journal LoadFile(string _filename)
        {
            Journal returned_entries = new Journal();

            string[] lines = System.IO.File.ReadAllLines(_filename);

            foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            return returned_entries;
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in _entryList)
            {
                entry.DisplayEntry();
            }
                
        }

        
        

    }

