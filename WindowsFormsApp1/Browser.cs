using System;
using System.IO;
using System.Net;

namespace WindowsFormsApp1
{
    class Browser
    {

        private String visitUrl;
        private String homeUrl ;
        private String websiteDetails;
        private String statusCode;
        private int intStatus;

        public String VISIT_URL
        {
            get { return visitUrl; }
            set { this.visitUrl = value; }
        }

        public String STATUS_CODE
        {
            get { return statusCode; }
            set { this.statusCode = value; }
        }
        public String HOME_URL
        {
            get { return homeUrl; }
            set { this.homeUrl = value; }

        }
        public String WEBSITE_DETAILS
        {
            get { return websiteDetails; }
            set { this.websiteDetails = value; }

        }

        // The method that sends HTTP requests and receives HTTP responses
        public void visitWebsite(String visitURL)
        {
            
                HttpWebResponse response = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("Https://" + visitURL);


                response = (HttpWebResponse)request.GetResponse();
                statusCode = "OK";
                intStatus = 200;

                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                websiteDetails = reader.ReadToEnd();

            }
            catch (System.UriFormatException e)
            {
                statusCode = "Bad Request";
                intStatus = 400;
                websiteDetails = "";
            }
            //Dealing with the exception that website throws an error message
            catch (WebException we)
            {
                response = (HttpWebResponse)we.Response;

                if (response == null)
                {
                    statusCode = "Bad Request";
                    intStatus = 400;
                    websiteDetails = "";
                }

                else
                {

                    if ((int)response.StatusCode == 400)
                    {
                        statusCode = "Bad Request";
                        intStatus = 400;
                        websiteDetails = "";
                    }
                    else if ((int)response.StatusCode == 403)
                    {
                        statusCode = "Forbidden";
                        intStatus = 403;
                        websiteDetails = "";
                    }

                    else
                    {
                        statusCode = "Not Found";
                        intStatus = 404;
                        websiteDetails = "";
                    }

                }

            }

            writeHistory();
            statusCode = intStatus + " " + statusCode;
        }
        // The method that writes history for each website visited
        public void writeHistory()
        {
            using (StreamWriter sw = File.AppendText("History.txt"))
            {
                sw.WriteLine(visitUrl);

                sw.Close();
            }

        }
    }
}
