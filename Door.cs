using System;
namespace kr22
{
	public class Door : GameObject,IInteractable
	{
        private bool requiredAccess;


        public Door(int id, string name, bool isActive) : base(id,name,isActive)
		{
            this.id = id;
            this.name = name;
            this.isActive = isActive;
		}

        public override string Info()
        {
            return $"Name {name}   Id {id}";
        }

        public string Interact(Player player)
        {
            if(player.HasAcessard == true)
            {
                return "Door opened";
                this.Disable();
            }
            else { return "Access denied"; }
        }
    }
}

