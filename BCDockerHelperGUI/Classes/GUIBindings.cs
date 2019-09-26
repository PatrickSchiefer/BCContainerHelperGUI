using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BCDockerHelper.Classes
{
    [Serializable]
    public class GUIBindings : INotifyPropertyChanged
    {
        #region Singleton definition
        private static GUIBindings _instance;
        public static GUIBindings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = DeSerialize(Program.GuiSettingsPath);
                return _instance;
            }
        }

        private GUIBindings()
        {

        }
        #endregion

        #region Properties
        private string _containername = "BCContainer";
        private bool _windowsAuth = false;
        private string _username;
        [NonSerialized]
        private string _password;
        private bool _includeCSide = false;
        private string _dockerimage = "mcr.microsoft.com/businesscentral/onprem";
        private string _tag = "w1";


        public string Containername
        {
            set
            {
                _containername = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Containername"));
            }
            get
            {
                return _containername;
            }
        }
        public bool WindowsAuth
        {
            set
            {
                _windowsAuth = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("WindowsAuth"));
            }
            get
            {
                return _windowsAuth;
            }
        }
        public string Username
        {
            set
            {
                _username = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Username"));
            }
            get
            {
                return _username;
            }
        }
        public string Password
        {
            set
            {
                _password = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Password"));
            }
            get
            {
                return _password;
            }
        }
        public bool IncludeCSide
        {
            set
            {
                _includeCSide = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("IncludeCSide"));
            }
            get
            {
                return _includeCSide;
            }
        }

        public string Dockerimage
        {
            set
            {
                _dockerimage = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Dockerimage"));
            }
            get
            {
                return _dockerimage;
            }
        }
        public string Tag
        {
            set
            {
                _tag = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Tag"));
            }
            get
            {
                return _tag;
            }
        }
        


        #endregion

        #region Methods
        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public static void Serialize(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GUIBindings));

            using (XmlWriter writer = XmlWriter.Create(filename))
            {
                serializer.Serialize(writer, Instance);
            }
        }

        private static GUIBindings DeSerialize(string filename)
        {
            if (File.Exists(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(GUIBindings));

                using (XmlReader reader = XmlReader.Create(filename))
                {
                    return (GUIBindings)serializer.Deserialize(reader);
                }
            }
            else
            {
                return new GUIBindings();
            }
        }
        #endregion

    }
}
