using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        private int eventPoints;

        public EternalGoal(string name, int points) : base(name)
        {
            eventPoints = points;
        }

        public override void RecordEvent()
        {
            Points += eventPoints;
        }
    }
}
