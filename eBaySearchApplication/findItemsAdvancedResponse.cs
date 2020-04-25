using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;

namespace FindingAPI
{
    /// <summary>
    /// after a findItemsAdvanced call this is the object returned
    /// </summary>
    public partial class findItemsAdvancedResponse
    {

        public string Version { get; private set; }
        public DateTime TimeStamp { get; private set; }
        public List<eBayItem> SearchResults { get; private set; }
        public PaginationOutput Pagination { get; set; }
        public string ItemSearchURL { get; set; }
        public AspectHistogramContainer AspectHistogram { get; set; }


       // public List<GalleryUrl> GalleryUrls { get; set; }

        //TODO************************************************
        //categoryHistogramContainer
        //aspectHistogramContainer
        //conditionHistogramContainer

        public findItemsAdvancedResponse()
        {
            

        }

       
     


        internal static findItemsAdvancedResponse ParseResponse(XmlDocument Response)
        {
            findItemsAdvancedResponse fir = new findItemsAdvancedResponse();
           

            XmlNode xver = Response.GetElementsByTagName("version")[0];

            XmlNode xtim = Response.GetElementsByTagName("timestamp")[0];
            XmlNode xurl = Response.GetElementsByTagName("itemSearchURL")[0];

          

            XmlNodeList childs = Response.GetElementsByTagName("findItemsAdvancedResponse")[0].ChildNodes;
            foreach (XmlNode child in childs)
            {
                switch (child.Name)
                {
                   
                                         

                    case "paginationOutput":

                        PaginationOutput po = new PaginationOutput();

                        foreach (XmlNode pag in child)
                        {
                            if (pag.Name == "pageNumber")
                            {
                                po.PageNumber = int.Parse(pag.InnerText);
                            }

                            if (pag.Name == "entriesPerPage")
                            {
                                po.EntriesPerPage = int.Parse(pag.InnerText);
                            }


                            if (pag.Name == "totalPages")
                            {
                                po.TotalPages = int.Parse(pag.InnerText);
                            }


                            if (pag.Name == "totalEntries")
                            {
                                po.TotalEntries = int.Parse(pag.InnerText);
                            }

                        }

                        fir.Pagination = po;
                        break;

                    case "aspectHistogramContainer":

                        AspectHistogramContainer ahp = new AspectHistogramContainer();
                        ahp.Aspects = new List<eBayAspect>();

                        foreach (XmlNode ahc in child.ChildNodes)
                        {
                           // eBayAspect asp = new eBayAspect();

                            switch (ahc.Name)
                            {
                                case "domainName":
                                    ahp.DomainName = ahc.InnerText;
                                    break;

                                case "domainDisplayName":
                                    ahp.DomainDisplayName = ahc.InnerText;
                                    break;


                                case "aspect":

                                     eBayAspect es = new eBayAspect();
                                        es.Name = ahc.Attributes["name"].InnerText;
                                        es.ValueHistograms = new List<eBayAspect.AspectValueHistogram>();
                                   
                                   // .GetNamedItem("aspect", "http://www.ebay.com/marketplace/search/v1/services");
                                    //es.Name = atts.Attributes["name"].InnerText;

                                    foreach (XmlNode aspect in ahc.ChildNodes)
                                    {
                                       

                                        switch(aspect.Name)
                                        {
                                            case "valueHistogram":

                                                eBayAspect.AspectValueHistogram avh = new eBayAspect.AspectValueHistogram();
                                                avh.ValueName = aspect.Attributes["valueName"].InnerText;
                                                avh.Count = long.Parse( aspect.FirstChild.InnerText);

                                                es.ValueHistograms.Add(avh);
                                               
                                            break;

                                         }

                                       
                                    }

                                    ahp.Aspects.Add(es);
                                    

                                    

                                    break;
                            
                            }


                        }

                        fir.AspectHistogram = ahp;
                        break;

                    case "searchResult":

                        List<eBayItem> ebs = new List<eBayItem>();

                        foreach (XmlNode item in child.ChildNodes)
                        {
                            eBayItem eb = new eBayItem();

                            foreach (XmlNode ebItem in item.ChildNodes)
                            {
                                switch (ebItem.Name)
                                {
                                    case "autoPay":

                                        eb.AutoPay = bool.Parse(ebItem.InnerText);

                                        break;


                                    case "charityId":

                                        eb.CharityID = ebItem.InnerText;

                                        break;


                                    case "compatibility":

                                        eb.Compatibility = ebItem.InnerText;

                                        break;

                                    case "country":

                                        eb.Country = ebItem.InnerText;

                                        break;

                                    case "discountPriceInfo":

                                        DiscountPriceInfo dpi = new DiscountPriceInfo();

                                        break;

                                    case "distance":

                                        DistanceType d = new DistanceType();
                                        d.Distance = decimal.Parse( ebItem.InnerText);

                                        d.Unit = ebItem.Attributes["unit"].InnerText;

                                        eb.Distance = d;

                                        break;

                                    case "galleryInfoContainer":

                                        

                                        eb.GalleryInfoContainer = new List<GalleryUrl>();

                                        foreach (XmlNode ga in ebItem)
                                        {

                                            GalleryUrl gal = new GalleryUrl();
                                            gal.Url = ga.InnerText;
                                            gal.GallerySize = ga.Attributes["gallerySize"].InnerText;


                                            eb.GalleryInfoContainer.Add(gal);

                                        }

                                        

                                        break;

                                    case "galleryPlusPictureURL":

                                        eb.GalleryPlusPictureURL = new List<string>();

                                        foreach (XmlNode pp in ebItem.ChildNodes)
                                        {

                                            eb.GalleryPlusPictureURL.Add(pp.InnerText);
                                        }

                                        break;

                                    case "galleryURL":

                                        eb.GalleryURL = ebItem.InnerText;

                                        break;


                                    case "globalId":

                                        eb.GlobalID = ebItem.InnerText;

                                        break;

                                    case "itemId":

                                        eb.ItemId = ebItem.InnerText;

                                        break;


                                    case "listingInfo":

                                        eBayListingInfo leb = new eBayListingInfo();

                                        foreach (XmlNode hu in ebItem.ChildNodes)
                                        {
                                            switch (hu.Name)
                                            {
                                                case "bestOfferEnabled":

                                                    leb.BestOfferEnabled = bool.Parse(hu.InnerText);

                                                    break;

                                                case "buyItNowAvailable":

                                                    leb.BuyItNowAvailable = bool.Parse(hu.InnerText);

                                                    break;


                                                case "buyItNowPrice":

                                                    eBayListingInfo.AmountType at = new eBayListingInfo.AmountType();
                                                    at.Amount = double.Parse(hu.InnerText);
                                                    at.CurrencyID = hu.Attributes["currencyId"].InnerText;

                                                    leb.BuyItNowPrice = at;

                                                    break;

                                                case "convertedBuyItNowPrice":

                                                     eBayListingInfo.AmountType cat = new eBayListingInfo.AmountType();
                                                    cat.Amount = double.Parse(hu.InnerText);
                                                    cat.CurrencyID = hu.Attributes["currencyId"].InnerText;
                                                    leb.ConvertedBuyItNowPrice = cat;

                                                    break;

                                                case "endTime":

                                                    leb.EndTime = DateTime.Parse(hu.InnerText);

                                                    break;

                                                case "startTime":

                                                    leb.startTime = DateTime.Parse(hu.InnerText);

                                                    break;


                                                case "gift":

                                                    leb.Gift = bool.Parse(hu.InnerText);
                                                    
                                                    break;


                                                case "listingType":

                                                    leb.ListingType = (findItemsAdvanced.ItemFilters.eBayListingType) Enum.Parse(typeof(findItemsAdvanced.ItemFilters.eBayListingType), hu.InnerText);
                                                    break;
                                            }

                                        }


                                        eb.ListingInfo = leb;

                                        break;


                                    case "location":

                                        eb.Location = ebItem.InnerText;

                                        break;


                                    case "paymentMethod":

                                        eb.PaymentMethods = new List<eBayPaymentMethod>();

                                        foreach (XmlNode pp in ebItem.ChildNodes)
                                        {

                                            eb.PaymentMethods.Add((eBayPaymentMethod)Enum.Parse(typeof(eBayPaymentMethod), pp.InnerText));
                                        }

                                        break;


                                    case "pictureURLLarge":

                                        eb.PictureURLLarge = ebItem.InnerText;

                                        break;

                                    case "pictureURLSuperSize":

                                        eb.PictureURLSuperSize = ebItem.InnerText;

                                        break;


                                    case "postalCode":

                                        eb.PostalCode = ebItem.InnerText;

                                        break;


                                    case "primaryCategory":

                                        Category sf = new Category();

                                        foreach (XmlNode n in ebItem.ChildNodes)
                                        {
                                            switch(n.Name)
                                            {
                                                case "categoryName":
                                                sf.CategoryName = n.InnerText;
                                                break;

                                                case "categoryId":
                                                sf.CategoryID = n.InnerText;
                                                break;
                                             }

                                        }

                                        eb.PrimaryCategory = sf;


                                        break;


                                    case "secondaryCategory":

                                        Category cf = new Category();

                                        foreach (XmlNode n in ebItem.ChildNodes)
                                        {
                                            switch (n.Name)
                                            {
                                                case "categoryName":
                                                    cf.CategoryName = n.InnerText;
                                                    break;

                                                case "categoryId":
                                                    cf.CategoryID = n.InnerText;
                                                    break;
                                            }

                                        }

                                        eb.SecondaryCategory = cf;


                                        break;


                                    case "productId":

                                        eb.ProductID = ebItem.InnerText;

                                        break;

                                    case "returnsAccepted":

                                        eb.ReturnsAccepted = bool.Parse(ebItem.InnerText);

                                        break;


                                    case "sellerInfo":


                                        eb.SellerInfo   = new eBaySellerInfo();

                                        foreach (XmlNode no in ebItem.ChildNodes)
                                        {
                                            switch (no.Name)
                                            {

                                                case "feedbackRatingStar":

                                                    eb.SellerInfo.FeedbackRatingStar = no.InnerText;

                                                    break;


                                                case "feedbackScore":

                                                    eb.SellerInfo.FeedbackScore = long.Parse( no.InnerText);

                                                    break;


                                                case "positiveFeedbackPercent":

                                                    eb.SellerInfo.PositiveFeedbackPercent = double.Parse(no.InnerText);

                                                    break;

                                                case "sellerUserName":

                                                    eb.SellerInfo.SellerUserName = no.InnerText;

                                                    break;

                                                case "topRatedSeller":

                                                    eb.SellerInfo.TopRatedSeller = bool.Parse(no.InnerText);

                                                    break;

                                            }

                                        }


                                        break;
                                    
                                    case "sellingStatus":

                                        eBaySellingStatus sel = new eBaySellingStatus();

                                        foreach (XmlNode sod in ebItem.ChildNodes)
                                        {
                                            switch (sod.Name)
                                            {
                                                case "bidCount":

                                                    sel.BidCount = int.Parse(sod.InnerText);

                                                    break;


                                                case "convertedCurrentPrice":

                                                    eBayListingInfo.AmountType ccp = new eBayListingInfo.AmountType();
                                                    ccp.Amount = double.Parse(sod.InnerText);
                                                    ccp.CurrencyID = sod.Attributes["currencyId"].InnerText;

                                                    sel.ConvertedCurrentPrice = ccp;

                                                    break;


                                                case "currentPrice":

                                                    eBayListingInfo.AmountType cp = new eBayListingInfo.AmountType();
                                                    cp.Amount = double.Parse(sod.InnerText);
                                                    cp.CurrencyID = sod.Attributes["currencyId"].InnerText;

                                                    sel.CurrentPrice = cp;

                                                    break;


                                                case "sellingState":

                                                    sel.SellingState = (eBaySellingStatus.SellingStateType)Enum.Parse(typeof(eBaySellingStatus.SellingStateType), sod.InnerText);


                                                    break;


                                                case "timeLeft":

                                                    sel.TimeLeft = getTimeLeft(sod.InnerText);

                                                    break;
  

                                            }

                                        }


                                        eb.SellingStatus = sel;

                                        break;


                                    case "shippingInfo":

                                        ShippingInfo si = new ShippingInfo();

                                        foreach (XmlNode s in ebItem.ChildNodes)
                                        {
                                            switch (s.Name)
                                            {
                                                case "shippingServiceCost":

                                                    si.ShippingServiceCost = new eBayListingInfo.AmountType();
                                                    si.ShippingServiceCost.Amount = double.Parse(s.InnerText);
                                                    si.ShippingServiceCost.CurrencyID = s.Attributes["currencyId"].InnerText;

                                                    break;

                                                case "shippingType":

                                                    si.ShippingType = (ShippingInfo.ShippingTypes)Enum.Parse(typeof(ShippingInfo.ShippingTypes), s.InnerText);

                                                    break;

                                                case "shipToLocations":

                                                    si.ShipToLocations = new List<string>();

                                                    foreach (XmlNode pp in s.ChildNodes)
                                                    {

                                                        si.ShipToLocations.Add(pp.InnerText);
                                                    }

                                                    break;


                                                case "expeditedShipping":

                                                    si.ExpeditedShipping = bool.Parse(s.InnerText);

                                                    break;

                                                case "handlingTime":

                                                    si.HandlingTime = int.Parse(s.InnerText);

                                                    break;

                                            }
                                        }

                                        eb.ShippingInfo = si;

                                        break;


                                    case "storeInfo":

                                        eBayStoreInfo esi = new eBayStoreInfo();

                                        foreach (XmlNode es in ebItem.ChildNodes)
                                        {
                                            switch (es.Name)
                                            {
                                                case "storeName":

                                                    esi.StoreName = es.InnerText;

                                                    break;

                                                case "storeURL":

                                                    esi.StoreURL = es.InnerText;

                                                    break;
                                            }

                                        }

                                        eb.StoreInfo = esi;

                                        break;

                                    case "subtitle":

                                        eb.SubTitle = ebItem.InnerText;

                                        break;

                                    case "title":

                                        eb.Title = ebItem.InnerText;

                                        break;

                                    case "viewItemURL":

                                        eb.ViewItemURL = ebItem.InnerText;

                                        break;

                                  
                                  

                                    case "condition":

                                        Condition c = new Condition();

                                        foreach (XmlNode co in ebItem)
                                        {
                                            switch (co.Name)
                                            {
                                                case "conditionId":

                                                    c.ConditionID = co.InnerText;

                                                    break;

                                                case "conditionDisplayName":

                                                    c.ConditionDisplayName = co.InnerText;

                                                    break;

                                            }
                                        }

                                        
                               

                                        eb.Condition = c;

                                       

                                        break;



                                }
                            }


                            ebs.Add(eb);

                        }

                         fir.SearchResults = ebs;
                        
                        break;


                   

                      

                }

                
            }


            fir.Version = xver.InnerText;
            fir.ItemSearchURL = xurl.InnerText;
            fir.TimeStamp = DateTime.Parse(xtim.InnerText);



            return fir;
        }

        private static TimeSpan getTimeLeft(string TimeLeft)
        {

            string s = TimeLeft.Replace("D", " days");
            s = s.Replace("H", " hours ");
            s = s.Replace("M", " minutes ");
            s = s.Replace("S", " seconds");

            s = s.Replace("T", " ");
            s = s.Replace("P", " ");

            Regex reg = new Regex(@"[0-9]+");

            MatchCollection mc = reg.Matches(s);

            
            //if (mc.Count > 0)
            //{
                int days = int.Parse( mc[0].Value);
                int hours = int.Parse(mc[1].Value);
                int minutes = int.Parse(mc[2].Value);
                int seconds = int.Parse(mc[3].Value);


              

            //}

            TimeSpan ts = new TimeSpan(days, hours, minutes, seconds);

            return ts;
           


            // IT MEANS THIS: 
            // P   = Pending (INDICATOR OF ISO8601 DURATION) 
            // 1Y  = 1 Year 
            // 2M  = 2 Months 
            // 2D  = Two Days 
            // T   = Time Separator (M is ambiguous) 
            // 16H = Sixteen hours 
            // 2M  = Two minutes 
            // 40S = Forty seconds 

        }

    }
}
