using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace ProxyChecker
{
    class FormControlHelper
    {
        delegate void UniversalVoidDelegate();
        public static void ControlInvoke(Control control, Action function)
        {
            if (control.IsDisposed || control.Disposing)
                return;

            if (control.InvokeRequired)
            {
                control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
                return;
            }
            function();
        }
    }
    public class IPInfo
    {
        public bool RespondPing = false;
        public IPAddress IP = IPAddress.Parse("0.0.0.0");
        public string Status = "";
        public string Country = "";
        public string CountryCode = "";
        public string Region = "";
        public string RegionName = "";
        public string City = "";
        public string Zip = "";
        public float Latitude = 0;
        public float Longitude = 0;
        public string Timezone = "";
        public string ISP = "";
        public string Organization = "";
    }
    
    public class Functions
    {
        
        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

        public IPInfo GetMyIPInfo()
        {
            try
            {
                IPInfo Result = new IPInfo();
                XmlDocument doc = new XmlDocument();

                doc.LoadXml((new WebClient()).DownloadString("http://ip-api.com/xml/"));



                Result.IP = IPAddress.Parse(((XmlNode)doc.DocumentElement.SelectSingleNode("query")).InnerText);
                Result.Status = ((XmlNode)doc.DocumentElement.SelectSingleNode("status")).InnerText;
                Result.Country = ((XmlNode)doc.DocumentElement.SelectSingleNode("country")).InnerText;
                Result.CountryCode = ((XmlNode)doc.DocumentElement.SelectSingleNode("countryCode")).InnerText;
                Result.Region = ((XmlNode)doc.DocumentElement.SelectSingleNode("region")).InnerText;
                Result.RegionName = ((XmlNode)doc.DocumentElement.SelectSingleNode("regionName")).InnerText;
                Result.City = ((XmlNode)doc.DocumentElement.SelectSingleNode("city")).InnerText;
                Result.Zip = ((XmlNode)doc.DocumentElement.SelectSingleNode("zip")).InnerText;
                Result.Latitude = float.Parse(((XmlNode)doc.DocumentElement.SelectSingleNode("lat")).InnerText, CultureInfo.InvariantCulture.NumberFormat);
                Result.Longitude = float.Parse(((XmlNode)doc.DocumentElement.SelectSingleNode("lon")).InnerText, CultureInfo.InvariantCulture.NumberFormat);
                Result.Timezone = ((XmlNode)doc.DocumentElement.SelectSingleNode("timezone")).InnerText;
                Result.ISP = ((XmlNode)doc.DocumentElement.SelectSingleNode("isp")).InnerText;
                Result.Organization = ((XmlNode)doc.DocumentElement.SelectSingleNode("org")).InnerText;

                Result.RespondPing = PingHost(((XmlNode)doc.DocumentElement.SelectSingleNode("query")).InnerText);

                return Result;
            }
            catch
            {
                return null;
            }
        }
    }
}
