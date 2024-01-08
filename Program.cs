using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "9876-7854", modelo: "1987 new games", imei: "034927571203", memoria: 92);
        nokia.Ligar();
        nokia.InstalarAplicativo("Snake Game");

        Console.WriteLine("\n");


        Console.WriteLine("Smartphone Iphone");
        Smartphone iphone = new Iphone(numero: "0076-4398", modelo: "iphone 8", imei: "456170942378534", memoria: 2);
        iphone.Ligar();
        iphone.InstalarAplicativo("HillClibing Race");
    }

}