using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Friend : Character
    {
        public Friend()
        {

        }

        public Friend(string name)
            :base(name)
        {

        }

        public override void Hit(Character characterToHit, int damage)
        {
            characterToHit.hitPoints += damage;
        }
    }
}
