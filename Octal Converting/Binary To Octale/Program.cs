static int bin_to_oct(string b) {

    // decimal to onctal is easier
    int numberInDecimal = Convert.ToInt32(b, 2);

    // devide by 8, store the reminder, repeat with the result, but add the reminder in reverse
    // number   | result | reminder | octal
    // 1792	÷ 8 | 224    | 0        |	 0
    // 224	÷ 8 | 28     | 0        |   00
    // 28	÷ 8	| 3	     | 4        |  400
    // 3	÷ 8	| 0	     | 3        | 3400
    string octal = "";

    int numberLength = numberInDecimal.ToString().Length;
    for (int i = 1; i < numberLength + 2; i++) {
        octal += (numberInDecimal % 8) * Convert.ToInt32(Math.Pow(1, i));
        numberInDecimal /= 8;
    }
    
    // reversing the string
    char[] charArray = octal.ToCharArray();
    Array.Reverse(charArray);
    return Convert.ToInt32(new string(charArray));
}
    
// for testing the function
while (true) {
    try
    {
        string input = Console.ReadLine();
        if (input == "exit")
            break;
        Console.WriteLine(bin_to_oct(input));
    }
    catch (System.Exception e)
    {
        
        Console.WriteLine(e);
    }
}
    