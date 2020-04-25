using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable]
        public class Condition
        {
            
            public string ConditionID { get; set; }
            public string ConditionDisplayName { get; set; }

            public override string ToString()
            {
                return ConditionDisplayName;
            }
        }
    }
}
