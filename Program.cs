// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
class SimpleDataBase<T> { 
    private List<T> storedData;
    private List<DateTime> inputDates;
    public SimpleDataBase() {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void AddNewData(T newData) { //membuat data baru beserta tanggal/date nya
        storedData.Add(newData);
        DateTime now = DateTime.Now;
        inputDates.Add(now);
    }

    public void PrintAllData() { //print isi stored data
        for (int i = 0; i < storedData.Count; i++) {
            Console.WriteLine($"Data {i+1} berisi: {storedData[i]}, yang disimpan pada waktu {inputDates[i]}"); //output
        }
    }
}

class Program {
    private static void Main()
    {
        SimpleDataBase <float> db = new SimpleDataBase<float>();
        db.AddNewData(12);
        db.AddNewData(34);
        db.AddNewData(56);
        db.PrintAllData();
    }
}