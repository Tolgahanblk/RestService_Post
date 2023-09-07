using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace ConsoleAppWebServicePost
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Web servis sdresleri
            var client = new RestClient("https://....");
            var client2 = new RestClient("https://....");
            var client3 = new RestClient("https://....");
            #endregion

            #region İlk Veri alma mesajları

            while (true)
            {
                Console.WriteLine(" 1 - AboneNoList");
                Console.WriteLine(" 2 - LogServiceTest");
                Console.WriteLine(" 3 - FSozlesmeDogrulaById");
                Console.WriteLine(" 4 - TahsilSorgulaByNo");
                Console.WriteLine(" 5 - TahsilKaydiIptalEt");
                Console.WriteLine();
                Console.Write("Kullanmak istediğiniz metodun numarasını yazın ve enter tusuna basın veya çıkış yapmak için 'q' tuşuna basın: ");
                string metodSecim = Console.ReadLine();

                if (metodSecim == "q")
                {
                    break;
                }
                switch (metodSecim)
                {
                    case "1":
                        AboneNoListMethod(client);
                        break;
                    case "2":
                        LogServiceTestMethod(client2);
                        break;
                    case "3":
                        SozlesmeDogrulaByIdMethod(client3);
                        break;
                    case "4":
                        TahsilSorgulaByNoMethod(client);
                        break;
                    case "5":
                        TahsilKaydiIptalEtMethod(client);
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim...");
                        break;
                }
            }

            Console.ReadLine();
            #endregion

        }


        private static void LogServiceTestMethod(RestClient client2)
        {
            Console.WriteLine();
            var request = new RestRequest("LogServiceTest", Method.POST);
            request.AddHeader("Authorization", "applicationkey=adfasdf,md5hashcode=adfsasdf,requestdate=adfadfs");
            IRestResponse response = client2.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("İstek başarıyla tamamlandı.");
                dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
                Console.WriteLine("JSON Yanıtı : ");
                Console.WriteLine("");
                foreach (var item in jsonResponse)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Hata kodu: " + response.StatusCode);
                Console.WriteLine("Hata mesajı: " + response.ErrorMessage);
            }
            Console.ReadLine();
        }

        private static void AboneNoListMethod(RestClient client)
        {
            Console.WriteLine();
            Console.Write("AboneNoList verisini girin: ");
            string aysAboneNoList = "AboneNoList=" + Console.ReadLine();

            var request = new RestRequest("FindAllBorcSorgu", Method.POST);

            string rawTextData = aysAboneNoList;

            request.AddParameter("text/plain", rawTextData, ParameterType.RequestBody);

            request.AddHeader("Authorization", "applicationkey=asdfasdf,md5hashcode=asdfasdf,requestdate=asdfasdf");
            request.AddHeader("Content-Type", "application/json");

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("İstek başarıyla tamamlandı.");
                dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
                Console.WriteLine("JSON Yanıtı : ");
                Console.WriteLine("");
                foreach (var item in jsonResponse)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Hata kodu: " + response.StatusCode);
                Console.WriteLine("Hata mesajı: " + response.ErrorMessage);
            }
            Console.ReadLine();
        }
        private static void SozlesmeDogrulaByIdMethod(RestClient client3)
        {
            Console.WriteLine();
            Console.Write("beyans verisini girin: ");
            string beyanId = "beyans=" + Console.ReadLine();

            var request = new RestRequest("SozlesmeDogrulaById", Method.POST);

            string rawTextData = beyanId;

            request.AddParameter("text/plain", rawTextData, ParameterType.RequestBody);

            request.AddHeader("Authorization", "applicationkey=sdfgsdfg,md5hashcode=sfgsdfg,requestdate=sfgsdfg");
            request.AddHeader("Content-Type", "application/json");

            IRestResponse response = client3.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("İstek başarıyla tamamlandı.");
                dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
                Console.WriteLine("JSON Yanıtı : ");
                Console.WriteLine("");
                foreach (var item in jsonResponse)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Hata kodu: " + response.StatusCode);
                Console.WriteLine("Hata mesajı: " + response.ErrorMessage);
            }
            Console.ReadLine();
        }

        private static void TahsilSorgulaByNoMethod(RestClient client)
        {
            Console.WriteLine();
            Console.Write("Islem No verisini girin: ");
            string tahsilAboneNoList = "VezneId=99999" + "&" + "islemNo=" + Console.ReadLine();

            var request = new RestRequest("TahsilSorgulaByIslemNo", Method.POST);

            string rawTextData = tahsilAboneNoList;

            request.AddParameter("text/plain", rawTextData, ParameterType.RequestBody);

            request.AddHeader("Authorization", "applicationkey=asdfasf,md5hashcode=asdfadsf,requestdate=asdfasfd");
            request.AddHeader("Content-Type", "application/json");

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine();
                Console.WriteLine("İstek başarıyla tamamlandı.");
                dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
                Console.WriteLine("JSON Yanıtı : ");
                Console.WriteLine("");
                foreach (var item in jsonResponse)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Hata kodu: " + response.StatusCode);
                Console.WriteLine("Hata mesajı: " + response.ErrorMessage);
            }
            Console.ReadLine();
        }

        private static void TahsilKaydiIptalEtMethod(RestClient client)
        {
            Console.WriteLine();
            Console.Write("TahsilId verisini girin: ");
            string tahsilAboneNoList = "VezneId=999999" + "&" + "TahsilId=" + Console.ReadLine();

            var request = new RestRequest("TahsilKaydiIptalEt", Method.POST);

            string rawTextData = tahsilAboneNoList;

            request.AddParameter("text/plain", rawTextData, ParameterType.RequestBody);

            request.AddHeader("Authorization", "applicationkey=asdfasf,md5hashcode=afsdf,requestdate=asdfasfd");
            request.AddHeader("Content-Type", "application/json");

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine();
                Console.WriteLine("İstek başarıyla tamamlandı.");
                dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
                Console.WriteLine("JSON Yanıtı : ");
                Console.WriteLine("");
                foreach (var item in jsonResponse)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Hata kodu: " + response.StatusCode);
                Console.WriteLine("Hata mesajı: " + response.ErrorMessage);
            }
            Console.ReadLine();
        }
    }
}
