using foodOrderingSystem.data;
using foodOrderingSystem.DTO_s;
using foodOrderingSystem.MainDTO;
using foodOrderingSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace foodOrderingSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharactersController : Controller
    {

        private readonly AppDBContext _context;
        public CharactersController(AppDBContext context) 
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> getCharacter()
        {
            return Ok(await _context.characters.Include(c => c.BackPack).ToListAsync());

        }


        [HttpPost]

        public IActionResult putCharacter(characterDto charac)
        {

            var character = new Character
            {
                Name = charac.Name,

            };

            var backpack = new BackPack
            {
                Description = charac.backPack.description,
                Character = character,
                CharacterID = character.Id

            };

            character.BackPack = backpack;

            var weapon1 = charac.weapons.Select(w => new Weapon { Name = w.name, Character = character }).ToList();

            character.Weapons = weapon1;

            var factions1 = charac.factions.Select(f => new Faction { Name = f.name, Characters = new List<Character> { character } });

            character.Factions = factions1.ToList();
            _context.characters.Add(character);
            _context.SaveChanges();

            return Ok(_context.characters.ToList());
        }

        
    }
}
