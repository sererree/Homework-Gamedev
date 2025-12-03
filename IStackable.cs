using System;
namespace dz6
{
	public interface IStackable
	{
        int Count { get; }
        void AddOne();
        void RemoveOne();

    }
}

