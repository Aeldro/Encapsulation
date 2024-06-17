namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                BeerEncapsulator beerEncapulator = new BeerEncapsulator();

                while (beerEncapulator.GetBottles() < 0)
                {
                    Console.WriteLine("Combien de bouteilles sont disponibles?");
                    beerEncapulator.SetBottles(Convert.ToInt32(Console.ReadLine()));
                }

                while (beerEncapulator.GetCapsules() < 0)
                {
                    Console.WriteLine("Combien de capsules sont disponibles?");
                    beerEncapulator.SetCapsules(Convert.ToInt32(Console.ReadLine()));
                }

                while (beerEncapulator.GetBeerVolume() < 0)
                {
                    Console.WriteLine("Combien de litres de bières voulez-vous ajouter à la machine?");
                    beerEncapulator.AddBeer(Convert.ToDouble(Console.ReadLine()));
                }

                Console.WriteLine("Combien de bouteilles voulez vous encapsuler?");
                int encapsulation = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{beerEncapulator.ProduceEncapsulatedBeerBottles(encapsulation)} bouteilles encapsulées.");
            }
        }
    }
}
