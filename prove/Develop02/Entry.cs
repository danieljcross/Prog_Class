class Entry
{
    private List<string> prompts = new List<string>(["Question 1", "Question 2"]);

    public string prompt { get; set; }

    public string content { get; set; }

    public Entry()
    {
        // TODO: Random number generator based on the size of prompts, chosing a number that can be put
        // in place of the [0]
        this.prompt = prompts[0];
    }

    override public string ToString(){
        return $"{this.prompt}\n{this.content}";
    }
}