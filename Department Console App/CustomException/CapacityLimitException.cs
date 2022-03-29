using System;

namespace Department_Console_App.CustomException
{
    public class CapacityLimitException: Exception
    {
        public CapacityLimitException(string message):base(message) { }
    }
}