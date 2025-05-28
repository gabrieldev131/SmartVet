using User;
using Animal;
using System.Collections.Generic;

namespace Custumer{
    public class Custumer: User{
        private string cpf { get; set; }
        private string tell { get; set; }
        private string andress { get; set; }
        private List<Animal> animals;

        public void registerCustumer(){}
        public void updateData(){}
        public void listAnimals(Animal animal){}
    }
}