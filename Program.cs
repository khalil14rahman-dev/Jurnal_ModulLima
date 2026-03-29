
﻿public class Penjumlahan
{
    /// <summary>
    /// Method Generic untuk menjumlahkan tiga angka.
    /// NIM akhiran 3 menggunakan tipe data double.
    /// </summary>
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        // Menggunakan dynamic agar bisa melakukan operasi '+' pada tipe generic
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        dynamic hasil = a + b + c;
        Console.WriteLine($"Hasil penjumlahan: {hasil}");
    }
}
﻿public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            // Format output sesuai permintaan jurnal
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Aturan NIM akhiran 3: Tipe data DOUBLE
        // Angka input: 33 (dari 2-digit terakhir NIM)
        double myNim = 33.0;

        Console.WriteLine("=== Output Bagian 4: Generic Method ===");
        Penjumlahan p = new Penjumlahan();
        p.JumlahTigaAngka<double>(myNim, myNim, myNim);

        Console.WriteLine("\n=== Output Bagian 6: Generic Class ===");
        SimpleDataBase<double> db = new SimpleDataBase<double>();
        db.AddNewData(myNim);
        db.AddNewData(myNim);
        db.AddNewData(myNim);
        db.PrintAllData();

        Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
        Console.ReadKey();
    }
}