using System;
namespace dz6
{
	public class Item
	{
		protected string name;
		protected string description;
        public string Name { get; set; }
        public string Description { get; set; }

        public Item(string name,  string description)
		{
			Name = name;
			Description = description;
		}

		public virtual void ShowInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(description);
        }
	}
}

