

namespace Task_Departmentt.Exceptions;

public class CapacityLimitException : Exception
{
    public CapacityLimitException(string errormessage) : base(errormessage) 
    {
        
    }
}
