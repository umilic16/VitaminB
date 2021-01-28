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
            LoadLikedBeers();
            LoadLikedPubs();
        }
        private void LoadLikedBeers()
        {
            //ucitaj lajkovana piva
            if (lbLikedBeers.Items.Count > 0)
                lbLikedBeers.Items.Clear();
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("username", currentUser.username);

            var query = new Neo4jClient.Cypher.CypherQuery("match (u:User)-[r:LIKED]->(b:Beer) where u.username = {username} return b",
                                                            queryDict, CypherResultMode.Set);

            List<Beer> likedBeer = ((IRawGraphClient)client).ExecuteGetCypherResults<Beer>(query).ToList();

            foreach (Beer b in likedBeer)
                lbLikedBeers.Items.Add(b.name);
        }
        private void LoadLikedPubs()
        {
            //ucitaj lajkovane pubove
            if (lbLikedPubs.Items.Count > 0)
                lbLikedPubs.Items.Clear();
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("username", currentUser.username);

            var query = new Neo4jClient.Cypher.CypherQuery("match (u:User)-[r:LIKED]->(p:Pub) where u.username = {username} return p",
                                                            queryDict, CypherResultMode.Set);

            List<Pub> likedPubs = ((IRawGraphClient)client).ExecuteGetCypherResults<Pub>(query).ToList();

            foreach (Pub b in likedPubs)
                lbLikedPubs.Items.Add(b.name);
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
                lbBeers.Items.Add(beer.name);
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
                lbPubs.Items.Add(pub.name);
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
            //dodaj vezu
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("pubName", lbPubs.SelectedItem.ToString());
            queryDict.Add("userName", currentUser.username);

            var query = new Neo4jClient.Cypher.CypherQuery("match (u:User),(p:Pub) where u.username = {userName} and p.name = {pubName} merge (u)-[r:LIKED]->(p)",
                                                            queryDict, CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query);
            //refresh listu
            LoadLikedPubs();
        }
        //lajkuj pivo selektovano u listboxu
        private void btnLikeBeer_Click(object sender, EventArgs e)
        {
            if (lbBeers.SelectedIndex == -1)
                return;
            //dodaj vezu
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("beerName", lbBeers.SelectedItem.ToString());
            queryDict.Add("userName", currentUser.username);

            var query = new Neo4jClient.Cypher.CypherQuery("match (u:User),(b:Beer) where u.username = {userName} and b.name = {beerName} merge (u)-[r:LIKED]->(b)",
                                                            queryDict, CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query);
            //refresh listu
            LoadLikedBeers();

        }
        //oceni pivo selektovano u listboxu ocenom iz numupdown
        private void btnRateBeer_Click(object sender, EventArgs e)
        {
            if (lbBeers.SelectedIndex == -1)
                return;
            //dodaj vezu
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("beerName", lbBeers.SelectedItem.ToString());
            queryDict.Add("userName", currentUser.username);
            queryDict.Add("stars", nUDBeer.Value);

            var query = new Neo4jClient.Cypher.CypherQuery("match (u:User),(b:Beer) where u.username={userName} and b.name={beerName} merge (u)-[r:RATED {stars: {stars}}]->(b)",
                                                            queryDict, CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query);

        }
        //oceni pub selektovano u listboxu ocenom iz numupdown
        private void btnRatePub_Click(object sender, EventArgs e)
        {
            if (lbPubs.SelectedIndex == -1)
                return;
            //dodaj vezu
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("pubName", lbPubs.SelectedItem.ToString());
            queryDict.Add("userName", currentUser.username);
            queryDict.Add("stars", nUDBeer.Value);

            var query = new Neo4jClient.Cypher.CypherQuery("match (u:User),(p:Pub) where u.username={userName} and p.name={pubName} merge (u)-[r:RATED {stars: {stars}}]->(p)",
                                                            queryDict, CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query);
        }
        //prikazi informacije o pivu selektovanom u listboxu
        private void lbBeers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbBeers.SelectedIndex == -1)
                return;
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("beerName", lbBeers.SelectedItem.ToString());
            queryDict.Add("userName", currentUser.username);
            //nadji kliknuto pivo
            var queryBeer = new Neo4jClient.Cypher.CypherQuery("match (n:Beer) where n.name = {beerName} return n",
                                                                queryDict, CypherResultMode.Set);
            Beer beer = ((IRawGraphClient)client).ExecuteGetCypherResults<Beer>(queryBeer).FirstOrDefault();
            //nadji pivaru koja ga proizvodi
            var queryBrewery = new Neo4jClient.Cypher.CypherQuery("match (br:Brewery)-[r:MAKES]->(be:Beer) where be.name = {beerName} return br",
                                                                queryDict, CypherResultMode.Set);
            Brewery brewery = ((IRawGraphClient)client).ExecuteGetCypherResults<Brewery>(queryBrewery).FirstOrDefault();
            //rating piva
            var queryRating = new Neo4jClient.Cypher.CypherQuery("match (u:User)-[r:RATED]->(b:Beer) where u.username = {userName} and b.name = {beerName} return r.stars",
                                                                queryDict, CypherResultMode.Set);
            int stars = ((IRawGraphClient)client).ExecuteGetCypherResults<int>(queryRating).FirstOrDefault();
            string info = "Beer: " + beer.name + " abv: " + beer.abv + "\nBrewery: " + brewery.name + " (address: " + brewery.address + ", phone: " + brewery.phone + ")\nYour rating: ";
            if (stars == 0)
                info += "Not rated";
            else
                info += stars.ToString() + " stars";
            info += "\n\nAvailable in:\n";
            //pubovi koji ga prodaju
            var queryPubs = new Neo4jClient.Cypher.CypherQuery("match (p:Pub)-[r:SELLS]->(b:Beer) where b.name = {beerName} return p",
                                                                queryDict, CypherResultMode.Set);
            List<Pub> pubs = ((IRawGraphClient)client).ExecuteGetCypherResults<Pub>(queryPubs).OrderBy(n => n.name).ToList();
            foreach (Pub pub in pubs)
                info += pub.name + "\n";
            MessageBox.Show(info);
        }
        //prikazi informacije o pubu selektovanom u listboxu
        private void lbPubs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbPubs.SelectedIndex == -1)
                return;
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("pubName", lbPubs.SelectedItem.ToString());
            queryDict.Add("userName", currentUser.username);
            //nadji kliknut pub
            var queryPub = new Neo4jClient.Cypher.CypherQuery("match (n:Pub) where n.name = {pubName} return n",
                                                                queryDict, CypherResultMode.Set);
            Pub pub = ((IRawGraphClient)client).ExecuteGetCypherResults<Pub>(queryPub).FirstOrDefault();
            //rating puba
            var queryRating = new Neo4jClient.Cypher.CypherQuery("match (u:User)-[r:RATED]->(p:Pub) where u.username = {userName} and p.name = {pubName} return r.stars",
                                                                queryDict, CypherResultMode.Set);
            int stars = ((IRawGraphClient)client).ExecuteGetCypherResults<int>(queryRating).FirstOrDefault();
            string info = "Pub: " + pub.name + " (address: " + pub.address + ", phone: " + pub.phone + ")\nYour rating: ";
            if (stars == 0)
                info += "Not rated";
            else
                info += stars.ToString() + " stars";
            info += "\n\nMenu:\n";
            var queryMenu = new Neo4jClient.Cypher.CypherQuery("match (p:Pub)-[r:SELLS]->(b:Beer) where p.name = {pubName} return b",
                                                                queryDict, CypherResultMode.Set);
            //ponuda puba
            List<Beer> beer = ((IRawGraphClient)client).ExecuteGetCypherResults<Beer>(queryMenu).OrderBy(n => n.name).ToList();
            foreach (Beer b in beer)
                info += b.name + "\n";
            MessageBox.Show(info);
        }
        //brisi selektovano pivo iz lajkova korisnika
        private void lbLikedBeers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbLikedBeers.SelectedIndex == -1)
                return;
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("userName", currentUser.username);
            queryDict.Add("beerName", lbLikedBeers.SelectedItem.ToString());
            //obrisi vezu
            var query = new Neo4jClient.Cypher.CypherQuery("match (u:User)-[r:LIKED]->(b:Beer) where u.username = {userName} and b.name = {beerName} delete r", 
                                                            queryDict, CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query);
            //refresh listu
            LoadLikedBeers();
        }
        //brise selektovan pub iz lajkova korisnika
        private void lbLikedPubs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbLikedPubs.SelectedIndex == -1)
                return;
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("userName", currentUser.username);
            queryDict.Add("pubName", lbLikedPubs.SelectedItem.ToString());
            //obrisi vezu
            var query = new Neo4jClient.Cypher.CypherQuery("match (u:User)-[r:LIKED]->(p:Pub) where u.username = {userName} and b.name = {pubName} delete r",
                                                            queryDict, CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query);
            //refresh listu
            LoadLikedPubs();
        }
    }
    }
}
