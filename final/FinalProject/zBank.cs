public class Bank{
    // Constructors
    public Bank(){

    }

    // Attributes
    char[] alphabet = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};


    // Methods
    public void DisplayBank(){
        int count = 0;
        foreach (char letter in alphabet){
            if (count != 12 || count != 25){
                count++;
                Console.Write($"{letter} ");
            }
            else{
                count++;
                Console.WriteLine($"{letter}");
            }
        }
    }
}