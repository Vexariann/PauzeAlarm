namespace PauzeAlarm
{
    public class Pauze
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public string FirstTime { get; set; }
        public string FullName
        {
            get { return Time + " - " + Name; }
        }
    }
}
