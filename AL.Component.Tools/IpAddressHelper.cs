using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace AL.Component.Tools
{
    public class IpAddressHelper
    {
        /// <summary>
        /// 获取客户端IP地址(如果有1级代理以上的使用)
        /// </summary>
        /// <returns></returns>
        public static string GetIPAddress()
        {
            if (HttpContext.Current != null)
            {
                string ip = GetAddress(HttpContext.Current.Request);

                if (ip.Contains(","))
                {
                    ip = ip.Split(',')[0].Trim();
                }

                return ip;
            }
            else
                return null;
        }

        /// <summary>
        /// 获取客户端IP地址
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetAddress(HttpRequest request)
        {
            //可以透过代理服务器
            string remoteAddr = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(remoteAddr))
            {
                //没有代理服务器,如果有代理服务器获取的是代理服务器的IP
                remoteAddr = request.ServerVariables["REMOTE_ADDR"];
            }

            if (!string.IsNullOrEmpty(remoteAddr) 
                && remoteAddr.IndexOf(",") != -1 
                && remoteAddr.Trim().Length > 6)
                remoteAddr = remoteAddr.Split(',')[0].Trim();
            
            if (remoteAddr.Length > 15)
                remoteAddr = GetIP4Address();

            return remoteAddr;
        }

        public static string GetIP4Address()
        {
            string IP4Address = String.Empty;

            foreach (IPAddress IPA in Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }

            if (!string.IsNullOrEmpty(IP4Address))
            {
                return IP4Address;
            }

            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }

            return IP4Address;
        }
    }
}
