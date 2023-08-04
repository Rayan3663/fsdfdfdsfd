using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foodOrderingSystem.models
{
    public class BackPack
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        [ForeignKey("Character")]
        public int CharacterID { get; set; }
        public Character Character { get; set; }
    }
}
