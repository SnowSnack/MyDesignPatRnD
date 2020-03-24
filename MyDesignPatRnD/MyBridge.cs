using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPatRnD
{
    abstract class Unit
    {
        string name;
    }

    interface Champion
    {
        void SkillR();
    }

    interface Minion
    {
        void Attack();
    }

    class Aatrox : Unit, Champion
    {
        public void SkillR()
        {

        }
    }

    class MyBridge
    {
        
    }
}
