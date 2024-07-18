public class DisplayRound{
    // Constructors
    public DisplayRound(Bank bank, Blanks blanks, string secretWord){
        this.bank = bank;
        this.blanks = blanks;
        this.secretWord = secretWord;
    }

    // Attributes
        Bank bank;
        Blanks blanks;
        string secretWord;

    // Methods
    public void Display(){
        bank.DisplayBank();
        blanks.DisplayBlanks();
    }

}