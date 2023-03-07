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
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();

            lblFullName.Text = Resource1.FullName;
            buttonAdd.Text = Resource1.Add;
            buttonFajlbaIras.Text = Resource1.WriteInToFile;


            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            users.Add(new User { FullName = txtbFull.Text});
        }

        private void buttonFajlbaIras_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                using (StreamWriter writeText = new StreamWriter($"{fileName}"))
                {
                    foreach (var item in users)
                    {
                        writeText.WriteLine($"{item.ID} -- {item.FullName}");
                    }
                }

            }
        }
    }
}
