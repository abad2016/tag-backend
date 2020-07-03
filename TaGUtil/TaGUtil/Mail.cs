using System;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace TaGUtil
{
 
    
        public class Command
        {
            public int Id { get; set; }
            public string HowTo { get; set; }
            public string Line { get; set; }
            public string Platform { get; set; }
        }

}
