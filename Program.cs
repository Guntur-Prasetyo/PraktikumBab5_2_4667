Console.WriteLine("Masukkan tarif perjam: ");
int tarifperjam = int.Parse(Console.ReadLine());

Console.WriteLine("Masukkan lama penggunaan: ");
int lamapenggunaan = int.Parse(Console.ReadLine());

int totalBiaya = tarifperjam * lamapenggunaan;

Console.WriteLine($"Lama penggunaan = {lamapenggunaan} jam");
Console.WriteLine($"Tarif perjam = {tarifperjam}");
Console.WriteLine($"Total biaya = {totalBiaya}");
