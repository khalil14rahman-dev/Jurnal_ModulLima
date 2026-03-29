public class Penjumlahan
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

