using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    [Serializable()]
    public class eBayException : Exception
    {
        public string error { get; set; }
        public string category { get; set; }
        public string domain { get; set; }

        public long errorId { get; set; }
        public long exceptionId { get; set; }
        public string Message { get; set; }
        public string parameter { get; set; }

        public ErrorSeverity errorSeverity { get; set; }
        public string subdomain { get; set; }
        
        public eBayException(string Message)
        {
            
        }

        [Serializable()]
        public enum ErrorSeverity
        {
            Error,
            Warning

        }


    }



}
