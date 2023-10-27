public class Fighter
{
    public string name;
    public Weapon weapon; 
    public int hp = 100;

    public void Attack(Fighter enemy)
    {
        int damage = weapon.damageA();
        enemy.hp -= damage;
    }

}