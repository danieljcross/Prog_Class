using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public bool IsCompleted { get; set; }

        public Goal(string name)
        {
            Name = name;
            Points = 0;
            IsCompleted = false;
        }

        public abstract void RecordEvent();

        public virtual string GetProgress()
        {
            return IsCompleted ? "[X]" : "[ ]";
        }
    }
}
