using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace VitaminB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private GraphClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "edukacija");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Close();
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            lbUsernameError.Visible = false;
            lbPasswordError.Visible = false;
            //provera da li su prazni text boxovi
            if (tbSignPass.TextLength == 0 || tbSignUser.TextLength == 0)
            {
                MessageBox.Show("Fields cant be empty");
                return;
            }
            //provera da li je ponovljena sifra ispravno
            if (tbSignPass.Text != tbSignRepPass.Text)
            {
                lbPasswordError.Visible = true;
                return;
            }
            //provera da li posotji vec uneti username u bazi
            //string username = tbSignUser.Text;
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("username", tbSignUser.Text);
            queryDict.Add("password", tbSignPass.Text);
            var query = new Neo4jClient.Cypher.CypherQuery("match (n:User {username: {username}}) return count(*)",
                                   queryDict, CypherResultMode.Set);

            int count = ((IRawGraphClient)client).ExecuteGetCypherResults<int>(query).Single();
            //string broj = "Ima ih " + count + ".";
            //tbLogPass.Text = broj;
            if(count == 0)
            {
                var create = new Neo4jClient.Cypher.CypherQuery("CREATE(n: User { username: {username}, password: {password}})",
                       queryDict, CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(create);
                MessageBox.Show("User created");
                tbSignPass.Text = "";
                tbSignRepPass.Text = "";
                tbSignUser.Text = "";
            }
            else
            {
                lbUsernameError.Visible = true;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lbLoginError.Visible = false;
            //provera da li su prazni text boxovi
            if (tbLogPass.TextLength == 0 || tbLogUser.TextLength == 0)
            {
                MessageBox.Show("Fields cant be empty");
                return;
            }
            //provera username pass
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("username", tbLogUser.Text);
            queryDict.Add("password", tbLogPass.Text);
            var query = new Neo4jClient.Cypher.CypherQuery("match (n:User {username: {username}, password: {password}}) return n",
                                   queryDict, CypherResultMode.Set);

            User currentUser = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).FirstOrDefault();
            //string broj = "Ima ih " + count + ".";
            //tbLogPass.Text = broj;
            if (currentUser!=null)
            {
                tbLogUser.Text = "";
                tbLogPass.Text = "";
                Form2 forma = new Form2();
                forma.client = client;
                forma.currentUser = currentUser;
                forma.ShowDialog();
            }
            else
                lbLoginError.Visible = true;
        }
    }
}
