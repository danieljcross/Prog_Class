using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int targetCount;
        private int currentCount;
        private int eventPoints;
        private int bonusPoints;

        public ChecklistGoal(string name, int eventPoints, int targetCount, int bonusPoints) : base(name)
        {
            this.eventPoints = eventPoints;
            this.targetCount = targetCount;
            this.bonusPoints = bonusPoints;
            currentCount = 0;
        }

        public override void RecordEvent()
        {
            if (currentCount < targetCount)
            {
                Points += eventPoints;
                currentCount++;
                if (currentCount == targetCount)
                {
                    Points += bonusPoints;
                    IsCompleted = true;
                }
            }
        }

        public override string GetProgress()
        {
            return base.GetProgress() + $" Completed {currentCount}/{targetCount} times";
        }
    }
}
