using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public List<Dinosaur> dinosaurs;

        //constructor

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            Dinosaur dino1 = new Dinosaur("T-Rex", 100, 100, 10);
            Dinosaur dino2 = new Dinosaur("Stegasaurous", 100, 100, 10);
            Dinosaur dino3 = new Dinosaur("Velociraptor", 100, 100, 10);
            AddDinoToHerd(dino1);
            AddDinoToHerd(dino2);
            AddDinoToHerd(dino3);
        }

        public void AddDinoToHerd(Dinosaur dino)
        {
            dinosaurs.Add(dino);
        }


    }
}
