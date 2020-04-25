using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace FindingAPI
{



    /// <summary>
    /// gets the categories...
    /// </summary>
    /// 
    [Serializable()]
    public class Categories
    {
        public delegate void d_CategoryList(List<Category> Categories);
        public event d_CategoryList CategoryList;


        public string Version { get; set; }

        public Categories()
        {
            Version = "729";
        }

        public void GetCategoryList(int ParentCategory, eBayServiceCredentials.GlobalID SiteID, eBayServiceCredentials Credentials)
        {

            
            //TODO Check Store for local copy
            string url;
            
            XmlDocument xdoc = new XmlDocument();

            url = "http://open.api.ebay.com/Shopping?";
            url += "callname=GetCategoryInfo&appid=" + Credentials.SECURITY_APPNAME;
            url += "&siteid=3&CategoryID="; //+ SiteID.ToString() +
            url += ParentCategory.ToString() + "&version=" + this.Version + "&IncludeSelector=ChildCategories";

            xdoc.Load(url);
            

            List<Category> cats = new List<Category>();
    

            XmlNodeList names = xdoc.GetElementsByTagName("CategoryName");
            XmlNodeList ids = xdoc.GetElementsByTagName("CategoryID");
            XmlNodeList levels = xdoc.GetElementsByTagName("CategoryLevel");
            XmlNodeList parents = xdoc.GetElementsByTagName("CategoryParentID");
            XmlNodeList namepaths = xdoc.GetElementsByTagName("CategoryNamePath");
            XmlNodeList cids = xdoc.GetElementsByTagName("CategoryIDPath");
            XmlNodeList leafs = xdoc.GetElementsByTagName("LeafCategory");


            try
            {

                for (int i = 1; i < names.Count; i++)
                {


                    Category c = new Category();
                    c.SiteID = (int)SiteID;
                    c.CategoryName = names[i].InnerText;



                    c.CategoryID = int.Parse(ids[i].InnerText);
                    c.CategoryLevel = int.Parse(levels[i].InnerText);
                    c.CategoryParentID = int.Parse(parents[i].InnerText);
                   // c.CategoryNamePath = namepaths[i].InnerText;
                 //  c.CategoryIDPath = int.Parse(cids[i].InnerText);
                    c.LeafCategory = bool.Parse(leafs[i].InnerText);
                    cats.Add(c);
                }
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }



            onCategoryList(cats);


        }

   

        private void onCategoryList(List<Category> Categories)
        {
            if (CategoryList != null)
                CategoryList(Categories);
        }

        [Serializable]
        public class Category
        {
            public string CategoryName { get; set; }
            public int CategoryID { get; set; }
            public int CategoryLevel { get; set; }
            public int CategoryParentID { get; set; }
            public string CategoryNamePath { get; set; }
            public int CategoryIDPath { get; set; }
            public bool LeafCategory { get; set; }

            public int SiteID { get; set; }
        }


       
    }
}
