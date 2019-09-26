using BCDockerHelper.UI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BCDockerHelper.Classes
{
    public class Tag
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public static string GetTagFromList(string image)
        {
            GUIHelper.ChangeCursor(Cursors.WaitCursor);
            string tag = "";
            TagList tl = new TagList();
            tl.SetTags(GetTags(image));
            GUIHelper.ChangeCursor(Cursors.Default);
            if (tl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tag = tl.GetSelected();
            }
            return tag;
        }

        private static List<Tag> GetTags(string image)
        {
            if(image.StartsWith("microsoft"))
                return GetFromDefaultRegistry(image);
            if (image.StartsWith("mcr"))
                return GetFromMCRRegistry(image);
            return DefaultList();
        }

        private static List<Tag> DefaultList()
        {
            List<Tag> result = new List<Tag>
            {
                new Tag { Name = "w1" },
                new Tag { Name = "at" },
                new Tag { Name = "de" }
            };
            return result;
        }

        private static List<Tag> GetFromMCRRegistry(string image)
        {
            List<Tag> result = new List<Tag>();
            image = image.Replace("mcr.microsoft.com/", "");

            string baseuri = "https://mcr.microsoft.com/v2/{0}/tags/list";
            baseuri = string.Format(baseuri, image);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseuri);
            try
            {
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responeText = reader.ReadToEnd();
                JObject json = JObject.Parse(responeText);
                var tags = from x
                           in json["tags"]
                           select new Tag { Name = x.ToString() };
                foreach (Tag t in tags)
                    result.Add(t);
            }
            catch
            {
                result = DefaultList();
            }
            return result;
        }

        private static List<Tag> GetFromDefaultRegistry(string image)
        {
            List<Tag> result = new List<Tag>();
            string baseuri = "https://registry.hub.docker.com/v2/repositories/{0}/tags/?page_size=1000";
            baseuri = string.Format(baseuri, image);
            string next = baseuri;
            while (!string.IsNullOrEmpty(next))
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(next);
                try
                {
                    WebResponse response = request.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string responeText = reader.ReadToEnd();
                    JObject json = JObject.Parse(responeText);
                    var jsonnext = json["next"];
                    next = jsonnext?.ToString();
                    var results = json["results"];
                    var tags = from x
                                in results
                               select new Tag
                               {
                                   Name = x["name"].ToString(),
                                   Date = x["last_updated"].ToString()
                               };
                    foreach (Tag t in tags)
                        result.Add(t);


                }
                catch
                {
                    next = "";
                }
            }
            if (result.Count == 0)
            {
                result = DefaultList();
            }
            result.Sort((x, y) => String.Compare(x.Name, y.Name));
            return result;
        }
    }
}
