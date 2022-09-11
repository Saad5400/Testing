static int postFix(string expr) {
    int x = 0, y = 0;
    int result = 0;
    string operators = "+-/*";
    string[] exprArray = expr.Split(' ');

    foreach (string str in exprArray) {
        if (operators.Contains(str)) {
            switch (str) {
                case "+":
                result = x + y;
                break;

                case "-":
                result = x - y;
                break;

                case "*":
                result = x * y;
                break;

                case "/":
                result = x / y;
                break;
            }
            x = result;
            y = 0;
        }
        else {
            if (x == 0) {
                x = Convert.ToInt32(str);
            }
            else {
                y = Convert.ToInt32(str);
            }
        }
    }
    return result;
}
    
    
// for testing the function
while (true) {
    try
    {
        string input = Console.ReadLine();
        if (input == "exit")
            break;
        Console.WriteLine(postFix(input));
    }
    catch (System.Exception e)
    {
        
        Console.WriteLine(e);
    }
}
    