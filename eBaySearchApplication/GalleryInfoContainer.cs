using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable()]
        public class GalleryUrl
        {
            public string GallerySize { get; set; }
            public string Url { get; set; }

        }
    }
}
