using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameAPICore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace GameAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {

        private readonly GameContext _context;

        public GameController(GameContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Games>>> GetAllGames()
        {
            return await _context.Games.ToListAsync();
        }

        [HttpPost]
        [Route("StartGame")]
        public ActionResult<string> StartGame(Games game)
        {
            try
            {

                game.Winner = GetWinner(game);          
                _context.Games.Add(game);
                _context.SaveChanges();

                var finalResult = JsonConvert.SerializeObject(game);

                return Content(finalResult);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private string GetWinner(Games game) {

            if (game.PlayerOneOption == game.PlayerTwoOption)
            {
                return null;
            }
            else if ((game.PlayerOneOption - game.PlayerTwoOption + 3) % 3 == 1)
            {
                return game.PlayerOneName;
            }
            else {
                return game.PlayerTwoName;
            }
        }
    }
}