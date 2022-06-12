using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_CLASS, NO_SUCH_METHOD
        }

        public ExceptionType Type;

        public MoodAnalyzerCustomException(ExceptionType type, string message) : base(message)
        {
            Type = type;
        }
    }
}