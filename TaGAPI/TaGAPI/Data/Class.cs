using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaGUtil;
namespace TaGAPI.Data
{
    public class MockCommanderRepo : IComanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {

                new Command  { Id = 0, HowTo = "Crear un anuncio", Line = "Para eventos de juegos", Platform = "PC"},
                new Command { Id = 1, HowTo = "Crear un Pagina de juego", Line = "Desarrollador indie", Platform = "PC" }



              };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Crear un anuncio", Line = "Para eventos de juegos", Platform = "PC" };
        }

    }
        
}

