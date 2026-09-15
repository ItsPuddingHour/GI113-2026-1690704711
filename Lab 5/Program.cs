/*
 * Student ID : 1690704711
 * Name       : ปรมัตถ์ รักศรี
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab05

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-title
            Console.WriteLine("==>> LIMITLESS FANTASY <<==");
            Console.WriteLine("Hero vs. Monster -- Fight Damage Calculator");


            // Hero stats input
            Console.WriteLine("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);


            // Monster stats input
            Console.WriteLine("Monster Health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.WriteLine("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.WriteLine("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            // Input validation / output
            bool heroStatValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monStatValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"\n HERO STAT: {heroStatValid}");
            Console.WriteLine($"MONSTER STAT: {monStatValid}");

            Console.WriteLine($"[HERO]     HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]     HP: {monHp} ATK: {monAtk} DEF: {monDef}");

            //bool allStatOk = heroStatValid && monStatValid;

            // Compoud Assign & Arithmetic ( + ) ผูเล่นดื่มยาก่อนต่อสู้
            int potionHeal = 10;

            heroHp += potionHeal;              //1. เเบบสั้น (เเนะนำ) นำ HP Hero มา + กับ Potion
            // heroHp = heroHp + potionHeal;   //2. เเบบยาว
            Console.WriteLine($"\nHero drinks a poiton, heals {potionHeal} HP. Hero Hp: {heroHp}");

            // Normal Attack RPG Style Combat ATK > DEF ถึงจะมี Damage ต่อศัตรู
            int normalDmg = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"Hero would deals normal attack: {normalDmg}");
            // Power Attack
            int powerDmg = Math.Max(0, (heroAtk * 2) - monDef); // ใส่วงเล็บบังคับให้ทำก่อนก็ได้
            Console.WriteLine($"Hero would deals power attack: {powerDmg}");

            // Random Critical Attack
            Random RNG = new Random();
            int critRoll = RNG.Next(1, 100 + 1); // อยากสุ่มโอกาสจาก 100%
            bool isCrit = critRoll <= 30; // 30% Chance of Critical

            int critDmg = normalDmg + Convert.ToInt32(isCrit) * normalDmg; // ถ้าอยากได้ x2
            Console.WriteLine($"Crit roll {critRoll}. Critical Hit: {isCrit}");
            Console.WriteLine("If critical hit player would deal {critDmg} DMG!!");

        }
    }
}