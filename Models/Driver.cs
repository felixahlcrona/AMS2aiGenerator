using System.ComponentModel;

namespace AMS2aiGenerator.Models
{
    public class Driver
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Guid guid { get; set; }
        public string raceClass { get; set; }
        public string car { get; set; }
        public string livery_name { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public float race_skill { get; set; }
        public float qualifying_skill { get; set; }

        public float aggression { get; set; }
        public float defending { get; set; }
        public float stamina { get; set; }
        public float consistency { get; set; }
        public float start_reactions { get; set; }
        public float wet_skill { get; set; }
        public float tyre_management { get; set; }
        public float blue_flag_conceding { get; set; }
        [DisplayName("Weather tyre changes")]
        public float weather_tyre_changes { get; set; }

    }



    public class PresetList
    {
        public string raceClass { get; set; }
        public string cars { get; set; }
        public string drivers { get; set; }
        public string countries { get; set; }
        public string liveries { get; set; }
        public string xmlFileName { get; set; }
    }
}
