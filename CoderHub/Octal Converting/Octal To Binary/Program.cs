string oct_to_bin(int octal) {
    // multiply first number by 8 to the power of the zeros of that digit, and add up
    // octal | firstNum | operation | decimal
    // 3400  | 3        | * 8^3     | 1536
    //  400  | 4        | * 8^2     | 1792
    //   00  | 0        | * 8^1     | 1792
    //    0  | 0        | * 8^0     | 1792
    int decim = 0;
    string octalAsStr = octal.ToString();
    int octalLength = octalAsStr.Length;
    int index = octalLength - 1;

    foreach (char c in octalAsStr) {
        decim += (int) (Char.GetNumericValue(c) * Math.Pow(8, index));
        index--;
    }
    return Convert.ToString(decim, 2);
}
    
// for testing the function
while (true) {
    try
    {
        string input = Console.ReadLine();
        if (input == "exit")
            break;
        Console.WriteLine(oct_to_bin(Convert.ToInt32(input)));
    }
    catch (System.Exception e)
    {
        
        Console.WriteLine(e);
    }
}
    