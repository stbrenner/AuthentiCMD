using System;
using System.Security.Cryptography.X509Certificates;

namespace AuthentiCMD
{
    public class Program
    {
        public static void Main(string[] args)
        {
			try
			{
				var cert = new X509Certificate(args[0]);
				Console.WriteLine(cert.GetPublicKeyString());
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
        }
    }
}
