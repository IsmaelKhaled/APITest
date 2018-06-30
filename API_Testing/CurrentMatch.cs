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
        List<string> perkStyles1 = new List<string>();
        List<string> perkSStyles1 = new List<string>();
        List<List<long>> perks1 = new List<List<long>>();

        List<long> summonerIds2 = new List<long>();
        List<string> summonerNames2 = new List<string>();
        List<string> champIcon2 = new List<string>();
        List<string> summonerRank2 = new List<string>();
        List<string> perkStyles2 = new List<string>();
        List<string> perkSStyles2 = new List<string>();
        List<List<long>> perks2 = new List<List<long>>();

        public CurrentMatch(string summonerId) //For your use, you should edit all directory pathes to point to the correct folders, most image files are kept in the images folder in the directory
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
                team1.Hide();
                team2.Hide();
                loadingLbl.Show();
                foreach (CurrentGameParticipant prtcpnt in currentGame.participants) //Handle each player in the game
                {
                    if (prtcpnt.teamId == 100) //Handle first team
                    {
                        summonerIds1.Add(prtcpnt.summonerId);
                        summonerNames1.Add(prtcpnt.summonerName);
                        ChampionDto champ = Form1.champions.data[prtcpnt.championId.ToString()];
                        string champname = champ.key;
                        if (System.IO.File.Exists(@"C:\Users\Ismael\Documents\Visual Studio 2013\Projects\API_Testing\API_Testing\images\champicons\" + champname + ".png"))
                        {
                            string champIcon = "C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\images\\champicons\\" + champname + ".png";
                            champIcon1.Add(champIcon);
                        }
                        else
                        {
                            using (WebClient wc = new WebClient())
                            {
                                wc.DownloadFile("http://ddragon.leagueoflegends.com/cdn/" + Form1.league_version + "/img/champion/" + champname + ".png", "C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\champicons\\" + champname + ".png");
                                champIcon1.Add("C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\champicons\\" + champname + ".png");
                            }
                        }
                        perkStyles1.Add(@"C:\Users\Ismael\Desktop\perkStyle\" + prtcpnt.perks.perkStyle.ToString() + ".png");
                        perkSStyles1.Add(@"C:\Users\Ismael\Desktop\perkStyle\" + prtcpnt.perks.perkSubStyle.ToString() + ".png");
                        perks1.Add(prtcpnt.perks.perkIds);

                        List<LeaguePositionDTO> rankInfo = Form1.getRankInfo(prtcpnt.summonerId);
                        summonerRank1.Add(Form1.getSoloRank(rankInfo));
                    }
                    else //Handle second team
                    {
                        summonerIds2.Add(prtcpnt.summonerId);
                        summonerNames2.Add(prtcpnt.summonerName);
                        ChampionDto champ = Form1.champions.data[prtcpnt.championId.ToString()];
                        string champname = champ.key;
                        if (System.IO.File.Exists(@"C:\Users\Ismael\Documents\Visual Studio 2013\Projects\API_Testing\API_Testing\images\champicons\" + champname + ".png"))
                        {
                            string champIcon = "C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\images\\champicons\\" + champname + ".png";
                            champIcon2.Add(champIcon);
                        }
                        else
                        {
                            using (WebClient wc = new WebClient())
                            {
                                wc.DownloadFile("http://ddragon.leagueoflegends.com/cdn/" + Form1.league_version + "/img/champion/" + champname + ".png", "C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\images\\champicons\\" + champname + ".png");
                                champIcon2.Add("C:\\Users\\Ismael\\Documents\\Visual Studio 2013\\Projects\\API_Testing\\API_Testing\\images\\champicons\\" + champname + ".png");
                            }
                        }
                        perkStyles2.Add(@"C:\Users\Ismael\Documents\Visual Studio 2013\Projects\API_Testing\API_Testing\images\perkStyle\" + prtcpnt.perks.perkStyle.ToString() + ".png");
                        perkSStyles2.Add(@"C:\Users\Ismael\Documents\Visual Studio 2013\Projects\API_Testing\API_Testing\images\perkStyle\" + prtcpnt.perks.perkSubStyle.ToString() + ".png");
                        perks2.Add(prtcpnt.perks.perkIds);

                        List<LeaguePositionDTO> rankInfo = Form1.getRankInfo(prtcpnt.summonerId);
                        summonerRank2.Add(Form1.getSoloRank(rankInfo));
                    }
                }

                

                setTeam(1);
                setTeam(2);

                setPerks(1);
                setPerks(2);

                loadingLbl.Hide();
                team1.Show();
                team2.Show();


                //Show form after data is set
            }


        }
        public void setTeam(int teamId)//Set team members' names/icons/ranks
        {
            if (teamId == 1)
            {
                tm1smr1ico.Load(champIcon1[0]);
                tm1smr2ico.Load(champIcon1[1]);
                tm1smr3ico.Load(champIcon1[2]);
                tm1smr4ico.Load(champIcon1[3]);
                tm1smr5ico.Load(champIcon1[4]);

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
            }
            else
            {
                tm2smr1ico.Load(champIcon2[0]);
                tm2smr2ico.Load(champIcon2[1]);
                tm2smr3ico.Load(champIcon2[2]);
                tm2smr4ico.Load(champIcon2[3]);
                tm2smr5ico.Load(champIcon2[4]);

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

            }
        }

        public void setPerks(int teamId)
        {
            if (teamId == 1)
            {
                for (int i = 1; i <= 5; i++) // set picture boxes for runes
                {
                    List<string> perkLocs = new List<string>();
                    foreach (long perk in perks1[i-1])
                    {
                        perkLocs.Add(@"C:\Users\Ismael\Documents\Visual Studio 2013\Projects\API_Testing\API_Testing\images\perk\" + perk + ".png");
                    }
                    for (int j = 1; j <= 6; j++)
                    {
                        PictureBox perk = this.Controls.Find("perk" + i.ToString() + "_" + j.ToString(), true).FirstOrDefault() as PictureBox;
                        perk.Load(perkLocs[j - 1]);
                    }
                }

                perkStyle1.Load(perkStyles1[0]);
                perkSStyle1.Load(perkSStyles1[0]);

                perkStyle2.Load(perkStyles1[1]);
                perkSStyle2.Load(perkSStyles1[1]);

                perkStyle3.Load(perkStyles1[2]);
                perkSStyle3.Load(perkSStyles1[2]);

                perkStyle4.Load(perkStyles1[3]);
                perkSStyle4.Load(perkSStyles1[3]);

                perkStyle5.Load(perkStyles1[4]);
                perkSStyle5.Load(perkSStyles1[4]);
               
            }
            else
            {
                for (int i = 6; i <= 10; i++) // set picture boxes for runes
                {
                    List<string> perkLocs = new List<string>();
                    foreach (long perk in perks2[i - 6])
                    {
                        perkLocs.Add(@"C:\Users\Ismael\Documents\Visual Studio 2013\Projects\API_Testing\API_Testing\images\perk\" + perk + ".png");
                    }
                    for (int j = 1; j <= 6; j++)
                    {
                        PictureBox perk = this.Controls.Find("perk" + i.ToString() + "_" + j.ToString(), true).FirstOrDefault() as PictureBox;
                        perk.Load(perkLocs[j - 1]);
                    }
                }

                perkStyle6.Load(perkStyles2[0]);
                perkSStyle6.Load(perkSStyles2[0]);

                perkStyle7.Load(perkStyles2[1]);
                perkSStyle7.Load(perkSStyles2[1]);

                perkStyle8.Load(perkStyles2[2]);
                perkSStyle8.Load(perkSStyles2[2]);

                perkStyle9.Load(perkStyles2[3]);
                perkSStyle9.Load(perkSStyles2[3]);

                perkStyle10.Load(perkStyles2[4]);
                perkSStyle10.Load(perkSStyles2[4]);
            }


        }


        private void perkStyle1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.perkStyle1, "Wassuh cuh");
        } 
        
    }
    }
