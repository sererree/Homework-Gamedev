using System;
using System.Xml.Linq;

namespace kr22
{
    public class Trap : GameObject, IInteractable, IDamageable
    {
        private int damage = 10;
		public Trap(int id, string name, bool isActive) : base(id, name, isActive)
        {
		}

        public void ApplyDamage(int amount)
        {
            
        }

        public override string Info()
        {
            return $"Name {name}   Id {id}";
        }

        public string Interact(Player player)
        {
            player.hp -= damage;
            this.Disable();
            return $"The {player} took {damage} damage";
        }

        
    }
}

