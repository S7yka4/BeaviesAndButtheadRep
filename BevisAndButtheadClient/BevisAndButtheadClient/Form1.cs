using BevisAndButtheadClient.Models;
using Constructor.Storage.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BevisAndButtheadClient
{
    public partial class Form1 : Form
    {
        Dictionary<string, Block> blocks;
        public Form1()
        {
            InitializeComponent();
            var requester = new Requester("http://http://BeavisAndButtheadBack.somee.com");
            blocks = new Dictionary<string, Block>();
            Dictionary<string,string> parts = new Dictionary<string,string>()
            {
                { "Case","case.jpg" },
                { "CPU","cpu.jpg" },
                { "CpuFan","cpufan.jpg" },
                {"Drive","hdd.jpg" },
                { "FAN","fan.jpg" },
                { "FSP","fsp.jpg" },
                { "GPU","gpu.jpg" },
                { "Motherboard","motherboard.jpg" },
                { "RAM","ram.jpg"}
            };
            var names = new List<string>() 
            {   
                /*"Итог: 0",
                "Оперативная память: ",
                "Материнская плата: ",
                "Видеокарта: ",
                "Блок питания: ",
                "Вентилятор: ",
                "Жесткий диск: ",
                "Кулер: ",
                "Процессор: ",
                "Корпус: ",*/
                "Корпус: ",
                "Процессор: ",
                "Кулер: ",
                "Жесткий диск: ",
                "Вентилятор: ",
                "Блок питания: ",
                "Видеокарта: ",
                "Материнская плата: ",
                "Оперативная память: ",
                "Итог: 0"
            };
            groupBox1.Text = "Цены";
            var parts2 = parts.Select(_ => _.Key).ToList();
            for (int i = 0; i < names.Count; i++)
            {
                if (i < 9)
                {
                    groupBox1.Controls[groupBox1.Controls.Count-1-i].Name = parts2[i];
                    groupBox1.Controls[groupBox1.Controls.Count - 1 - i].Text = names[i];
                }
                else
                {
                    groupBox1.Controls[groupBox1.Controls.Count - 1-i].Text = names[i];
                }
            }
            List<Label> labels = new List<Label>();
            for (int i = 0; i < names.Count; i++)
                labels.Add((Label)groupBox1.Controls[i]);
                var description = JsonConvert.DeserializeObject<List<Partdescription>>(File.ReadAllText(@"FAQ.json"));
            var assemblyId = JsonConvert.DeserializeObject<Assembly>(requester.Put("api/Assembly/MakeEmpty", "")).Id;
            foreach (var p in parts)
            {
                blocks.Add(p.Key, MakeBox(p.Key, p.Value, requester, assemblyId, description, labels, labels.FirstOrDefault(_ => _.Name == p.Key)));
            }
            SetBoxes();
        }




        private void SetBoxes()
        {
            var Containers = blocks.Select(_ => _.Value).ToList();
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < Containers.Count())
            {
                for (j = 0; ((j < this.Width / Containers[0].Width) && (j + i < Containers.Count())); j++)
                    if (Containers[i + j] != null)

                        if ((j == 0) && (i == 0))
                            Containers[i + j].Location = new Point(((this.Width % Containers[0].Width) / (Containers.Count + 1)), 30 + ((this.Width % Containers[0].Width) / (Containers.Count + 1)));
                        else
                            if (j == 0)
                            Containers[i + j].Location = new Point(((this.Width % Containers[0].Width) / (Containers.Count + 1)), Containers[i + j - 1].Location.Y + ((this.Width % Containers[i + j - 1].Width) / (Containers.Count + 1)) + Containers[i + j - 1].Height);
                        else
                            Containers[i + j].Location = new Point(Containers[i + j - 1].Location.X + Containers[i + j - 1].Width + ((this.Width % Containers[i + j - 1].Width) / (Containers.Count + 1)), Containers[i + j - 1].Location.Y);
                i = i + j;
                k++;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (blocks.Count() > 1)
                if (this.Width >= blocks.First().Value.Width)
                    SetBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Block MakeBox(string partName,string PictPath,Requester requester,Guid assemblyId,List<Partdescription> description, List<Label> labels,Label label)
        {
            GroupBox tmp = new GroupBox();
            tmp.Name = partName;
            tmp.Text = partName;
            tmp.Width = 615; 
            tmp.Height = 265;
            tmp.Location = new Point(0, 0);

            ComboBox cmbb = new ComboBox();
            cmbb.Name = partName+"Selecter";
            cmbb.Location = new Point(6,235);
            cmbb.Height = 21;
            cmbb.Width = 603;
            cmbb.Items.Add("нет");
            cmbb.SelectedItem = "нет";
            tmp.Controls.Add(cmbb);

            PictureBox pb = new PictureBox();
            pb.Name = "Pb";
            pb.Location = new Point(6, 19);
            pb.Width = 200;
            pb.Height = 200;
            string a = Path.GetFullPath(PictPath);
            pb.Image = new Bitmap(Path.GetFullPath(PictPath));
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            tmp.Controls.Add(pb);

            Label lbl = new Label();
            lbl.Text = description.FirstOrDefault(_ => _.partName == partName).Text;
            lbl.Width = 400;
            lbl.Height = 200;
            lbl.Location = new Point(212, 19);
            tmp.Controls.Add(lbl);

            Controls.Add(tmp);
            
            return new Block(tmp, lbl, cmbb, $"api/{partName}/",requester,assemblyId,pb,partName,label,labels);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Move(object sender, EventArgs e)
        {

        }
    }
}
