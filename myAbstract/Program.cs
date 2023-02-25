using System;
namespace Vegtables
{
    abstract class Vegtable
    {
        public abstract string Name { get; set;}
        public abstract string Description();
        public string IAm() 
        { 
            return "I'm a vegtable"; 
        }
    }
    class Program
    {
        class Tomatoe : Vegtable
        {
            public override string Name { get; set; }
            public string Type { get; set; }
            public string Color { get; set; }

            public Tomatoe()
            {
                Name = string.Empty;
                Type = string.Empty;
                Color = string.Empty;
            }
            public Tomatoe(string name, string type, string color)
            {
                Name = name;
                Type = type;
                Color = color;
            }
            public override string Description()
            {
                return "I am the color " + Color + "\nType: " + Type + "\nI am a " + Name;
            }
        }
        static void Main(string[] args)
        {
            Tomatoe broccoli = new Tomatoe();
            broccoli.Name = "Broccoli";
            broccoli.Type = "Bonarda";
            broccoli.Color = "Purple";
            Console.WriteLine(broccoli.IAm());
            Console.WriteLine(broccoli.Description());
        }
    }
}
