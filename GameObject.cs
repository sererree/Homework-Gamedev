using System;
namespace kr22
{
	public abstract class GameObject
	{
		public int id;
		protected string name;
		protected bool isActive;

		public bool IsActive
		{
			get
			{
				return isActive;
			}
		}

		public void Enable()
		{
			isActive = true;
		}

		public void Disable()
		{
			isActive = false;
		}

		public abstract string Info();

		public GameObject(int id, string name, bool isActive)
		{
			this.id = id;
			this.name = name;
			this.isActive = isActive;
		}
	}
}

