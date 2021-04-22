using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class ParenthesisOperation
    {
        #region Public Properties
        /// <summary>
        /// Left side of the operation
        /// </summary>
        public Boolean OpenParenthesis { get; set; }

        /// <summary>
        /// the closing parenthesis
        /// </summary>
        public Boolean CloseParenthesis { get; set; }

        /// <summary>
        /// the index of the opening parenthesis. used to replace the parenthesis equation with its result
        /// </summary>
        public int OpenParenthesisIndex { get; set; }

        /// <summary>
        /// the index of the closing parenthesis. used to replace the parenthesis equation with its result
        /// </summary>
        public int CloseParenthesisIndex { get; set; }

        /// <summary>
        /// the result of the equation inside the parenthesis
        /// </summary>
        public string ParenthesisAnswer { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// default constructor
        /// </summary>
        public ParenthesisOperation()
        {
            // create empty strings instead of having nulls
            this.OpenParenthesis = false;
            this.CloseParenthesis = false;
            this.OpenParenthesisIndex = 0;
            this.CloseParenthesisIndex = 0;
            this.ParenthesisAnswer = string.Empty;
        }

        #endregion
    }
}

