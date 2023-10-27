Fighter fighter1 = new();

fighter1.weapon = new();
fighter1.weapon.name = "Gun";
fighter1.weapon.damage = 15;


Fighter fighter2 = new();

fighter2.weapon = new();
fighter2.weapon.name = "Gun";
fighter2.weapon.damage = 15;

Console.WriteLine("Name fighter 1");
Console.ReadLine();

Console.WriteLine("Name fighter 2");
Console.ReadLine();
Console.Clear();

while(fighter1.hp <= 0 || fighter2.hp <= 0)
{
    Console.WriteLine($"{fighter1.name} hp = {fighter1.hp} || Fighter2 hp = {fighter2.hp}");
    fighter1.Attack(fighter2);
    Console.WriteLine($"{fighter1.name} made {fighter1.weapon.damageA} damage");
    fighter2.Attack(fighter1);
    Console.WriteLine($"{fighter2.name} made {fighter2.weapon.damageA} damage");

    Console.WriteLine("Press ENTER to continue");
    Console.ReadLine();
    Console.Clear();

}
if(fighter1.hp <= 0)
{
    Console.WriteLine($"{fighter1.name} died");

}
else
{
    Console.WriteLine($"{fighter2.name} died");
}

Console.ReadLine();