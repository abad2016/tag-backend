using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaGAPI.Data;
using TaGUtil;

namespace TaGAPI.Controller
{
    [Route("api/commands")]
    [ApiController]
    public class CommanderController : ControllerBase
    {


        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        }


        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}
