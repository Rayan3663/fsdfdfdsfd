namespace foodOrderingSystem.DTO_s
{
    public class characterDto
    {
        public string Name { get; set; }
        public backPackDto backPack { get; set; }
        public List<weaponsDto> weapons { get; set; }

        public List<FactionsDTO> factions { get; set; }
    }
}
