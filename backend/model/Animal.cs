using Custumer;
using Date;
using Service;
namespace Animal{
    public class Animal{
        private int id { get; set; }
        private Custumer owner { get; set; }
        private string name { get; set; }
        private string specie { get; set; }
        private Date yearBirth;
        private string breed { get; set; }
        private float weight { get; set; }

        public void registerAnimal(){}
        public void updateData(){}
        public Service checkHistoric(){}
    }
}