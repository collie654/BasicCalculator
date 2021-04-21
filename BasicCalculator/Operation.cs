using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    /// <summary>
    /// hold information about a single calculator operation
    /// </summary>
    class Operation
    {
        #region Public Properties
        /// <summary>
        /// Left side of the operation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// Right side of the operation
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// the type of operation to perform
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// the inner operation to be performed initially before this opeation
        /// </summary>
        public Operation InnerOperation { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// default constructor
        /// </summary>
        public Operation()
        {
            // create empty strings instead of having nulls
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }

        #endregion
    }
}
