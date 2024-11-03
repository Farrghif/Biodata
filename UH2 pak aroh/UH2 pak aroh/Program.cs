using System;
using System.Diagnostics;
using System.IO;

namespace BiodataApp
{
    public class Biodata
    {
        public string FullName { get; set; }
        
        public string Gender { get; set; }
        
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
       
        public string Education { get; set; }
        public string occupation { get; set; }

        public override string ToString()
        {
            return $"Full Name: {FullName}\n" +
                   
                   $"Gender: {Gender}\n" +
                  
                   $"Address: {Address}\n" +
                   $"Phone Number: {PhoneNumber}\n" +
                  
                   $"Education: {Education}\n" +
                   $"occupation: {occupation}\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Biodata biodata = new Biodata();

            // Collect biodata from user
            Console.WriteLine("Biodata Siswa/i:\n");

            Console.Write("Nama lengkap: ");
            biodata.FullName = Console.ReadLine();

           

            Console.Write("jenis kelamin: ");
            biodata.Gender = Console.ReadLine();

            

            Console.Write("Alamat: ");
            biodata.Address = Console.ReadLine();

            Console.Write("kelas: ");
            biodata.occupation = Console.ReadLine();

            Console.Write("No. HP: ");
            biodata.PhoneNumber = Console.ReadLine();

           

            Console.Write("Jurusan: ");
            biodata.Education = Console.ReadLine();

            

            // Save biodata to a file
            string fileName = "biodata.txt";
            File.WriteAllText(fileName, biodata.ToString());

            Console.WriteLine($"\nBiodata has been saved to {fileName}");

            Console.WriteLine("Tekan Enter untuk membuka file...");
            Console.ReadLine(); // Menunggu input Enter dari pengguna

            // Membuka file secara otomatis setelah menekan Enter
            Process.Start(new ProcessStartInfo("biodata.txt") { UseShellExecute = true });
        }
    }
}