using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOProject.DTO
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        List<string> listAnswerOfPlayer { get; set; }
        public Player()
        {
            listAnswerOfPlayer = new List<string>();
        }
    }
}
