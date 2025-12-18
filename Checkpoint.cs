using System;
namespace kr22
{
	public class Checkpoint : GameObject, IInteractable
    {
		public Checkpoint(int id, string name, bool isActive) : base(id,name,isActive)
		{

		}

        public override string Info()
        {
            return $"Name {name}   Id {id}";
       
        }

        public string Interact(Player player)
        {
           player.lastCheckpointId = id ;
            return "Id is saved";
        }

    }
}

