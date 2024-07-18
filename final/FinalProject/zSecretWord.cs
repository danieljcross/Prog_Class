public class SecretWord{
    // Constructors
    public SecretWord(){

    }

    // Attributes
    private List<string> wordsBank = new List<string>{"apple", "grape", "plumb", "table", "chair", "beach", "brave", "house", "flame", "grass", "quick", "stone", "candy", "laugh", "music", "light", "paint", "river", "horse", "cloud"};

    // Methods
    public string GetRandomWord(){
        Random random = new();
        int randomNumber = random.Next(wordsBank.Count());
        return wordsBank[randomNumber];
    }

}