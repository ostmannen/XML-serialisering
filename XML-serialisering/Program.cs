using System;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace XML_serialisering
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon sword = new Weapon();
            sword.damage = 10f;
            sword.reach = 2f;
            sword.cost = 100;
            sword.name = Console.ReadLine();
            System.Console.WriteLine(sword.name);
            Console.ReadLine();

            XmlSerializer serializer = new XmlSerializer(typeof(Weapon));
            FileStream file = File.Open(@"Weapon.xml", FileMode.OpenOrCreate);
            serializer.Serialize(file, sword);
            file.Close();
        }
    }
}
