using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvanced
    {
        public List<OutputSelector> OutputSelectors { get; set; }
        public List<AspectFilterType> AspectFilterTypes { get; set; }

         ////<summary>
         ///Aspect filters refine (limit) the number of items returned by a find request. Obtain input values for aspectFilter fields from an aspectHistogramContainer returned in the response of a previous query. 
         //By issuing a series of find queries, you can continually refine the items returned in your responses. Do this by repeating a query using the aspect values returned in one response as the input values to your next query. 
         ///For example, the aspectHistogramContainer in a response on Men's Shoes could contain an aspect of Size, along with "aspect values" for the different sizes currently available in Men's Shoes. By populating aspectFilter fields with the values returned in an aspectHistogramContainer, you can hone the item results returned by your new query.
         ///</summary>
         ///
        [Serializable()]
        public class AspectFilterType
        {
            /// <summary>
            /// Name of a standard item characteristic associated with a given domain. For example, "Optical Zoom" or "Megapixels" are aspects for the Digital Cameras domain. The current aspect names associated with a specific domain can be found in the aspect histogram. Aspect histograms can be retrieved for a given keyword query or category. The aspect histogram contains information about aspects from the domain that is most relevant to your search (or category). 
            /// </summary>
            public string AspectName { get; set; }
            /// <summary>
            /// A value name for a given aspect. For example, "Point & Shoot" is a value name for the "Product Type" aspect in the "Digital Cameras" domain. 
            /// </summary>
            public string AspectValue { get; set; }

            public AspectFilterType(string AspectName, string AspectValue)
            {
                this.AspectName = AspectName;
                this.AspectValue = AspectValue;
            }
        }


        private string GetAspectFilters(List<AspectFilterType> list)
        {



            string searl = "";
            int val = 0;


            if (list.Count > 0)
            {


                foreach (AspectFilterType elt in list)
                {
                    searl += "&aspectFilter(" + val.ToString() + ").aspectName=" + elt.AspectName;
                    searl += "&aspectFilter(" + val.ToString() + ").aspectValueName=" + elt.AspectValue;
                    val++;


                }

                val = 0; //reset after for each new itemFilter id

            }


            return searl;
        }
        
    }
}
