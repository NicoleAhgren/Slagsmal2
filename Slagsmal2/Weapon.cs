public class Weapon
{
    public string name;
    public  int damage;
    Random generator = new Random();

    public int damageA()
    {
    return generator.Next(damage-15, damage +15);
   
    }
}