using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Heroes
{
    internal class BossGoblin : BlankCharacter
    {
        public BossGoblin(int health, int strengh, int defense) : base(health, strengh, defense)
        {
            className = "BossGoblin";
            charName = GenerateName(random.Next(4, 8));
        }
        public override void HitEnemy(BlankCharacter enemy)
        {
            if (random.Next(2) > 1)
            {
                if (random.Next(10) >= 10)
                {
                    Console.WriteLine($"{CharInfo()} бъёт дубиной по {enemy.CharInfo()}", Console.ForegroundColor = ConsoleColor.Red);
                    enemy.TakeDamage(totalStrengh + totalStrengh * random.Next(50, 100) / 100);
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
                    Console.WriteLine($"{CharInfo()} ставит тотем гоблина", Console.ForegroundColor = ConsoleColor.Red);
                    enemy.TakeDamage(totalDefense + totalDefense * random.Next(20, 40) / 100);
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
