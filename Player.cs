using System;
namespace kr22
{
	public class Player
	{
		public int hp;
		private bool hasAcessard; //имеет доступ?
		public int lastCheckpointId;

		public int Hp
		{
			get
			{
				return hp;
			}
		}
		public bool HasAcessard
		{
			get { return hasAcessard; }
		}
		public int LastCheckpointId
		{
			get { return lastCheckpointId; }
		}
        public Player(int hp)
		{
			this.hp = hp;
		}
	}
}

