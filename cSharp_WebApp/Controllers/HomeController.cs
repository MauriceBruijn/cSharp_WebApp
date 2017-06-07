using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Web.Mvc;
using System.IO;

namespace cSharp_WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult XML()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            FileStream fs = new FileStream("Content/Songs.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("Artist");

                switch (xmldoc.NodeType)
                {
                   case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + xmldoc.Artist);
                   break;
                     
                   case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(xmldoc.Value);
                       break;
            }
        }

        public ActionResult JSON()
        {
            int a = 5;
            
            for (int i = 0; i < a; i++)
            {
                ViewBag.Message = "test123";
            }

            return View();
        }
    }
}