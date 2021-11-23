using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    //Custom Exception for cab invoice program
    public class CabInvoiceException : Exception
    {
        //Enum for defining different types of custom exception
        public ExceptionType type;

        //Initializing a new Instance of CabInvoiceException
        public CabInvoiceException(ExceptionType type,string message):base(message)
        {
            this.type = type;
        }

        public enum ExceptionType
        {
            INVALID_DISTANCE,INVALID_TIME,NULL_RIDES,INVALID_USER_ID,INVALID_RIDETYPE
        }
    }
}
