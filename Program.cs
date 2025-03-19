// See https://aka.ms/new-console-template for more information
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
    }
}



