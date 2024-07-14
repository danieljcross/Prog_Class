using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private int completionPoints;

        public SimpleGoal(string name, int points) : base(name)
        {
            completionPoints = points;
        }

        public override void RecordEvent()
        {
            if (!IsCompleted)
            {
                Points += completionPoints;
                IsCompleted = true;
            }
        }
    }
}
