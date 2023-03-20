using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Pablo_Palacios_Unit3_IT481
{
    public partial class Form1 : Form
    {
        Controller database;
        public Form1()
        {
            //Initialize and create event handlers
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);

            /**
             // The Password character is an asterisk.
             textBox2.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox2.MaxLength = 14;
            **/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database = new Controller("Server = LAPTOP-MOQ8RUQ4\\SQLEXPRESS; " +
                                               "Trusted_Connection=true;" +
                                               "Database=northwind;" +
                                               "User Instance=false;" +
                                               "Connection timeout=30");

            MessageBox.Show("Connection information sent");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Get the count
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer count");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Get the names
            string names = database.getCompanyNames();
            MessageBox.Show(names, "Company names");

        }
        
       
    }
}