static string numToEng(int n) {
    // a dict for all the possible words that we'll need to use
    var numToWord = new Dictionary<int, string> {
        {0, "zero"},
        {1, "one"},
        {2, "two"},
        {3, "three"},
        {4, "four"},
        {5, "five"},
        {6, "six"},
        {7, "seven"},
        {8, "eight"},
        {9, "nine"},
        {10, "ten"},
        {11, "eleven"},
        {12, "twelve"},
        {13, "thirteen"},
        {14, "fourteen"},
        {15, "fifteen"},
        {16, "sixteen"},
        {17, "seventeen"},
        {18, "eighteen"},
        {19, "ninteen"},
        {20, "twenty"},
        {30, "thirty"},
        {40, "fourty"},
        {50, "fifty"},
        {60, "sixty"},
        {70, "seventy"},
        {80, "eighty"},
        {90, "ninety"},
        {100, "hundred"}
    };

    // storing the num as a string to make it easier to compare and use logic
    string numAsStr = n.ToString();

    int CharToInt(char c) {
        return Convert.ToInt32(c.ToString());
    }

    int firstNum;
    int secondNum;
    int thirdNum;

    switch (numAsStr.Length) {

        // in case it's a single number
        case 1:
        return numToWord[n];

        // in case it's a 2-digits number
        case 2:
        // making variables to make it more readable instead of something like
        // CharToInt(numAsStr[1]) each time we refrence it
        firstNum = CharToInt(numAsStr[1]);
        secondNum = CharToInt(numAsStr[0]);

        // in case it's just 10 * n, like 10 or 20, 30... etc
        if (numAsStr[1] == '0'){
            return numToWord[n];
        }
        // in case it's 10 + n | n < 10, like 11, 12, 13, 14... etc
        else if (numAsStr[1] == '1') {
            return numToWord[n];
        }
        // for the rest of numbers
        else {
            return $"{numToWord[secondNum * 10]}-{numToWord[firstNum]}";
        }

        // in case it's a 3-digits number
        case 3:
            // again using vars for more readability
            firstNum = CharToInt(numAsStr[2]);
            secondNum = CharToInt(numAsStr[1]);
            thirdNum = CharToInt(numAsStr[0]);

            // again, for better readability, it's in multiple lines 
            string text = "";
            text += numToWord[thirdNum];
            text += ' ';
            text += numToWord[100];

            if (numAsStr[1] == '0') {
                // if there's no number in the 10s, like 101, 203, 309... 
                if (numAsStr[2] != '0') {
                    text += ' ';
                    text += numToWord[firstNum];
                }

            }
            // if there IS a number there, like 110, 240, 550...
            else if (numAsStr[2] == '0') {
                text += ' ';
                text += numToWord[secondNum * 10];
            }
            // if there's a number in both last two digits, like 111, 234, 452...
            else {
                text += ' ';
                // if it's 10 + n | n < 10
                if (secondNum == 1) {
                    text += numToWord[(secondNum * 10) + firstNum];
                }
                // otherwise
                else {
                    text += numToWord[secondNum * 10];
                    text += '-';
                    text += numToWord[firstNum];
                }
            }

            return text;
    }
    // just in case it's not in the switch case statment
    return string.Empty;
}

// for testing the function
while (true) {
    try
    {
        string input = Console.ReadLine();
        if (input == "exit")
            break;
        Console.WriteLine(numToEng(Convert.ToInt32(input)));
    }
    catch (System.Exception e)
    {
        
        Console.WriteLine(e);
    }
}
    