using System;
namespace kr22
{
	public class Scene
	{
		private List<GameObject> objects;
        

        public List<GameObject> Objects { get { return objects; } }

		public void PrintAll()
		{
			for(int i=0; i<Objects.Count; i++)
			{
				Console.WriteLine(Objects[i].Info());

			}
		}

		public Scene(List<GameObject> objects)
		{
			this.objects = objects;
		}

       
    }
}

