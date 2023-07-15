using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEMROG.PERTEMUAN9
{
    public class Ayam : IAnimals
    {
        public void Speak(Hewan hewan)
        {
            Console.WriteLine("PETOKK PETOKK");
        }
    }
}