using System;

class Resume{
    // Attributes
    public string name;
    public List<string> jobs = new List<string>();

    // Constructor
    public Resume(string name, List<string> jobs){
        this.name = name;
        this.jobs = jobs;
    }

    // Methods
    public void Display(){
        Console.WriteLine(name);
        foreach (string job in jobs){
            Console.WriteLine(job);
        }
    }
}