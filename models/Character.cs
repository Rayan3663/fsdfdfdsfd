using System.Text.Json.Serialization;

namespace foodOrderingSystem.models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public BackPack BackPack { get; set; }

        public List<Faction> Factions { get; set; }

        public List<Weapon> Weapons { get; set; }

    }
}
