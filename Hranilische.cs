using System;
namespace kr
{
	public delegate void HranilischeEvent<T>(T item);

	public class Hranilische<T>
	{
		private readonly List<T> items = new List<T>();


		public event HranilischeEvent<T> LoadItem;
		public event HranilischeEvent<T> SelectItem;

		public void Add(T item)
		{
			items.Add(item);
			LoadItem?.Invoke(item);
		}


		public IEnumerable<T> Filter(IFilter<T> filter)
		{
			foreach(var item in items)
			{
				if(filter.Check(item))
				{
					SelectItem?.Invoke(item);
					yield return item;
					
				}
			}



		}
		public Hranilische()
		{
		}
	}
}

