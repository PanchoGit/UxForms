using System.Collections.Generic;

namespace UxForms.Domain
{
    public class ResultError
    {
        public string ErrorCode { get; set; }

        public ResultError(string errorMessage)
        {
        }

        public ResultError(string errorMessage, IEnumerable<string> memberNames)
        {
        }

        public ResultError(string errorCode, string errorMessage, IEnumerable<string> memberNames)
        {
            ErrorCode = errorCode;
        }
    }
}
