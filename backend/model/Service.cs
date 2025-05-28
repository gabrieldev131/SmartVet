using Date;
using Time;
using Animal;
using Veterinarian;
using Task;
namespace Service{
    public class Service{
        private int id { get; set; }
        private Date date { get; set; }
        private Time time { get; set; }
        private Animal animal { get; set; }
        private int urgency { get; set; }
        private Veterinarian veterinarian { get; set; }
        private string result { get; set; }
        private Task task;

        public string dateTimeToString(){}
        public void registerAttendance(){}
        public void addTask(Task task){}
        public float totalValue(){}
    }
}