using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Heroes
{
    internal class Priest : BlankCharacter
    {
        public Priest(int health, int strengh, int defense) : base(health, strengh, defense)
        {
            className = "Priest";
            charName = GenerateName(random.Next(4, 8));
        }
        public override void HitEnemy(BlankCharacter enemy)
        {
            if (random.Next(2) > 1)
            {
                if (random.Next(10) >= 10)
                {
                    Console.WriteLine($"{CharInfo()} повышает XP {CharInfo()}", Console.ForegroundColor = ConsoleColor.Red);
                    enemy.TakeDamage(totalHealth + totalHealth * random.Next(20, 50) / 100);
                    Console.ResetColor();
                }
                else
                {
                    base.HitEnemy(enemy);
                }
            }
            else
            {
                if (random.Next(10) >= 10)
                {
                    Console.WriteLine($"{CharInfo()} повышает XP {enemy.CharInfo()}", Console.ForegroundColor = ConsoleColor.Red);
                    enemy.TakeDamage(totalHealth + totalHealth * random.Next(20, 50) / 100);
                    Console.ResetColor();
                }
                else
                {
                    base.HitEnemy(enemy);
                }
            }
        }
    }
}
