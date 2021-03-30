using System;

namespace KlassExempel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Om en klass och dess metoder är static 
            så kan man kalla på den på följande sätt
            
             Här anger jag först klassens namn (Person)
            följt av en . och sedan namnet på metoden
            
             Både klassen, metoden och eventuella klassmedlemmar 
            så som variabler måste vara static för att allt ska kunna nås*/

            Person.Name = "Benny";
            Person.Jump();
            


            /*
             Om jag inte har satt klassen som static så kan jag 
            instansiera ett objekt av klassen. Det innebär att jag sedan kan
            arbeta med och manipulera objektet senare i koden, vilket kan vara trevligt.
            Första raden beskrivet: Dog är namnet på klassen och bestämmer vilken
            typ objektet kommer att vara. Allt du skapar är av olika typer. 
            int siffra = 1; är av typen integer och kan innehålla heltal
            string text = "En text"; är av typen string och kan innehålla textsträngar
            i vårt fall så är Dog hund av typen Dog (Vi har alltså skapat upp en ny typ som 
            kan innehålla vad vi specificerat i klassen Dog).
            Så på första raden säger vi att vi ska reservera plats i minnet för en Dog 
            som vi döper till Hund. Sedan sätter vi ett likamed tecken och 
            säger att nu skapar vi upp en new Dog()

            Den går nu använda genom att skriva hund.MetodnamnetDuVillKallaPå()

            Andra raden sätter vi hundens namn till Fido. Klassen Dog innehåller ett klassfält som heter
            Name. Detta kan vi nu komma åt att ändra eftersom 
            den är public och det finns en set del i den.
            Så hund.Name = betyder att vi tilldelar den ett värde
            Console.WriteLine(hund.Name); betyder att vi skriver ut namnet

            Sedan kallar vi på metoden Bark som finns i klassen Dog. 
            Instansen av Dog som vi skapade döpte vi ju till hund.
            Därför skriver vi hund.Bark() och all kod inom Bark metoden kommer att köras.*/
            Dog hund = new Dog();
            hund.Name = "Fido";
            hund.Bark();
            Console.ReadKey();

        }
    }
}
