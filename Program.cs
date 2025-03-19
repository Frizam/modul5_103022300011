class PemrosesData { 
    public void DapatkanNilaiTerbesar<T>(T data1, T data2, T data3) {
        dynamic temp1=(dynamic)data1;
        dynamic temp2 = (dynamic)data2;
        dynamic temp3=(dynamic)data3;
        if (temp1 > temp2) //perbandingan untuk mencari nilai MAX
        {
            Console.WriteLine("Nilai Max = " + temp1);
        }
        else if (temp2 > temp3) 
        { 
            Console.WriteLine("Nilai Max = " + temp2);
        } else
        {
            Console.WriteLine("Nilai Max = " + temp3);
        }
    }
}
class Program {
    private static void Main() {
        PemrosesData data = new PemrosesData();

        data.DapatkanNilaiTerbesar(12, 34, 56);
        SimpleDataBase <float> db = new SimpleDataBase<float>();
        db.AddNewData(12);
        db.AddNewData(34);
        db.AddNewData(56);
        db.PrintAllData();
    }
}



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

