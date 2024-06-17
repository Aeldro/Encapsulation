using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class BeerEncapsulator
    {
        private double _avalaibleBeerVolume = -1;
        private int _avalaibleBottles = -1;
        private int _avalaibleCapsules = -1;

        public int GetBottles() { return _avalaibleBottles; }
        public int GetCapsules() { return _avalaibleCapsules; }
        public double GetBeerVolume() { return _avalaibleBeerVolume; }
        public void SetBottles(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Le nombre de bouteilles ne peut pas être négatif.");
            }
            else
            {
                _avalaibleBottles = number;
            }
        }
        public void SetCapsules(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Le nombre de capsules ne peut pas être négatif.");
            }
            else
            {
                _avalaibleCapsules = number;
            }
        }

        public void AddBeer(double quantity) { _avalaibleBeerVolume = _avalaibleBeerVolume + (quantity * 100); }
        public int ProduceEncapsulatedBeerBottles(int number)
        {
            if (_avalaibleBottles < number)
            {
                Console.WriteLine($"Nombre de bouteilles insuffisant. Veuillez en rajouter au moins {number - _avalaibleBottles}.");
                return 0;
            }
            else if (_avalaibleCapsules < number)
            {
                Console.WriteLine($"Nombre de capsules insuffisant. Veuillez en rajouter au moins {number - _avalaibleCapsules}.");
                return 0;
            }
            else if (_avalaibleBeerVolume < 33 * number)
            {
                Console.WriteLine($"Quantité de bière insuffisante. Veuillez rajouter au moins {(number * 33) - (_avalaibleBeerVolume)}cl.");
                return 0;
            }
            else
            {
                _avalaibleCapsules--;
                _avalaibleBottles--;
                _avalaibleBeerVolume = _avalaibleBeerVolume - (33 * number);
                return number;
            }
        }
    }
}
