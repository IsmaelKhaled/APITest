using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace API_Testing
{
    public partial class CurrentMatch : Form
    {

        List<long> summonerIds1 = new List<long>();
        List<string> summonerNames1 = new List<string>();
        List<string> champIcon1 = new List<string>();
        List<string> summonerRank1 = new List<string>();

        List<long> summonerIds2 = new List<long>();
        List<string> summonerNames2 = new List<string>();
        List<string> champIcon2 = new List<string>();
        List<string> summonerRank2 = new List<string>();

        public CurrentMatch(string summonerId)
        {
            InitializeComponent();
            //Fetch current game and parse JSON
            string currentGameURL = "https://" + Form1.region + ".api.riotgames.com/lol/spectator/v3/active-games/by-summoner/" + summonerId + "?api_key=" + Form1.apikey;
            CurrentGameInfo currentGame = Form1.deserJSON<CurrentGameInfo>(currentGameURL);
            if (currentGame == null) // If there is no current game/User is invalid.
            {
                Form currentForm = this.FindForm();
                currentForm.Hide();
               // MessageBox.Show("Summoner isn't currently in a match");
            }
            else // If current game exists
            {
                Form currentForm = this.FindForm();
                currentForm.Show();
                foreach (CurrentGameParticipant prtcpnt in currentGame.participants) //Handle each player in the game
                {
                    if (prtcpnt.teamId == 100) //Handle first team
                    {
                        summonerIds1.Add(prtcpnt.summonerId); 
                        summonerNames1.Add(prtcpnt.summonerName);
                        ChampionDto champ = Form1.champions.data[prtcpnt.championId.ToString()];
                        string champname = champ.key;
                        if (System.IO.File.Exists(@"C:\Users\Ismael\Documents\Visual Studio 2013\Projects\API_Testing\API_Testing\champicons\" + champname + ".png"))
                        {
                            string champIcon = "C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\champicons\\" + champname+ ".png";
                            champIcon1.Add(champIcon);
                        }
                        else
                        {
                            using(WebClient wc = new WebClient())
                            {
                                wc.DownloadFile("http://ddragon.leagueoflegends.com/cdn/" + Form1.league_version + "/img/champion/" + champname + ".png", "C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\champicons\\" + champname+ ".png");
                                champIcon1.Add("C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\champicons\\" + champname+ ".png");
                            }
                        }
                            summonerRank1.Add(Form1.getRank(prtcpnt.summonerId));
                    }
                    else //Handle second team
                    {
                        summonerIds2.Add(prtcpnt.summonerId);
                        summonerNames2.Add(prtcpnt.summonerName);
                        ChampionDto champ = Form1.champions.data[prtcpnt.championId.ToString()];
                        string champname = champ.key;
                        if (System.IO.File.Exists(@"C:\Users\Ismael\Documents\Visual Studio 2013\Projects\API_Testing\API_Testing\champicons\" + champname + ".png"))
                        {
                            string champIcon = "C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\champicons\\" + champname+ ".png";
                            champIcon2.Add(champIcon);
                        }
                        else
                        {
                            using(WebClient wc = new WebClient())
                            {
                                wc.DownloadFile("http://ddragon.leagueoflegends.com/cdn/" + Form1.league_version + "/img/champion/" + champname + ".png", "C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\champicons\\" + champname+ ".png");
                                champIcon2.Add("C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\champicons\\" + champname+ ".png");
                            }
                        }
                        summonerRank2.Add(Form1.getRank(prtcpnt.summonerId));
                    }
                }
                tm1smr1.Text = summonerNames1[0];
                tm1smr2.Text = summonerNames1[1];
                tm1smr3.Text = summonerNames1[2];
                tm1smr4.Text = summonerNames1[3];
                tm1smr5.Text = summonerNames1[4];
                
                tm1smr1Rnk.Text = summonerRank1[0];
                tm1smr2Rnk.Text = summonerRank1[1];
                tm1smr3Rnk.Text = summonerRank1[2];
                tm1smr4Rnk.Text = summonerRank1[3];
                tm1smr5Rnk.Text = summonerRank1[4];

                tm1smr1ico.Load(champIcon1[0]);
                tm1smr2ico.Load(champIcon1[1]);
                tm1smr3ico.Load(champIcon1[2]);
                tm1smr4ico.Load(champIcon1[3]);
                tm1smr5ico.Load(champIcon1[4]);

                tm2smr1.Text = summonerNames2[0];
                tm2smr2.Text = summonerNames2[1];
                tm2smr3.Text = summonerNames2[2];
                tm2smr4.Text = summonerNames2[3];
                tm2smr5.Text = summonerNames2[4];

                tm2smr1Rnk.Text = summonerRank2[0];
                tm2smr2Rnk.Text = summonerRank2[1];
                tm2smr3Rnk.Text = summonerRank2[2];
                tm2smr4Rnk.Text = summonerRank2[3];
                tm2smr5Rnk.Text = summonerRank2[4];

                tm2smr1ico.Load(champIcon2[0]);
                tm2smr2ico.Load(champIcon2[1]);
                tm2smr3ico.Load(champIcon2[2]);
                tm2smr4ico.Load(champIcon2[3]);
                tm2smr5ico.Load(champIcon2[4]);

                //Show form after data is set
            }

        }
    }
}
