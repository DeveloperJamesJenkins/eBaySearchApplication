using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    /// <summary>
    /// The criteria to login and add your account detials for affiliation sales
    /// </summary>
    /// 
    [Serializable()]
    public class eBayServiceCredentials
    {
        public static FindingAPI.eBayServiceCredentials CreateCredentials(string SECURITY_APPNAME)
        {
            FindingAPI.eBayServiceCredentials creds = new FindingAPI.eBayServiceCredentials();
            creds.SECURITY_APPNAME = SECURITY_APPNAME;
            creds.xEBAY_SOA_GLOBAL_ID = FindingAPI.eBayServiceCredentials.GlobalID.GB;

            return creds;
        }

        public string SERVICE_VERSION { get; set; }

        public eBayServiceCredentials()
        {
            this.SERVICE_VERSION = "1.11.0";
        }

        public GlobalID xEBAY_SOA_GLOBAL_ID
        {
            get;
            set;
        }
        public string SECURITY_APPNAME { get; set; }



        [Serializable()]
        public enum GlobalID
        {
            /// <summary>
            /// Austria
            /// </summary>
            AT = 16,
            /// <summary>
            /// Australia
            /// </summary>
            AU = 15,
            /// <summary>
            /// Switzerland
            /// </summary>
            CH = 193,
            /// <summary>
            /// Germany
            /// </summary>
            DE = 77,
            /// <summary>
            /// Canada English
            /// </summary>
            ENCA = 2,
            /// <summary>
            /// Spain
            /// </summary>
            ES = 186,
            /// <summary>
            /// France
            /// </summary>
            FR = 71,
            /// <summary>
            /// Belgium French
            /// </summary>
            FRBE = 23,
            /// <summary>
            /// Canada French
            /// </summary>
            FRCA = 210,
            /// <summary>
            /// United Kingdom
            /// </summary>
            GB = 3,
            /// <summary>
            /// Hong Kong
            /// </summary>
            HK = 201,
            /// <summary>
            /// Ireland
            /// </summary>
            IE = 205,
            /// <summary>
            /// India
            /// </summary>
            IN = 203,
            /// <summary>
            /// Italy
            /// </summary>
            IT = 101,
            // eBay_Motors__MOTOR=100,
            /// <summary>
            /// Malaysia
            /// </summary>
            MY = 207,
            /// <summary>
            /// Netherlands
            /// </summary>
            NL = 146,
            /// <summary>
            /// Belgium Dutch
            /// </summary>
            NLBE = 123,
            /// <summary>
            /// Philippines
            /// </summary>
            PH = 211,
            /// <summary>
            /// Poland
            /// </summary>
            PL = 212,
            /// <summary>
            /// Singapore
            /// </summary>
            SG = 216,
            /// <summary>
            /// United States
            /// </summary>
            US = 0,
            /// <summary>
            /// Sweden
            /// </summary>
            SE = 218

        }

     
      
    }
}
