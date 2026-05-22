using System;
namespace kr
{
	public interface IFilter<T>
	{
		bool Check(T item);
	}
}

