using System;
namespace dz6
{
	public interface ISellable
	{
        int Price { get; }
        void Sell(Character user);
    }
}

