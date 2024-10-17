namespace Assg_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            int value = 10;

            Console.WriteLine($"Original value is {value}");

            ModifyByValue(value);
            Console.WriteLine($"Value after ModifybyValue {value}");

            ModifyByReference(ref value);
            Console.WriteLine($"Value after ModifybyReference {value}");   
        }

        void ModifyByValue(int value)
        {
            value = value + value;
        }

        void ModifyByReference(ref int value)
        {
            value = value + value;
        }
    }
}
