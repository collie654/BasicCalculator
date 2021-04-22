using System;
using System.Linq;
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
        #endregion

        /// <summary>
        /// calculates the given equation and outputs the answer to the user
        /// </summary>      
        private void CalculateEquation()
        {
            //this.CalculationResultTest.Text = ParseOperation();
            this.CalculationResultTest.Text = ParenthesisCheck();
            
            // Focus the user input text 
            FocusInputText();
        }

        /// <summary>
        /// parses the users equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                // get the users equation input
                var input = this.UserInputText.Text;

                // remove all spaces
                input = input.Replace(" ", "");

                // create a new top-level operation
                var operation = new Operation();
                var leftSide = true;

                // Loop through each character of the input
                // starting from the left working to the right
                for (int i = 0; i < input.Length; i++)
                {
                    // check if the current character is a number
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                    }
                    // if it is an operator (+-*/) set the opeartor type
                    else if ("+-*/".Any(c => input[i] == c))
                    {
                        // if we are on the right side already, we now need to calculate our current operation
                        // and set the result to the left side of the next operation
                        if (!leftSide)
                        {
                            // get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // check if we actually have a right side number
                            if (operation.RightSide.Length == 0)
                            {
                                // check the operator is not a minus
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ / * or more than one -) specified wihtout a right side number");

                                // If we got here, the operator type is a minus, and there is no right number currently, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                // calculate previous equation
                                operation.LeftSide = CalculateOperation(operation);

                                //set new operator
                                operation.OperationType = operatorType;

                                // clear the previous right number
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
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
                    }
                }

                // if we are done parsing, and there were no exceptions
                // calculate the current operation
                return CalculateOperation(operation);


                //return string.Empty;
            }
            catch(Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
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
            catch(Exception ex)
            {
                throw new InvalidOperationException($"failed to calculated operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
            }
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

        private string ParenthesisCheck()
        {
            // get the users equation input
            var input = this.UserInputText.Text;

            // remove all spaces
            input = input.Replace(" ", "");

            // substring containing the parenthesis equation from '(' to ')' inclusive
            var inputSubstring = string.Empty;

            // the length of the substring, calculated with the indexes of the '(' and ')'
            var subLength = 0;

            // creating a new opeartion to do the operation that's within the parenthesis
            var operation = new Operation();
            var parenthesisOperation = new ParenthesisOperation();

            // used to flip between the left and right hand sides of the equation
            var leftSide = true;

            // looping through the equation string
            for (int i = 0; i < input.Length; i++)
            {
                // checking for an opening parenthesis
                if (input[i] == '(') 
                {
                    // checking if the previous character was an operator. Then inserting a multiplication sign before the parenthesis. 
                    if (i != 0 && !"+-*/".Any(c => input[i - 1] == c))
                    {
                        // if it was not an operator, add a multiplication symbol and add one to i. 
                        input = input.Insert(i, "*");

                        // saving the open parenthesis index and moving through the string.
                        parenthesisOperation.OpenParenthesis = true;
                        i++;
                        parenthesisOperation.OpenParenthesisIndex = i;
                        continue;
                    }
                    else
                    {
                        // if the parenthesis is the 0th index or if the character before it was an operator
                        // save the open parenthesis index and move on.
                        parenthesisOperation.OpenParenthesis = true;
                        parenthesisOperation.OpenParenthesisIndex = i;
                        continue;
                    }
                }
                // if we are currently inside a parenthesis, we're going to use an Operation() to save and calculate the sum. 
                if (parenthesisOperation.OpenParenthesis == true)
                {
                    // checking if the current character is a closing parenthesis
                    if (input[i] == ')')
                    {
                        // saving the closing parenthesis index.
                        parenthesisOperation.CloseParenthesis = true;
                        parenthesisOperation.CloseParenthesisIndex = i;
                    }
                    // check if the current character is a number
                    else if ("0123456789.".Any(c => input[i] == c))
                    {
                        // Adding the number or decimal to the correct side of the equation.
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                    }
                    // if it is an operator (+-*/) set the opeartor type
                    else if ("+-*/".Any(c => input[i] == c))
                    {
                        // if we are on the right side already, we now need to calculate our current operation
                        // and set the result to the left side of the next operation
                        if (!leftSide)
                        {
                            // get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // check if we actually have a right side number
                            if (operation.RightSide.Length == 0)
                            {
                                // check the operator is not a minus
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ / * or more than one -) specified wihtout a right side number");

                                // If we got here, the operator type is a minus, and there is no right number currently, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                // calculate previous equation
                                operation.LeftSide = CalculateOperation(operation);

                                //set new operator
                                operation.OperationType = operatorType;

                                // clear the previous right number
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
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
                    }
                }
                // if both parenthesis have been found, go through statement
                if(parenthesisOperation.OpenParenthesis == true && parenthesisOperation.CloseParenthesis == true)
                {
                    // resetting the index
                    i = 0;
                    
                    //resetting the side switch
                    leftSide = true;

                    // changing both booleans to false, for future parenthesis equations
                    parenthesisOperation.OpenParenthesis = false;
                    parenthesisOperation.CloseParenthesis = false;

                    // calculating and saving the answer to the parenthesis equation
                    parenthesisOperation.ParenthesisAnswer = CalculateOperation(operation);

                    // calculating the length of the parenthesis equation. from '(' to ')' inclusive.
                    subLength = (parenthesisOperation.CloseParenthesisIndex + 1) - parenthesisOperation.OpenParenthesisIndex;

                    // defining the parenthesis equation
                    inputSubstring = input.Substring(parenthesisOperation.OpenParenthesisIndex, subLength);

                    // changing the entire equation by replacing the parenthesis equation with its result.
                    input = input.Replace(inputSubstring, parenthesisOperation.ParenthesisAnswer);

                    operation = new Operation();

                }
            }
            return input;
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
        #endregion
    }
}

//Equation: -5+3(2*2) => -5+3*4
// Operation() LinkedList: -5+3, 3*4 


