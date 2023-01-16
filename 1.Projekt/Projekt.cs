using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace Projekt
{
    class Projekt {         
        static void Main(string[] args)
        {
            
            int optionSelect;
            int idWriter;
            List<Writer> writerList = new List<Writer>();
            writerList.Add(new Writer ("William", "Shakespeare",42));
            writerList.Add(new Writer ("Agatha", "Christie",85));
            do{
                Console.Clear();
                Console.WriteLine("----  Izbornik ----");
                Console.WriteLine("1. Novi pisac");
                Console.WriteLine("2. Ispis svih unesenih pisaca");
                Console.WriteLine("3. Ispis trazenog pisca po imenu");
                Console.WriteLine("4. Pisanje knjige");
                Console.WriteLine("5. Pisac says hello");
                Console.WriteLine("6. Exit program");
                Console.WriteLine("");
                Console.Write("Odaberite jednu od opcija: ");
                optionSelect =Convert.ToInt32(Console.ReadLine()); 
                switch (optionSelect)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ime novog pisca: ");
                        String newFirstName = Console.ReadLine();
                        Console.Write("Prezime novog pisca: ");
                        String newLastName = Console.ReadLine();
                        Console.Write("broj napisanih knjiga novog pisca: ");
                        int newNumberOfBooks = Convert.ToInt32(Console.ReadLine());
                        writerList.Add(new Writer(newFirstName,newLastName,newNumberOfBooks));
                        break;
                    case 2:
                        Console.Clear();
                        listOutput(writerList);
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Ime trazenog prisca: ");
                        String lookedForWriterName = Console.ReadLine();
                        var lookedForWriter = writerList.Where(writer => writer.FirstName == lookedForWriterName || writer.LastName == lookedForWriterName);
                        foreach(var foundWriter in lookedForWriter) Console.WriteLine(foundWriter.FirstName + " " + foundWriter.LastName + " wrote " + foundWriter.NumberOfBooks + " books");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        listOutput(writerList);
                        Console.WriteLine("");
                        Console.Write("Odaberite koji ce pisac krenuti pisati knjigu: ");
                        idWriter = Convert.ToInt32(Console.ReadLine());
                        writerList[idWriter].work();
                        break;

                    case 5:
                        Console.Clear();
                        listOutput(writerList);
                        Console.WriteLine("");
                        Console.Write("Odaberite koji ce pisac ce pozdraviti: ");
                        idWriter = Convert.ToInt32(Console.ReadLine());
                        Console.Write(writerList[idWriter].FirstName + " " + writerList[idWriter].LastName + " kaze" );
                        writerList[idWriter].sayHello();
                        Console.ReadLine();
                        break;

                    case 6:
                        break;

                    default:
                        break;
                }
            }while (optionSelect != 6);

            
        }

        public static void listOutput(List<Writer> writerList){
            int idWriter = 0; 
            foreach (var writer in writerList)
            {
                Console.WriteLine(idWriter + ". " + writer.FirstName + " " + writer.LastName + " wrote " + writer.NumberOfBooks + " books" );
                idWriter++;
            }
        }

    }
}