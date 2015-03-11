using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;

namespace WebApplication1 
{
    public class FirstClass
    {
        public void MakeRequest(string request)
        {
            Course course = new Course();
            string message = "";

            //TODO: figure out how to make curl calls 

            WebClient webClient = new WebClient();
            dynamic result =
                jsonConvert.Parse(
                    webClient.DownloadString(""));
            Console.WriteLine(result.response.user.firstName);
        }




        public string CreateRequest()
        {
            string request = "";


            return request;
        }

        public void GetToken()
        {
            try
            {
               // TODO: figure out how to make curl calls
                HttpWebRequest request = WebRequest.Create("") as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }


}