using System.Xml;

public class NewsRSS
{
    private XmlDocument _rss = null;
    public struct RssChannel
    {
        public string Title;
        public string Link;
        public string Description;
    }

    public struct RssItem
    {
        public string Title;
        public string Link;
        public string Description;
    }

    private static XmlDocument addRssChannel(XmlDocument xmlDocument, RssChannel channel)
    {
        XmlElement channelElement = xmlDocument.CreateElement("channel");

        XmlNode rssElement = xmlDocument.SelectSingleNode("rss");

        rssElement.AppendChild(channelElement);

        XmlElement titleElement = xmlDocument.CreateElement("title");

        titleElement.InnerText = channel.Title;

        channelElement.AppendChild(titleElement);

        XmlElement linkElement = xmlDocument.CreateElement("link");

        linkElement.InnerText = channel.Link;

        channelElement.AppendChild(linkElement);

        XmlElement descriptionElement = xmlDocument.CreateElement("description");

        descriptionElement.InnerText = channel.Description;

        channelElement.AppendChild(descriptionElement);

        // Generator information

        XmlElement generatorElement = xmlDocument.CreateElement("generator");

        generatorElement.InnerText = "RSS Generator by tuan.it89";

        channelElement.AppendChild(generatorElement);

        return xmlDocument;
    }

    private static XmlDocument addRssItem(XmlDocument xmlDocument, RssItem item)
    {
        XmlElement itemElement = xmlDocument.CreateElement("item");

        XmlNode channelElement = xmlDocument.SelectSingleNode("rss/channel");

        XmlElement titleElement = xmlDocument.CreateElement("title");

        titleElement.InnerText = item.Title;

        itemElement.AppendChild(titleElement);

        XmlElement linkElement = xmlDocument.CreateElement("link");

        linkElement.InnerText = item.Link;

        itemElement.AppendChild(linkElement);

        XmlElement descriptionElement = xmlDocument.CreateElement("description");

        descriptionElement.InnerText = item.Description;

        itemElement.AppendChild(descriptionElement);

        // append the item

        channelElement.AppendChild(itemElement);

        return xmlDocument;
    }
   
    public NewsRSS()
    {
        _rss = new XmlDocument();
        XmlDeclaration xmlDeclaration = _rss.CreateXmlDeclaration("1.0", "utf-8", null);
        _rss.InsertBefore(xmlDeclaration, _rss.DocumentElement);

        XmlElement rssElement = _rss.CreateElement("rss");
        XmlAttribute rssVersionAttribute = _rss.CreateAttribute("version");

        rssVersionAttribute.InnerText = "2.0";
       
        rssElement.Attributes.Append(rssVersionAttribute);

        _rss.AppendChild(rssElement);
    }

    public void AddRssChannel(RssChannel channel)
    {
        _rss = addRssChannel(_rss, channel);
    }

    public void AddRssItem(RssItem item)
    {
        _rss = addRssItem(_rss, item);
    }

    public string RssDocument
    {
        get
        {
            return _rss.OuterXml;
        }
    }

    public XmlDocument RssXMLDocument
    {
        get 
        {
            _rss.Normalize();
            return _rss;
        }
    }

	
}
