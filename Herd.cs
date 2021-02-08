using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        List<Dinosaur> dinosaurs;

        //constructor

        public Herd()
        {
            List<Dinosaur> dinosaurs = new List<Dinosaur>();
        }

        public void AddDinoToHerd(Dinosaur dino)
        {
            dinosaurs.Add(dino);
        }


    }
}
