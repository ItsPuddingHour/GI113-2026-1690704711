/*
 * Student ID : 1690704711
 * Name       : ปรมัตถ์ รักศรี
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GAME TITLE: HeroVersusMonster");
            Console.WriteLine("=== HERO VS MONSTER : ONE-ROUND TURN JUDGE ===");

            int heroHp = 0;
            int heroAtk = 0;
            int monsterHp = 0;
            int monsterAtk = 0;

            // 1. รับค่า Hero HP
            Console.Write("Enter Hero HP: ");
            string inputHeroHp = Console.ReadLine();
            bool isHeroHpValid = int.TryParse(inputHeroHp, out heroHp);

            // 2. รับค่า Hero Attack
            Console.Write("Enter Hero Attack: ");
            string inputHeroAtk = Console.ReadLine();
            bool isHeroAtkValid = int.TryParse(inputHeroAtk, out heroAtk);

            // 3. รับค่า Monster HP
            Console.Write("Enter Monster HP: ");
            string inputMonsterHp = Console.ReadLine();
            bool isMonsterHpValid = int.TryParse(inputMonsterHp, out monsterHp);

            // 4. รับค่า Monster Attack
            Console.Write("Enter Monster Attack: ");
            string inputMonsterAtk = Console.ReadLine();
            bool isMonsterAtkValid = int.TryParse(inputMonsterAtk, out monsterAtk);

            // ตรวจสอบความถูกต้องของ Input
            if (!isHeroHpValid || !isHeroAtkValid || !isMonsterHpValid || !isMonsterAtkValid)
            {
                Console.WriteLine("Invalid input! Please enter valid numbers.");
            }
            else
            {
                Console.WriteLine("\n--- Battle Result ---");

                // Hero โจมตี Monster
                monsterHp = monsterHp - heroAtk;
                Console.WriteLine("Hero attacks Monster for " + heroAtk + " damage. (Monster HP: " + monsterHp + ")");

                // Monster โจมตี Hero เฉพาะเมื่อ Monster ยังไม่ตาย
                if (monsterHp > 0)
                {
                    heroHp = heroHp - monsterAtk;
                    Console.WriteLine("Monster attacks Hero for " + monsterAtk + " damage. (Hero HP: " + heroHp + ")");
                }

                Console.WriteLine("\n--- Turn Judgment ---");

                // ตัดสินผลใน 1 เทิร์นด้วยเงื่อนไข If-Else
                if (heroHp <= 0 && monsterHp <= 0)
                {
                    Console.WriteLine("Both Hero and Monster defeated each other! It's a Draw!");
                }
                else if (monsterHp <= 0)
                {
                    Console.WriteLine("Monster is defeated! Hero Wins!");
                }
                else if (heroHp <= 0)
                {
                    Console.WriteLine("Hero is defeated! Monster Wins!");
                }
                else
                {
                    Console.WriteLine("Both Hero and Monster are still alive. Proceeding to next turn!");
                }
            }
        }
    }
}