using FAXM.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace FAXM.Services
{
    class UserService
    {
        public bool login(User user)
        {
            var url = $"https://kaantera.com/api/login/authenticate";
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = "{" + "\"user\":"+user.Username+", "+"\"pass\":"+user.Pass+"}";
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "applicaton/json";
            using (var streamWriter =new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }   
            try
            {
                using(WebResponse response = request.GetResponse()){
                    using(Stream strTreader = response.GetResponseStream())
                    {
                        if (strTreader == null) return false;
                        using (StreamReader objReader=new StreamReader(strTreader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            Console.WriteLine(responseBody);
                            if (responseBody.CompareTo("Unauthorized")==0){
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
