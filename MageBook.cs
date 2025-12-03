using System;
namespace magic
{
	public class MageBook
	{
		private string name = "Книга заклинаний";
		private string description = "Это список доступных заклинаний";
		public MageBook(string name, string description)
		{
			this.name = name;
			this.description = description;
		}
	}
}

