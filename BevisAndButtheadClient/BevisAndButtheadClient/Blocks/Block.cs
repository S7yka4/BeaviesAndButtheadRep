using Constructor.Storage.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BevisAndButtheadClient
{
    public class Block
    {
        protected GroupBox _groupBox;
        protected Label _label;
        protected ComboBox _comboBox;
        protected string _connectionString;
        protected Requester _client;
        protected Guid _assemblyId;
        protected PictureBox _pictureBox; 
        Dictionary<string, string> _idNamePair;
        string methodName;
        string _partName;
        public int Width
        {
            get
            {
                return _groupBox.Width;
            }
        }

        public int Height
        {
            get
            {
                return _groupBox.Height;
            }
        }

        public Point Location
        {
            get
            {
                return _groupBox.Location;
            }
            set
            {
                _groupBox.Location = value;
            }
        }

         string DownloadPhoto(string url,string filename)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(url, $"{filename}Download1.jpg");
                
            }
            return Path.GetFullPath($"{filename}Download1.jpg");
        }

        public Block(GroupBox groupbox, Label label,ComboBox comboBox, string connectionstr, Requester client,Guid assemblyId,PictureBox pb,string partName,Label Costlabel,List<Label> Alllabels)
        {
            _groupBox = groupbox;
            _label = label;
            _comboBox= comboBox;
            _connectionString = connectionstr; 
            _client = client;
            _assemblyId = assemblyId;
            _idNamePair= new Dictionary<string, string>();
            _pictureBox = pb;
            _partName= partName;

            string GetCompableQuery;
            string AddToAssemblyQuery;
            string DeleteFromAssembly;
            string GetByIdQuery;
            var types = new List<string>()
            {
                "FAN",
                "RAM",
                "Drive"
            };
            if (types.FirstOrDefault(_ => _ == _partName) == null)
            {
                GetCompableQuery = connectionstr + $"GetCompable/{_assemblyId}";
                AddToAssemblyQuery = connectionstr + "SetToAssembly";
                DeleteFromAssembly = connectionstr + methodName;
                GetByIdQuery = connectionstr + "GetById/";
                methodName = "SetToAssembly";
            }
            else
            {
                connectionstr = "api/Pair/";
                GetCompableQuery = $"api/{partName}/" + $"GetCompable/{_assemblyId}";
                AddToAssemblyQuery = $"api/Pair/Add{partName}InAssembly";
                DeleteFromAssembly = $"api/Pair/Delete{partName}InAssembly";
                GetByIdQuery = $"api/{partName}/GetById/";
                methodName = "SetToAssembly";
            }
            comboBox.Click += delegate
            {
                _idNamePair = new Dictionary<string, string>();
                comboBox.Items.Clear();
                comboBox.Items.Add("нет");
                comboBox.SelectedIndex = 0;
                var devices = JsonConvert.DeserializeObject<List<Device>>(client.Get(GetCompableQuery));
                comboBox.Items.AddRange(devices.Select(_ => _.Name).ToArray());
                foreach (var device in devices)
                    _idNamePair.Add(device.Id.ToString(), device.Name);

            };
            comboBox.SelectedIndexChanged += delegate
            {
                string name = comboBox.SelectedItem.ToString();
                Costlabel.Text = Costlabel.Text.Remove(Costlabel.Text.IndexOf(": "));
                if (name != "нет")
                {
                    var id = _idNamePair.First(_ => _.Value == name).Key;
                    client.Post(AddToAssemblyQuery, JsonConvert.SerializeObject(new IdPair() { DeviceId = id,AssemblyId=_assemblyId.ToString()}));
                    var device = JsonConvert.DeserializeObject<Device>(client.Get(GetByIdQuery+$"{id}"));
                    Costlabel.Text = Costlabel.Text + ": " + device.Cost;
                    
                    //string aboba = device.Img.Remove(device.Img.Length - 5);
                    //string aboba = device.Img;
                    //string filename = DownloadPhoto(aboba,device.Type);
                    //_pictureBox.Width = 500;
                    //_pictureBox.Height = 500;
                    //var a = Image.FromFile(filename);
                    //var bmp=new Bitmap(Image.FromFile(filename));
                    //File.Delete(filename);
                }
                else
                {
                    Costlabel.Text = Costlabel.Text + ": ";
                    if (types.FirstOrDefault(_ => _ == _partName) == null)
                        client.Post(AddToAssemblyQuery, JsonConvert.SerializeObject(new IdPair() { DeviceId = Guid.Empty.ToString(), AssemblyId = _assemblyId.ToString() }));
                }
                int cost = 0;
                for (int i = 1; i < Alllabels.Count; i++)
                    if (Alllabels[i].Text.Substring(Alllabels[i].Text.IndexOf(": ") + 2) != "")
                    {
                        string a = Alllabels[i].Text.Substring(Alllabels[i].Text.IndexOf(": ") + 2);
                        cost = cost + Convert.ToInt32(Alllabels[i].Text.Substring(Alllabels[i].Text.IndexOf(": ") + 2));
                    }
                Alllabels[0].Text = Alllabels[0].Text.Remove(Alllabels[0].Text.IndexOf(":")+1);
                Alllabels[0].Text = Alllabels[0].Text + ' '+ cost.ToString();
            };
        }


    }
}
