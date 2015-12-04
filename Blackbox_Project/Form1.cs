using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra;

namespace Blackbox_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        

        Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
        ISession session = cluster.Connect("blackbox_project");

        textBox1.Text = session.Execute("select * from Car_Details_New where Licence_Plate='" + Logintxtbox.Text + "'");
            


        //Row result = session.Execute("select * from users where lastname='Jones'").First();
        //Console.WriteLine("{0} {1}", result["firstname"], result["city"]);

            Console.ReadLine();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logintxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

