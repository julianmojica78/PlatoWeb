using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;


public class MAC
{
    public MAC()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public String mac()
    {

        NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

        String sMacAddress = string.Empty;

        foreach (NetworkInterface adapter in nics)
        {

            if (sMacAddress == String.Empty) // only return MAC Address from first card    
            {

                IPInterfaceProperties properties = adapter.GetIPProperties();

                sMacAddress = adapter.GetPhysicalAddress().ToString();

            }

        }
        return sMacAddress;

    }


    public String ip()
    {
        string IP4Address = String.Empty;

        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily == AddressFamily.InterNetwork)
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        return IP4Address;
    }



}

/*  [DllImport("iphlpapi.dll", ExactSpelling = true)]
  public static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);

  public static string GetMAC(ref string IP)
  {
      string MAC = null;

      try
      {
          if (IPAddress.Parse(IP).Equals(IPAddress.Parse("127.0.0.1")) || IPAddress.Parse(IP).Equals(IPAddress.Parse("::1")))
          {
              System.Net.IPHostEntry iPHostEntry = Dns.GetHostEntry(HttpContext.Current.Server.MachineName);

              IP = iPHostEntry.AddressList[1].ToString();
          }

          System.Net.IPAddress ipAddress = IPAddress.Parse(IP);

          byte[] ab = new byte[6];
          int len = ab.Length;

          int r = SendARP((int)ipAddress.Address, 0, ab, ref len);
          MAC = BitConverter.ToString(ab, 0, 6);
      }
      catch (Exception)
      {
          MAC = null;
      }

      return MAC;
  }
}*/
