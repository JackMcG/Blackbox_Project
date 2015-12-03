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

            session.Execute("Insert into Car_Details_New (licence_plate, car_model, make_of_car, miles_per_gallon, owner, user_password) values ('K13DFC', 'Ford', 'Mondeo', '50', 'Keiran Banks', 'password1')");

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

        
    }
    }

