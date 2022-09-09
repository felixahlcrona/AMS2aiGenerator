namespace AMS2aiGenerator.Models
{
    public class Driver
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public string livery_name { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public float race_skill { get; set; }
        public float qualifying_skill { get; set; }

    }

    public class Presets
    {
        public List<string> countries { get; set; }
        public List<string> liveries { get; set; }
    }
}
