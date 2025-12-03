using System;
namespace magic
{
	public class Fireball : Spell
	{
        private string name = "Огненный шар";
        private string description = "Наносит урон";
        private int damage;
        private int burnChance;
        public Fireball( int damage = 5, int burnChance=30,int cooldown =3) : base("Огненный шар", "Наносит урон  с шансом поджечь цель",cooldown)
        {
            this.damage = damage;
            this.burnChance = burnChance;
        }

        public override void SpellCast(Character character)
        {
            if(character.IsDead == false)
            {
                
                character.Damage(damage);
                Console.WriteLine($"{character.Name} получает {damage} урона");

                Random random = new Random();
                if(random.Next(100)<burnChance)
                {
                    Console.WriteLine($"{character.Name} подожжен ");

                    Burning burning = new Burning(2, 2);
                    burning.Apply(character);
                    character.AddEffect(burning);

                }
                else
                {
                    Console.WriteLine($"{character.Name}  не подожжен ");
                }
                StartCooldown();
            }
        }
        public override void SpellInfo()
        {
            base.SpellInfo();
        }
    }
}

