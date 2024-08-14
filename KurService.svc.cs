using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KurService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KurService" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select KurService.svc or KurService.svc.cs at the Solution Explorer and start debugging.
	public class KurService : IKurService
	{

		public List<double> KurlariGetir(string kurTipi)
		{
			Random randomKur = new Random();
			List<double> kurlarListesi = new List<double>();
			for (int i = 0; i < 15; i++)
			{
				kurlarListesi.Add(randomKur.NextDouble() + 2);
			}
			return kurlarListesi;
		}

		public List<string> ParaBirimleriniGetir()
		{
			List<string> paraBirimleriListesi = new List<string>();
			paraBirimleriListesi.Add("Dolar");
			paraBirimleriListesi.Add("Euro");
			paraBirimleriListesi.Add("Pound");
			return paraBirimleriListesi;
		}
	}
}
