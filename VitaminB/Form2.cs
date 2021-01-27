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
using Neo4jClient;
using Neo4jClient.Cypher;

namespace VitaminB
{
    public partial class Form2 : Form
    {
        public User currentUser;
        public GraphClient client;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbUser.Text = currentUser.username;
            ShowBeer("");
            ShowPubs("");
        }
        private void LoadLikedBeers()
        {
            //ucitaj lajkovana piva
        }
        private void LoadLikedPubs()
        {
            //ucitaj lajkovane pubove
        }
        private void ShowBeer(string name)
        {
            //prikazi piva, ako se prosledi string prikazuju se sva koja sadrze taj string ako ne onda sva piva
            //klik na button search poziva ovu funkciju sa parametrom iz textboxa za pretragu
            //poziva se i na on_load sa praznim stringom
            if (lbBeers.Items.Count > 0)
                lbBeers.Items.Clear();
            List<Beer> beerList;
            if (name.Length > 0)
            {
                string beerName = ".*" + name + ".*";
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("beerName", beerName);

                var query = new Neo4jClient.Cypher.CypherQuery("match (n:Beer) where n.name =~ {beerName} return n",
                                                                queryDict, CypherResultMode.Set);
                beerList = ((IRawGraphClient)client).ExecuteGetCypherResults<Beer>(query).OrderBy(a => a.name).ToList();
            }
            else
            {
                var query = new Neo4jClient.Cypher.CypherQuery("match (n:Beer) return n",
                                                                new Dictionary<string,object>() , CypherResultMode.Set);
                beerList = ((IRawGraphClient)client).ExecuteGetCypherResults<Beer>(query).OrderBy(a => a.name).ToList();
            }
            foreach(Beer beer in beerList)
            {
                lbBeers.Items.Add(beer.name);
            }
        }
        private void ShowPubs(string name)
        {
            //prikazi pubove, ako se prosledi string prikazuju se sva koja sadrze taj string ako ne onda sva piva
            //klik na button search poziva ovu funkciju sa parametrom iz textboxa za pretragu
            //poziva se i na on_load sa praznim stringom
            if (lbPubs.Items.Count > 0)
                lbPubs.Items.Clear();
            List<Pub> pubList;
            if (name.Length > 0)
            {
                string pubName = ".*" + name + ".*";
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("pubName", pubName);

                var query = new Neo4jClient.Cypher.CypherQuery("match (n:Pub) where n.name =~ {pubName} return n",
                                                                queryDict, CypherResultMode.Set);
                pubList = ((IRawGraphClient)client).ExecuteGetCypherResults<Pub>(query).OrderBy(a => a.name).ToList();
            }
            else
            {
                var query = new Neo4jClient.Cypher.CypherQuery("match (n:Pub) return n",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                pubList = ((IRawGraphClient)client).ExecuteGetCypherResults<Pub>(query).OrderBy(a => a.name).ToList();
            }
            foreach (Pub pub in pubList)
            {
                lbPubs.Items.Add(pub.name);
            }
        }

        private void btnSearchPub_Click(object sender, EventArgs e)
        {
            ShowPubs(tbSearchPubs.Text);
            tbSearchPubs.Text = "";
        }

        private void btnSearchBeer_Click(object sender, EventArgs e)
        {
            ShowBeer(tbSearchBeer.Text);
            tbSearchBeer.Text = "";
        }
        //lajkuj pub selektovan u listboxu
        private void btnLikePub_Click(object sender, EventArgs e)
        {
            if (lbPubs.SelectedIndex == -1)
                return;
        }
        //lajkuj pivo selektovano u listboxu
        private void btnLikeBeer_Click(object sender, EventArgs e)
        {
            if (lbBeers.SelectedIndex == -1)
                return;
        }
        //oceni pivo selektovano u listboxu ocenom iz numupdown
        private void btnRateBeer_Click(object sender, EventArgs e)
        {
            if (lbBeers.SelectedIndex == -1)
                return;
        }
        //oceni pub selektovano u listboxu ocenom iz numupdown
        private void btnRatePub_Click(object sender, EventArgs e)
        {
            if (lbPubs.SelectedIndex == -1)
                return;
        }
        //prikazi informacije o pivu selektovanom u listboxu
        private void lbBeers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbBeers.SelectedIndex == -1)
                return;
        }
        //prikazi informacije o pubu selektovanom u listboxu
        private void lbPubs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbPubs.SelectedIndex == -1)
                return;
        }
        //brisi selektovano pivo iz lajkova korisnika
        private void lbLikedBeers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbLikedBeers.SelectedIndex == -1)
                return;
        }
        //brise selektovan pub iz lajkova korisnika
        private void lbLikedPubs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbLikedPubs.SelectedIndex == -1)
                return;
        }
    }
}
