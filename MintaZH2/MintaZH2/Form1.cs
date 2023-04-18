using MintaZH2.Abstractions;
using MintaZH2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MintaZH2
{
    public partial class Form1 : Form
    {
        private List<Product> _products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            ProcessXml();
            DisplayProducts();
        }

        public string LoadXml(string filename)
        {
            using (StreamReader sr = new StreamReader(filename, Encoding.Default))
            {
                //var output = sr.ReadLine();
                //while (!sr.EndOfStream)
                //{
                //    output += "\n" + sr.ReadLine();
                //}
                //return output;

                //List<string> outputList = new List<string>();
                //while (!sr.EndOfStream)
                //{
                //    outputList.Add(sr.ReadLine());
                //}
                //string.Join("\n", outputList);

                return sr.ReadToEnd();
            }
        }
        public void ProcessXml()
        {
            var xmlText = LoadXml("Files/Menu.xml");

            var xml = new XmlDocument();
            xml.LoadXml(xmlText);

            foreach (XmlElement item in xml.DocumentElement)
            {
                var name =  item.SelectSingleNode("name").InnerText;
                var description = item.SelectSingleNode("description").InnerText;
                var calories = item.SelectSingleNode("calories").InnerText;
                var type = item.SelectSingleNode("type").InnerText;

                if (type == "food")
                {
                    var food = new Food()
                    {
                        Title = name,
                        Description = description,
                        Calories = int.Parse(calories)
                    };
                    _products.Add(food);
                }
                else
                {
                    var drink = new Drink()
                    {
                        Title = name,
                        Calories = int.Parse(calories)
                    };
                    _products.Add(drink);
                }

            }
        }

        private void DisplayProducts()
        {
            var orderedProduct = _products.OrderBy(p => p.Title);

            int top = 10;
            foreach (var product in orderedProduct)
            {
                product.Top = top;
                this.Controls.Add(product);
                top += 50;
            }
        }
    }
}
