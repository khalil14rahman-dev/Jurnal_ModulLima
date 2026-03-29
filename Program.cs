<<<<<<< HEAD
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

=======
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
>>>>>>> implementasi-generic-class
