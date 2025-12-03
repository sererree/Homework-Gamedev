using System;
namespace magic
{
	public  abstract class Effect
	{
		protected string name;
		protected int duration;

		public Effect(string name, int duration)
		{
			this.name = name;
			this.duration = duration;
		}
        public string Name { get { return name; } }
        public int Duration { get { return duration; } }
		

        public void DurationTime()
		{
			
			if(duration>0)
			{
				duration--;
			}


		}


		public abstract void Apply(Character character);

		public abstract void Turn(Character character);

		public abstract void End(Character character);
	}
}

