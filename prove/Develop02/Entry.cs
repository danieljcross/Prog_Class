class Entry
{
    private List<string> prompts = new List<string>(["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What made you leave your house today?", "What did you do to go above and beyond today?"]);

    public string prompt { get; set; }

    public string content { get; set; }

    public Entry()
    {
        Random random = new Random();
        int randomInt = random.Next(0, prompts.Count-1);
        this.prompt = prompts[randomInt];
    }

    override public string ToString(){
        return $"{this.prompt}\n{this.content}\n";
    }
}