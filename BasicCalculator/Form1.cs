using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A basic calculator 
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();       
        }
        #endregion

        #region Operator Methods

        /// <summary>
        /// Adds a division symbol to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            // inserts the value in the user input text box
            InsertTextValue("/");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a multiplication symbol to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            // inserts the value in the user input text box
            InsertTextValue("*");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a subtraction symbol to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            // inserts the value in the user input text box
            InsertTextValue("-");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a addition symbol to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdditionButton_Click(object sender, EventArgs e)
        {
            // inserts the value in the user input text box
            InsertTextValue("+");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// calculates the answer to the mathmatical formula. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            // starts the process of calculating the equation
            CalculateEquation();
            // Focus the user input text 
            FocusInputText();
        }
        #endregion

        #region Number Methods

        /// <summary>
        /// Adds a zero to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            //Adds the "0" character to the user input box
            InsertTextValue("0");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a one to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            //Adds the "1" character to the user input box
            InsertTextValue("1");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a two to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            //Adds the "2" character to the user input box
            InsertTextValue("2");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a three to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            //Adds the "3" character to the user input box
            InsertTextValue("3");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a four to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            //Adds the "4" character to the user input box
            InsertTextValue("4");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a five to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            //Adds the "5" character to the user input box
            InsertTextValue("5");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a six to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            //Adds the "6" character to the user input box
            InsertTextValue("6");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a seven to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            //Adds the "7" character to the user input box
            InsertTextValue("7");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a eight to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            //Adds the "8" character to the user input box
            InsertTextValue("8");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a nine to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            //Adds the "9" character to the user input box
            InsertTextValue("9");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds a decimal to the end of input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            //Adds the "." character to the user input box
            InsertTextValue(".");

            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// Adds parenthesis to the equation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParenthesisButton_Click(object sender, EventArgs e)
        {
            
            // get the users equation input
            var input = this.UserInputText.Text;

            // count the number of open and closed paranthesis in the input
            int parenCount = input.Count(f => (f == ')')) + input.Count(f => (f == '('));

            // if the number of open parenthesis is 0 or even, add an open parenthesis
            if (parenCount % 2 == 0)
                InsertTextValue("(");
            // if the number of open parenthesis is odd, add a closing parenthesis
            else if (parenCount % 2 == 1)
                InsertTextValue(")");

            // Focus the user input text 
            FocusInputText();

        }
        #endregion

        /// <summary>
        /// Receives the input from the text box, removes whitespace and passes it on to the <see cref="ParenthesisLooper(string)"/>
        /// outputs the solved equation to the user
        /// </summary>
        /// <returns></returns>     
        private void CalculateEquation()
        {
            // gathers the input and makes sure it's as clean as possible before attempting to solve it
            var input = InputManipulation();

            // attempts to solve the equation and displays the answer to the user
            this.CalculationResultTest.Text = OperatorLooper(ParenthesisLooper(input));

            // Focus the user input text 
            FocusInputText();
        }

        #region Clearing Methods

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e"> The event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;

            // Focus the user input text 
            FocusInputText();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // delete the value after the selection position
            DeleteTextValue();
            // Focus the user input text 
            FocusInputText();
        }
        #endregion

        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            // remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            //set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            // set selection length to 0
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the given text from the user input text box
        /// </summary>
        private void DeleteTextValue()
        {
            // if we have no values to delete, we do nothing 
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            // remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            //Checks if the user input has text, if true deletes the character to the right of the cursor.
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            // restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            // set selection length to 0
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">character representing an operation to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':

                    return OperationType.Add;

                case '-':

                    return OperationType.Minus;
                case '*':

                    return OperationType.Multiply;
                case '/':

                    return OperationType.Divide;
                default:
                    throw new InvalidOperationException($"Unkown operator type {character}");
            }
        }
        #endregion

        #region Equation Solvers
        /// <summary>
        /// Loops through the equation first looking for ( ) and sending them to <see cref="DetermineOperation(string)"/> 
        /// eventually returning an input that only has operators.
        /// </summary>
        /// <param name="input">full equation to be simplified</param>
        /// <returns></returns>
        private string ParenthesisLooper(string input)
        {
            // variable that determines if there is a currently known open parenthesis
            var openParenCheck = false;

            // variable that determines if there is a currently known closing parenthesis
            var closeParenCheck = false;

            // variables that hold the index of the opening and closing parenthesis.
            var openParenIndex = 0;
            var closeParenIndex = 0;

            // while there are still '(' in the equation, it is necessary to continue looping through the equation
            // to make sure all parenthesis operations are completed before others.
            while (input.Contains('('))
            {
                // loops through the equation
                for (int i = 0; i < input.Length; i++)
                {
                    // if the current character is an open parenthesis
                    if (input[i] == '(')
                    {
                        // save the index of the parenthesis and save the fact that we have one
                        openParenIndex = i;
                        openParenCheck = true;

                        // if there was no operator before the open parenthesis and it wasn't the first character in the 
                        // equation, insert a multiplication symbol before it
                        if (i != 0 && !"+-*/".Any(c => input[i - 1] == c))
                            input = input.Insert(i, "*");

                    }
                    // if the current character is a closed parenthesis
                    else if (input[i] == ')')
                    {
                        // save the index of the parenthesis and save the fact that we have one
                        closeParenIndex = i;
                        closeParenCheck = true;

                        // if there is no operator after the closed parenthesis and it isn't the last character in the 
                        // equation, insert a multiplication symbol after it
                        if (i + 1 != input.Length && !"+-*/".Any(c => input[i + 1] == c))
                            input = input.Insert(i + 1, "*");
                    }
                    // if we have the open parenthesis and closed parenthesis, continue with solving the equation
                    if (openParenCheck == true && closeParenCheck == true)
                    {
                        // length of the equation, not including the parenthesis
                        var equationLength = closeParenIndex - openParenIndex - 1;

                        // the substring that is the equation within the parenthesis
                        var equationSub = input.Substring(openParenIndex + 1, equationLength);

                        // the sum of the equation within the substring
                        string sum = DetermineOperation(equationSub);

                        // the substring including the parenthesis
                        var parenSub = input.Substring(openParenIndex, equationLength + 2);

                        // replacing the equation including the parenthesis with the sum within the input
                        input = input.Replace(parenSub, sum);

                        // if the equation still contains parenthesis, reset the necessary variables for the loop
                        if (input.Contains('('))
                        {
                            openParenCheck = false;
                            closeParenCheck = false;

                            // resetting the i to where the sum is now located
                            i = openParenIndex;
                        }
                        // if it doesn't, break out of the for loop
                        else
                            break;
                    }
                }
            }
            return input;
        }

        /// <summary>
        /// Loops through the equation first looking for */ operators then +- and sending them to <see cref="DetermineOperation(string)"/>
        /// </summary>
        /// <param name="input">full equation input not containing () to be simplified</param>
        /// <returns></returns>
        private string OperatorLooper(string input)
        {
            // variables that tell us if we currently have disovered a previous, current, and next operators.
            var prevOpCheck = false;
            var nextOpCheck = false;
            var currentOpCheck = false;

            // variables that hold the index of the previous and next operators.
            var prevOpIndex = 0;
            var nextOpIndex = 0;

            // while there are still * and / operation within the equation, continue looping through it to make sure they're solved first.
            while (input.Contains("*") || input.Contains("/"))
            {
                // loops through the equation
                for (int i = 0; i < input.Length; i++)
                {
                    // if the character is a * or / operator
                    if ("*/".Any(c => input[i] == c))
                    {
                        // if we do not yet have a previous operator
                        if (!prevOpCheck)
                        {
                            // we say that the previous operator is found and that its index is -1
                            // because if we're here the first operator is one that should be solved, 
                            // so all characters before this are numbers. 
                            prevOpCheck = true;
                            prevOpIndex = -1;

                            // we say that we've found the current operator
                            currentOpCheck = true;
                        }
                        // if we've already found the previous operator but not the current operator
                        else if (!currentOpCheck)
                            // we say that we've found the current operator
                            currentOpCheck = true;
                        // if we've found the previous and current operator but not the next operator
                        else if (!nextOpCheck)
                        {
                            // we say we've found the next operator and mark its index
                            nextOpCheck = true;
                            nextOpIndex = i;
                        }
                    }
                    // if we've run into an operator that is + or -
                    // ( we're still solving * / operators only!)
                    else if ("+-".Any(c => input[i] == c))
                    {
                        // if there is no previous operation yet
                        if (!prevOpCheck)
                        {
                            // say we've found the operation and save its index
                            prevOpCheck = true;
                            prevOpIndex = i;
                        }
                        // if we've found another + or - after the previous operator and we still havent found
                        // out current operator, replace the previous operator with this one
                        else if (!currentOpCheck && !nextOpCheck)
                        {
                            // say we've found the operation and save its index
                            prevOpCheck = true;
                            prevOpIndex = i;
                        }
                        // if we've found the previous and current operation but not the next
                        else if (!nextOpCheck)
                        {
                            // say we've found the operation and save the index
                            nextOpCheck = true;
                            nextOpIndex = i;
                        }

                    }
                    // if we're at the end of the equation and we still havent found the next operator
                    if (i + 1 == input.Length && !nextOpCheck)
                    {
                        // mark the operator as true and save the index as the length of the string
                        nextOpCheck = true;
                        nextOpIndex = i + 1;
                    }
                    // if we've found all operators, proceed to solving the equation
                    if (prevOpCheck && currentOpCheck && nextOpCheck)
                    {
                        // the length of the equation, factoring out the previous and next operators
                        var equationLength = nextOpIndex - prevOpIndex - 1;

                        // the substring of the eqution to be solved
                        var equationSub = input.Substring(prevOpIndex + 1, equationLength);

                        // the sum of the solved equation
                        string sum = DetermineOperation(equationSub);

                        // replacing the equation with its sum in the input
                        input = input.Remove(prevOpIndex + 1, equationLength).Insert(prevOpIndex + 1, sum);

                        // if the input still contains a * or / operator
                        if (input.Contains('*') || input.Contains('/'))
                        {
                            // reset the necessary variables and continue through the loop
                            nextOpCheck = false;
                            currentOpCheck = false;

                            // resetting the i to where the sum has replaced the equation
                            i = prevOpIndex + 1;
                        }
                        // if not break through the loop
                        else
                            break;
                    }
                }
            }
            // while the input contains a + or - operator continue looping through to solve the equation
            while (input.Contains("+") || input.Contains("-"))
            {
                // resetting the variables applicable to the loop   
                nextOpCheck = false;
                currentOpCheck = false;

                prevOpIndex = 0;
                nextOpIndex = 0;

                // looping through the input
                for (int i = 0; i < input.Length; i++)
                {
                    // if there are any + or - operators in the input 
                    if ("+-".Any(c => input[i] == c))
                    {
                        //means the first number is not a negative
                        if (i != 0)
                        {
                            // means it's not the first character, and there is no current operator
                            if (!currentOpCheck)
                                {
                                    currentOpCheck = true;
                                }
                            // means if we're not at the first character, and there is a currentOpCheck and there is no nextOpCheck
                            else if (!nextOpCheck)
                            {
                            // mark is as true and save the index
                            nextOpCheck = true;
                            nextOpIndex = i;
                            }
                        }
                    }  

                    // if we've reached the end of the input
                    if (i + 1 == input.Length)
                    {
                        // if there's no current operator, that means there is only one number in the input, the solution
                        if (!currentOpCheck)
                            return input;
                        // if there is no next operator, then the index should be set to the length of the input
                        else if (!nextOpCheck)
                        {
                            // say that we found the next operator and set the index to the length of the input
                            nextOpCheck = true;
                            nextOpIndex = i + 1;
                        }
                    }

                    // if we've found the current and next operators proceed to solve the equation
                    if (currentOpCheck && nextOpCheck)
                    {
                        // the length of the substring
                        var subLength = nextOpIndex;

                        if(prevOpIndex != 0)                       
                            subLength = nextOpIndex - prevOpIndex;

                        // the substring of the equation that's going to be solved
                        var equationSub = input.Substring(0, subLength);

                        // the sum of the equation
                        string sum = DetermineOperation(equationSub);

                        // replacing the solved part of the equation with its sum inside the input.
                        input = input.Remove(0, subLength).Insert(0, sum);

                        // if there are still + or - operators inside the input, continue looping through
                        if (input.Contains('+') || input.Contains('-'))
                        {
                            nextOpCheck = false;
                            currentOpCheck = false;

                            prevOpIndex = 0;
                            nextOpIndex = 0;

                            i = 0;
                        }
                        // if not, break out of the loop
                        else
                            break;
                    }
                }
            }
            return input;
        }

        /// <summary>
        /// recieves the equation each operation at a time and creates an <see cref="Operation"/> out of them, 
        /// allowing it to be sent to <see cref="CalculateOperation(Operation)"/>
        /// then returns the sum. Ex. 2*2+3      input = 2*2 return 4 > input = 4+3 return 7
        /// </summary>
        /// <param name="input">equation to be solved. </param>
        /// <returns></returns>
        private string DetermineOperation(string input)
        {
            var leftSide = true;
            var operation = new Operation();

            for (int i = 0; i < input.Length; i++)
            {
                // check if the current character is a number
                if ("0123456789.".Any(c => input[i] == c))
                {
                    // Adding the number or decimal to the correct side of the equation.
                    if (leftSide)
                        operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                    else
                        operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                }// if it is an operator (+-*/) set the opeartor type
                else if ("+-*/".Any(c => input[i] == c))
                {
                    if (leftSide)
                    {
                        // get the operator type
                        var operatorType = GetOperationType(input[i]);

                        // check if we actually have a left side number
                        if (operation.LeftSide.Length == 0)
                        {
                            // check the operator is not a minus
                            if (operatorType != OperationType.Minus)
                                throw new InvalidOperationException($"Operator (+ / * or more than one -) specified wihtout a left side number");

                            // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the LeftSide
                            operation.LeftSide += input[i];
                        }
                        else
                        {
                            // if we get here, we have a left number, and an operator, so we want to move to the right side

                            //set the operation type
                            operation.OperationType = operatorType;

                            // move to the right side
                            leftSide = false;
                        }
                    }
                    else if (!leftSide)
                    {
                        var operatorType = GetOperationType(input[i]);

                        if (operation.RightSide.Length == 0)
                        {
                            // check the operator is not a minus
                            if (operatorType != OperationType.Minus)
                                throw new InvalidOperationException($"Operator (+ / * or more than one -) specified wihtout a left side number");

                            // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the LeftSide
                            operation.RightSide += input[i];
                        }
                    }
                }
            }
            input = CalculateOperation(operation);
            return input;
        }

        /// <summary>
        /// Attempts to add a new character to the current number, checkign for valid characters as it goes
        /// </summary>
        /// <param name="currentNumber"> the current number string</param>
        /// <param name="currentCharacter">the new character to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");

            return currentNumber + newCharacter;
        }

        /// <summary>
        /// calculates a <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation">the operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            // store the number values of the string representations 
            double left = 0;
            double right = 0;

            // check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !double.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.LeftSide}");

            // check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !double.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right side of the operation was not a number. {operation.RightSide}");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    default:
                        throw new InvalidOperationException($"unknown operator type when calculating operation. {operation.OperationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"failed to calculated operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
            }
        }
        #endregion

        #region Input Validation/Error Handling
        /// <summary>
        /// Attempts to validate the input by retrieving it from <see cref="InputManipulation"/> and passing it through <see cref="ValidInput(string, out string)"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInputText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // error message that's defined and presented to the user when an error occurs.
            string errorMsg;

            // if the function ValidInput returns false, it returns the error message provided
            if (!ValidInput(InputManipulation(), out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                UserInputText.Select(0, UserInputText.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.equationErrorProvider.SetError(UserInputText, errorMsg);
            }
        }

        /// <summary>
        /// Clears the ErrorProvider <see cref="equationErrorProvider"/> of errors if the input is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInputText_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            equationErrorProvider.SetError(UserInputText, "");
        }

        /// <summary>
        /// Attempts to validate the input.
        /// </summary>
        /// <param name="input">The equation being validated from the <see cref="UserInputText"/> text box</param>
        /// <param name="errorMessage"> the error message to be passed if the input is invalid</param>
        /// <returns></returns>
        public bool ValidInput(string input, out string errorMessage)
        {
            // if the string is empty
            if (input == string.Empty)
            {
                // the ErrorProvider should return this message:
                errorMessage = "You have not entered an equation, please enter one and try again.";
                return false;
            }
            // if the equation contains characters that are not allowed
            else if (!Regex.IsMatch(input, @"^[\d\.\+\-\*\/\(\)]+$"))
            {
                // the ErrorProvider should return this message:
                errorMessage = "The equation contains invalid characters, please remove then and try again. Characters allowed: [0-9] + - * / ( )";
                return false;
            }
            // if there's only one character, and it's not a number, or if there's 2 characters and the 2nd one is not a number, throw this error.
            else if (input.Length == 1 && !"0123456789".Any(c => input[0] == c) || input.Length == 2 && !"0123456789".Any(c => input[1] == c))
            {
                // the ErrorProvider should return this message:
                errorMessage = "The equation you've entered is not a number, please try again.";
                return false;
            }
            // if the equation starts with anything but [0-9], -, ., ( OR ends with anything but [0-9], )
            else if (input.StartsWith("+") || input.StartsWith("*") || input.StartsWith("/") || input.StartsWith(")") ||
                input.EndsWith("+") || input.EndsWith("-") || input.EndsWith("*") || input.EndsWith("/") || input.EndsWith(".") || input.EndsWith("("))
            {
                // the ErrorProvider should return this message:
                errorMessage = "The equation begins or ends with an invalid character, please try again.";
                return false;
            }
            // if the operator is surronded by unacceptable characters OR there are two operators in a row
            else if (!Regex.IsMatch(input, @"(?:[0-9]|\))(?:\+|\-|\*|\/)(?:[0-9]|\(|\.|\-)"))
            {
                // the ErrorProvider should return this message:
                errorMessage = "The equation contains two or more characters together that are not allowed, please review your equation and try again.";
                return false;
            }      
            /*
             * At this point we know:
             *                          - The string is not empty
             *                          - contains only applicable characters
             *                          - if it's only 1 or 2 characters long, it's correct
             *                          - it starts and ends with valid characters
             *                          - if the operator is surronded by unacceptable characters. Acceptable Sequences: [0-9], )   OPERATOR    [0-9], ., -
             */
            // the equation has been validated to the a certain extent
            else
            {
                // there is no message
                errorMessage = "";
                return true;
            }
            
        }

        /// <summary>
        /// Allows the user to close the form even if there's an error, or if they haven't submitted anything.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        /// <summary>
        /// Manipulates the input from <see cref="UserInputText"/> 
        /// to remove any whitespace or double negatives.
        /// </summary>
        /// <returns></returns>
        private string InputManipulation()
        {
            // gets the input from the UserInputText text box
            var input = UserInputText.Text;

            // replaces white space with nothing
            input = input.Replace(" ", "");

            // replaces double negatives with addition signs
            input = input.Replace("--", "+");

            // returns the input
            return input;

        }
        #endregion
    }
}