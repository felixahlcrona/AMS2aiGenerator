namespace AMS2aiGenerator.Models
{
    public class Driver
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public string series { get; set; }
        public string livery_name { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public float race_skill { get; set; }
        public float qualifying_skill { get; set; }

    }



    public class PresetList
    {
        public string series { get; set; }
        public string drivers { get; set; }
        public string countries { get; set; }
        public string liveries { get; set; }
    }
}
