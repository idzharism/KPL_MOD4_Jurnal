// See https://aka.ms/new-console-template for more information
using System;

namespace modul4_1302190047;

public class MainClass
{
    public static void Main(string[] args)
    {
        // NIM = 1302190047
        Penjumlahan.JumlahTigaAngka<int>(13, 02, 20);
       
    }
}
public class Penjumlahan
{
    public static void JumlahTigaAngka<T>(T data1, T data2, T data3)
    {
        dynamic angka1 = data1;
        dynamic angka2 = data2;
        dynamic angka3 = data3;

        Console.WriteLine(angka1 + angka2 + angka3 + "\n");

    }
};