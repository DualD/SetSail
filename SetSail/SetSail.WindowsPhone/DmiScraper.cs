using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace SetSail
{
    class DmiScraper
    {
        private HtmlWeb _webPage = new HtmlWeb();
        private HtmlDocument _webPageDoc;

        public async void LoadUrl(string url)
        {
            _webPageDoc = new HtmlDocument();
        }
        
        public void PullText(string xPath)
        {
            HtmlWeb web = new HtmlWeb();
            
            
           
        }
    }
}
