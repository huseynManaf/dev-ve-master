namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int saniye = 273908;
            int gun = saniye / (24 * 60 * 60);
            int saat = (saniye - gun * 24 * 60 * 60) / (60 * 60);
            int deq = (saniye - gun * 24 * 60 * 60 - saat * 60 * 60) / 60;
            int san = saniye % 60;
            Console.WriteLine($"{gun} gun {saat} saat {deq}deqiqe {san} saniye");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("dev");
            Console.WriteLine("Hello, World!");
        }
    }
}