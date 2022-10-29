namespace Exercise_03.Calculator
{
    public class Calculator
    {
        string display = "0";
        string operation = "";
        int lastResult = 0;
        int nextResult = 0;
        bool isEqual = false;
        public string GetDisplay()
        {
            return display;
        }
        public void Press (string input)
        {
            if (input == "")
            {
                display = display == "0" ? "0" : display;
            }
            else if (input.Length > 2)
            {
                display = input;
                if (input.Contains("="))
                {
                    int index = input.IndexOf("=");
                    display = display.Remove(0, index + 1);
                }
                else display = display.Remove(0, display.Length - 5);
            }
            else if (input == "C") display = "0";
            else if (input == "+" || input == "-" || input == "*" || input == "/")
            {
                if (!string.IsNullOrEmpty(operation))
                {
                    lastResult = operation == "+" ? lastResult + nextResult
                                    : operation == "-" ? lastResult - nextResult
                                    : operation == "*" ? lastResult * nextResult
                                    : lastResult / nextResult;
                    nextResult = 0;
                }
                else
                {
                    lastResult = Int32.Parse(display);

                }
                operation = input;
            }
            else if (input == "=")
            {
                //nextResult = Int32.Parse(display);
                isEqual = true;
                if (operation == "/" && nextResult == 0) display = "E";
                else
                    display = (operation == "+" ? lastResult + nextResult
                                    : operation == "-" ? lastResult - nextResult
                                    : operation == "*" ? lastResult * nextResult
                                    : lastResult / nextResult).ToString();
                display = (display != "E" && Int32.Parse(display) > 9999) ? "E" : display;
            }
            else
            {
                if (operation != "" && nextResult == 0)
                {
                    nextResult += Int32.Parse(input);
                    display = input;
                }
                else if (isEqual) display = input;
                else
                {
                    display = display == "0" ? input : display + input;
                    if (display.Length > 5)
                    {
                        display = display.Remove(0, display.Length - 5);
                    }
                }
            }
        }
    }   
}