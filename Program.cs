using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using HtmlAgilityPack;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml;
using System.Data.SQLite;
using System.Threading;
using Newtonsoft.Json.Linq;
//using System.Text.RegularExpressions;

namespace Mugshots_US_States_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region States
            //SQLiteConnection conn = new SQLiteConnection("Data Source=Mugshots(US-States).db;Version=3;");
            //conn.Open();
            //string url = "https://mugshots.com/US-States/";
            //string html = DownloadHtml(url);
            //HtmlDocument doc = new HtmlDocument();
            //doc.LoadHtml(html);
            //string filePath = @"C:\Users\scrip\OneDrive\Desktop\new 5.html";
            //File.WriteAllText(filePath, html);
            //Console.WriteLine("HTML document saved successfully at " + filePath);
            //string state = "", state_url = "";

            //if (doc != null)
            //{
            //    HtmlNode tardiv = doc.DocumentNode.SelectSingleNode(".//div[@id='subcategories']");
            //    if (tardiv != null)
            //    {
            //        if (tardiv.SelectNodes(".//div[@class='column']") != null)
            //        {
            //            foreach (var a in tardiv.SelectNodes(".//div[@class='column']"))
            //            {
            //                if (a.SelectNodes(".//li") != null)
            //                {
            //                    foreach (var item in a.SelectNodes(".//li"))
            //                    {
            //                        if (item.InnerText != null)
            //                        {
            //                            state = strClean(item.InnerText);
            //                        }

            //                        if (item.SelectSingleNode(".//a") != null)
            //                        {
            //                            state_url = "https://mugshots.com" + item.SelectSingleNode(".//a").Attributes["href"].Value;
            //                        }

            //                        SQLiteCommand cmd = new SQLiteCommand("INSERT INTO [Data_States] ([source_url], [states], [states_url]) VALUES (?,?,?)", conn);
            //                        cmd.Parameters.AddWithValue("", url);
            //                        cmd.Parameters.AddWithValue("", state);
            //                        cmd.Parameters.AddWithValue("", state_url);
            //                        cmd.ExecuteNonQuery();

            //                        long insertedId = conn.LastInsertRowId;

            //                        Console.WriteLine($"Row ID: {insertedId}, Work done at {DateTime.Now}");

            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            #endregion

            #region Regions
            //SQLiteConnection conn = new SQLiteConnection("Data Source=Mugshots(US-States).db;Version=3;");
            //conn.Open();

            //using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Data_States", conn))
            //{
            //    using (SQLiteDataReader reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            string url = reader["states_url"].ToString();
            //            string html = DownloadHtml(url);
            //            HtmlDocument doc = new HtmlDocument();
            //            doc.LoadHtml(html);
            //            string filePath = @"C:\Users\scrip\OneDrive\Desktop\new 5.html";
            //            File.WriteAllText(filePath, html);
            //            Console.WriteLine("HTML document saved successfully at " + filePath);
            //            string region = "", region_url = "";

            //            if (doc != null)
            //            {
            //                HtmlNode tardiv = doc.DocumentNode.SelectSingleNode(".//div[@id='subcategories']");
            //                if (tardiv != null)
            //                {
            //                    if (tardiv.SelectNodes(".//div[@class='column']") != null)
            //                    {
            //                        foreach (var a in tardiv.SelectNodes(".//div[@class='column']"))
            //                        {
            //                            if (a.SelectNodes(".//li") != null)
            //                            {
            //                                foreach (var item in a.SelectNodes(".//li"))
            //                                {
            //                                    if (item.InnerText != null)
            //                                    {
            //                                        region = strClean(item.InnerText);
            //                                    }

            //                                    if (item.SelectSingleNode(".//a") != null)
            //                                    {
            //                                        region_url = "https://mugshots.com" + item.SelectSingleNode(".//a").Attributes["href"].Value;
            //                                    }

            //                                    SQLiteCommand cmd1 = new SQLiteCommand("INSERT INTO [Data_Region] ([state], [region], [region_url]) VALUES (?,?,?)", conn);
            //                                    cmd1.Parameters.AddWithValue("", reader["states"].ToString());
            //                                    cmd1.Parameters.AddWithValue("", region);
            //                                    cmd1.Parameters.AddWithValue("", region_url);
            //                                    cmd1.ExecuteNonQuery();

            //                                    long insertedId = conn.LastInsertRowId;

            //                                    Console.WriteLine($"Row ID: {insertedId}, Work done at {DateTime.Now}");

            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }

            //        }
            //    }
            //}

            #endregion

            #region list (Chrome)
            //SQLiteConnection conn = new SQLiteConnection("Data Source=Mugshots(US-States).db;Version=3;");
            //conn.Open();

            //using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Data_Region", conn))
            //{
            //    using (SQLiteDataReader reader = cmd.ExecuteReader())
            //    {
            //        ChromeDriver driver = new ChromeDriver();
            //        while (reader.Read())
            //        {
            //            string url = reader["region_url"].ToString();
            //            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //            driver.Navigate().GoToUrl(url);

            //        endLoop:
            //            string html = driver.PageSource;
            //            HtmlDocument doc = new HtmlDocument();
            //            doc.LoadHtml(html);
            //            string name = "", img = "", detail_url = "";

            //            if (doc != null)
            //            {
            //                HtmlNode tardiv = doc.DocumentNode.SelectSingleNode(".//table");
            //                if (tardiv != null)
            //                {
            //                    HtmlNodeCollection tr = tardiv.SelectNodes(".//tr");
            //                    if (tr != null)
            //                    {
            //                        foreach (var a in tr)
            //                        {
            //                            if (a.SelectNodes(".//td") != null)
            //                            {
            //                                foreach (var item in a.SelectNodes(".//td"))
            //                                {
            //                                    if (item.SelectSingleNode(".//a[@class='image-preview']") != null)
            //                                    {
            //                                        if (item.SelectSingleNode(".//div[@class='label']") != null)
            //                                        {
            //                                            name = strClean(item.SelectSingleNode(".//div[@class='label']").InnerText);
            //                                        }

            //                                        detail_url = "https://mugshots.com" + item.SelectSingleNode(".//a[@class='image-preview']").Attributes["href"].Value;

            //                                        if (item.SelectSingleNode(".//div[@class='image']//img") != null)
            //                                        {
            //                                            img = item.SelectSingleNode(".//div[@class='image']//img").Attributes["src"].Value;
            //                                        }
            //                                        else
            //                                        {
            //                                            img = "";
            //                                        }

            //                                        SQLiteCommand cmd1 = new SQLiteCommand("INSERT INTO [Data_List] ([name], [img], [url], [state], [region], [source_url]) VALUES (?,?,?,?,?,?)", conn);
            //                                        cmd1.Parameters.AddWithValue("", name);
            //                                        cmd1.Parameters.AddWithValue("", img);
            //                                        cmd1.Parameters.AddWithValue("", detail_url);
            //                                        cmd1.Parameters.AddWithValue("", reader["state"].ToString());
            //                                        cmd1.Parameters.AddWithValue("", reader["region"].ToString());
            //                                        cmd1.Parameters.AddWithValue("", reader["region_url"].ToString());
            //                                        cmd1.ExecuteNonQuery();

            //                                        long insertedId = conn.LastInsertRowId;

            //                                        Console.WriteLine($"Row ID: {insertedId}, Work done at {DateTime.Now}");

            //                                    }
            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }

            //            if (driver.FindElements(By.XPath(".//a[contains(@class, 'next')]")).Count() > 0)
            //            {
            //                Thread.Sleep(5000); 
            //                IWebElement nextButton = driver.FindElement(By.XPath(".//a[contains(@class, 'next')]"));
            //                nextButton.Click();
            //                goto endLoop;
            //            }
            //        }
            //    }
            //}
            #endregion

            #region list (Json)
            string dbPath = Directory.GetCurrentDirectory() + @"\DoneDB\";
            string dbName = "Mugshots_" + DateTime.Now.ToString().Replace("/", "").Replace(":", "") + ".db";
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + dbPath + dbName + ";Version=3;");
            conn.Open();
            new SQLiteCommand("Create Table `Data_List` (id INTEGER PRIMARY KEY AUTOINCREMENT, name text, img text, url text, state text, region text, source_url text)", conn).ExecuteNonQuery();

            OleDbConnection sourceConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + args[0] +"; Jet OLEDB:Database Password=qwer@1234;Persist Security Info=True");
            sourceConn.Open();

            int rc = 0;
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Data_Region] Where done= False Order By id", sourceConn);
            OleDbDataReader rst = cmd.ExecuteReader();
            while (rst.Read())
            {
                    string stateName = Regex.Match(rst["state"].ToString(), @"^(.*?)\s*\(").Groups[1].Value.Trim();
                    stateName = FixString2(stateName);

                    string regionFullName = rst["region"].ToString();
                    string fixedString = FixString1(regionFullName);
                    string regionName = FixString2(fixedString);
                    string url = $"https://mugshots.com/US-States/{stateName}/{regionName}.json";

                    nextpage:
                    string json = DownloadHtml(url);
                    dynamic obj = JObject.Parse(json);
                    //string filePath = @"C:\Users\scrip\OneDrive\Desktop\data.json";
                    //File.WriteAllText(filePath, json);

                    int page = 0;
                    string key = "";
                         
                    if (obj["pagination"]["objects"] != null)
                    {
                        foreach (var item in obj["pagination"]["objects"])
                        {
                            string name = "", img = "", detail_url = "", width = "", height = "", file = "";
                            if (item["name"] != null)
                            {
                                name = item["name"].ToString().Trim(); 
                            }

                            if (item["default_image"] != null)
                            {
                                if (item["default_image"]["thumbnails"] != null)
                                {
                                    file = item["default_image"]["file"].ToString();
                                    string fileraw = Regex.Split(file, @"\.").First();

                                    foreach (var a in item["default_image"]["thumbnails"])
                                    {
                                        width = a["target_width"].ToString().Trim();
                                        height = a["target_height"].ToString().Trim();
                                        break;
                                    }

                                    if (width != "")
                                    {
                                        img = "https://thumbs.mugshots.com/" + fileraw + "." + width + "x" + height + ".jpg";
                                    }

                                    if (item["id"] != null)
                                    {
                                        detail_url = Regex.Split(url, @"\.json").First() + "/" + item["slug"] + "." + item["id"] + ".html";
                                    }
                                }
                            }
                                
                            SQLiteCommand cmd1 = new SQLiteCommand("INSERT INTO [Data_List] ([name], [img], [url], [state], [region], [source_url]) VALUES (?,?,?,?,?,?)", conn);
                            cmd1.Parameters.AddWithValue("", name);
                            cmd1.Parameters.AddWithValue("", img);
                            cmd1.Parameters.AddWithValue("", detail_url);
                            cmd1.Parameters.AddWithValue("", rst["state"].ToString());
                            cmd1.Parameters.AddWithValue("", rst["region"].ToString());
                            cmd1.Parameters.AddWithValue("", url);
                            cmd1.ExecuteNonQuery();
                            rc++;

                            if (rc == 1000)
                            {
                                if ((new FileInfo(dbPath + dbName).Length / 1000) > 5000000)
                                {//1 GB = 1073741824 Bytes
                                    conn.Close(); conn.Dispose();
                                    dbName = "Mugshots_" + DateTime.Now.ToString().Replace("/", "").Replace(":", "") + ".db";

                                    SQLiteConnection.CreateFile(dbPath + dbName);
                                    conn = new SQLiteConnection("Data Source=" + dbPath + dbName + ";Version=3;");
                                    conn.Open();
                                    new SQLiteCommand("Create Table `Data_List` (id INTEGER PRIMARY KEY AUTOINCREMENT, name text, img text, url text, state text, region text, source_url text)", conn).ExecuteNonQuery();
                                }
                                rc = 0;
                            }

                            long insertedId = conn.LastInsertRowId;

                            //Console.WriteLine($"Row ID: {insertedId}, Work done at {DateTime.Now}");
                        }
                        

                        if (obj["pagination"]["next"] != null)
                        {
                            if (obj["pagination"]["next"]["page"] != null)
                            {
                                page = Convert.ToInt32(obj["pagination"]["next"]["page"].ToString());
                                key = obj["pagination"]["next"]["key"].ToString();
                                //url = Regex.Split(url, @"\.json").FirstOrDefault() + ".json?fp=" + page + "&from=" + key;
                                url = $"https://mugshots.com/US-States/{stateName}/{regionName}.json?fp=" + page + "&from=" + key;
                                goto nextpage;
                            }
                        }
                        
                    }
                OleDbCommand cmd2 = new OleDbCommand("UPDATE [Data_Region] set  done = true WHERE id = ?", sourceConn);
                cmd2.Parameters.AddWithValue("", rst["id"].ToString());
                cmd2.ExecuteNonQuery();
                Console.WriteLine(rst["id"].ToString() + " : " + DateTime.Now.ToString());
            }
               
            #endregion

        }


        public static string FixString1(string input)
        {
            // Find the index of the opening parenthesis
            int indexOfParenthesis = input.IndexOf('(');

            if (indexOfParenthesis != -1)
            {
                // Remove the part inside the parentheses and trim any extra spaces
                return input.Substring(0, indexOfParenthesis).Trim();
            }

            // If no parentheses found, return the original string
            return input;
        }
        public static string FixString2(string input)
        {
            // Replace spaces with hyphens and remove commas
            input = input.Replace(" ", "-").Replace(",", "");

            return input;
        }
        public static string strClean(string str)
        {
            string result = Regex.Replace(str, @"\t|\n|\r", "");
            result = Regex.Replace(result, @"\s+", " ");
            result = Regex.Replace(result, "<!--.*?-->", string.Empty);
            result = WebUtility.HtmlDecode(result);
            result = Regex.Replace(result, "’", "'");
            result = result.Trim();
            return result;
        }
        public static string DownloadHtml(string url, Dictionary<dynamic, dynamic> headers = null, NetworkCredential credentials = null, bool utf8 = true, int timeout_ms = 0)
        {
            if (timeout_ms == 0)
                timeout_ms = 100000;

            string html = "";
            ServicePointManager.SecurityProtocol = /*SecurityProtocolType.Ssl3 |*/ SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            HttpWebRequest client = (HttpWebRequest)WebRequest.Create(url);
            client.CookieContainer = new CookieContainer();
            client.UserAgent = "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:38.0) Gecko/20100101 Firefox/38.0"; // "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.112 Safari/537.36";
            client.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            client.Credentials = credentials;
            client.Method = "GET";
            client.AllowAutoRedirect = true;
            if (timeout_ms > 0)
            {
                client.Timeout = timeout_ms;
                client.ReadWriteTimeout = timeout_ms;
            }
            client.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            WebHeaderCollection headcoll = client.Headers;
            headcoll.Add(HttpRequestHeader.AcceptLanguage, "en-SG");
            if (headers != null)
            {
                if (headers.Count() > 0)
                {
                    foreach (var item in headers)
                        client.Headers.Add(item.Key, item.Value);
                }
            }

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)client.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream);
                        html = reader.ReadToEnd();

                        //if (response.CharacterSet == "UTF-8")
                        //{
                        //    //byte[] bytes = Encoding.UTF8.GetBytes(html);
                        //    //html = Encoding.Default.GetString(bytes);
                        //}
                    }
                }
            }
            catch (Exception e)
            {
                //Common.LogError(e, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name.ToString() + " url:" + url);
                Console.WriteLine(url + " " + e.Message);
            }

            return html;
        }
    }
}
