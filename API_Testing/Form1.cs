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
using Newtonsoft.Json;
using System.Net.Mail;


namespace API_Testing
{
    public partial class Form1 : Form
    {
        public volatile static string apikey = "RGAPI-3710baab-7446-431c-9231-891592a94d62";
        public static string league_version = "8.11.1";
        public static string region = "eun1";
        public static ChampionListDto champions;
        public Form1()
        {
            InitializeComponent();
            parseChamps();
        }
        public void mailUser(string email, string message)
        {
            
            MailMessage msg = new MailMessage("penguin.2010@hotmail.com", email, "API Testing Mail", message);
            SmtpClient client = new SmtpClient("smtp.live.com");
            client.Port = 587;
            string password = System.IO.File.ReadAllText(@"C:\Users\Ismael\Desktop\password.txt");
            client.Credentials = new System.Net.NetworkCredential("penguin.2010@hotmail.com",password);
            client.EnableSsl=true;
            client.Send(msg);
            MessageBox.Show("Message sent!");
        }
        public static bool parseChamps()
        {
            if(!System.IO.File.Exists(@"C:\Users\Ismael\Desktop\champs.txt"))
            {
                string champURL = "https://" + region + ".api.riotgames.com/lol/static-data/v3/champions?locale=en_US&dataById=true" + "&api_key=" + apikey;
                string champJSON = fetchJSON(champURL);
                System.IO.File.WriteAllText(@"C:\Users\Ismael\Desktop\champs.txt",champJSON);
                champions = parseJSON<ChampionListDto>(champJSON);
                return false;
            }
            else
            {
                string champJSON = System.IO.File.ReadAllText(@"C:\Users\Ismael\Desktop\champs.txt");
                champions = parseJSON<ChampionListDto>(champJSON);
                return true;
            }
        }
        public static string fetchJSON(string URL)
        {
            string json;
            using (WebClient wc = new WebClient())
            {
                try
                {
                    json = wc.DownloadString(URL);
                    return json;
                }
                catch (WebException we)
                {
                    MessageBox.Show(we.Message);
                }
            }
            return null;
        }
        public static T parseJSON<T>(string json)
        {
            T parsed = JsonConvert.DeserializeObject<T>(json);
            return parsed;
        }
        public static T deserJSON<T>(string URL)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    string json = wc.DownloadString(URL);
                    T parsed = JsonConvert.DeserializeObject<T>(json);
                    return parsed;
                }
                catch (WebException we)
                {
                    MessageBox.Show(we.Message);
                }
            }
            return default(T);
        }
        public static string replaceRank(string rank)
        {
            if (rank == "I")
                return "1";
            else if (rank == "II")
                return "2";
            else if (rank == "III")
                return "3";
            else if (rank == "IV")
                return "4";
            else
                return "5";


        }

        public static List<LeaguePositionDTO> getRankInfo(long summonerID)
        {
            string rankURL = "https://"+region+".api.riotgames.com/lol/league/v3/positions/by-summoner/" + summonerID.ToString() + "?api_key=" + apikey;
            string rankJSON = fetchJSON(rankURL);

            if (rankJSON.Contains("tier"))
            {
                List<LeaguePositionDTO> user_rank = deserJSON<List<LeaguePositionDTO>>(rankURL);
                return user_rank;
            }
            return null;
        }
        public static string getSeriesInfo(List<LeaguePositionDTO> user_rank)
        {
            int queueindex = 0;
            if (user_rank != null)
            {

                if (user_rank.Count >= 2)
                {
                    while (user_rank[queueindex].queueType != "RANKED_SOLO_5x5") //Find the index for soloq
                    {
                        queueindex++;
                    }
                    MiniSeriesDTO series = user_rank[queueindex].miniSeries;
                    if (series != null)
                        //return series.wins.ToString() + "W/" + series.losses.ToString() + "L out of " + series.targ;
                        return series.progress;
                    else
                        return "No series";
                }
                else if (user_rank[queueindex].queueType == "RANKED_SOLO_5x5")
                {
                    MiniSeriesDTO series = user_rank[queueindex].miniSeries;
                    if (series != null)
                        return series.progress;
                    else
                        return "No series";
                }
            }
            return "Unranked";
        }
        public static string getSoloRank(List<LeaguePositionDTO> user_rank)
        {
            //Get league/rank info
            //string rankURL = "https://"+region+".api.riotgames.com/lol/league/v3/positions/by-summoner/" + summonerID.ToString() + "?api_key=" + apikey;
            //string rankJSON = fetchJSON(rankURL);
            int queueindex = 0;
            
            if (user_rank != null)
            {
                
                if (user_rank.Count >= 2)
                {
                    while (user_rank[queueindex].queueType != "RANKED_SOLO_5x5") //Find the index for soloq
                    {
                        queueindex++;
                    }
                    return user_rank[queueindex].tier[0] + replaceRank(user_rank[queueindex].rank) + " " + user_rank[queueindex].leaguePoints + "LP";
                }
                else if(user_rank[queueindex].queueType=="RANKED_SOLO_5x5")
                    {
                        return user_rank[queueindex].tier[0] + replaceRank(user_rank[queueindex].rank) + " " + user_rank[queueindex].leaguePoints + "LP";
                    }
                return "Unranked";

            }
            else
                return "Unranked";
        }

        public static SummonerDTO fetchSmnrInfo(string smnrName)
        {
            //Fetch SummonerDTO from API
            string URL = "https://" + region + ".api.riotgames.com/lol/summoner/v3/summoners/by-name/" + smnrName + "?api_key=" + apikey;
            SummonerDTO user = deserJSON<SummonerDTO>(URL);
            if (user != null)
                return user;
            return null;
        }
        private void fetchBtn_Click(object sender, EventArgs e)
        {
            string smnrName = smnrNameInput.Text; //Fetch name from input box
            SummonerDTO user =  fetchSmnrInfo(smnrName); //Fetch data from API
            //Start displaying fetched data
            if (user != null)
            {
                smnrNameLbl.Text = user.name;
                smnrIdBox.Text = user.id.ToString();
                accIdBox.Text = user.accountid.ToString();
                smnrLvlLbl.Text = user.summonerLevel.ToString();
                int icon = user.profileIconid;
                smnrIcon.Size = new Size(128, 128);
                string iconURL = "http://ddragon.leagueoflegends.com/cdn/" + league_version + "/img/profileicon/" + icon.ToString() + ".png";
                smnrIcon.Load(iconURL);
                List<LeaguePositionDTO> rankInfo = getRankInfo(user.id);
                smnrRankLbl.Text = getSoloRank(rankInfo);
                seriesInfoLbl.Text = getSeriesInfo(rankInfo);
               }   
        }

        private void smnrNameInput_KeyDown(object sender, KeyEventArgs e) // Click Fetch on Enter press
        {
            if (e.KeyCode == Keys.Enter)
                fetchBtn_Click(sender, e);
        }

        private void smnrIdBox_MouseDown(object sender, MouseEventArgs e) // Copy summoner ID on click
        {
            Clipboard.SetText(smnrIdBox.Text);
            MessageBox.Show("Summoner ID copied!");
        }

        private void rgnBox_SelectedIndexChanged(object sender, EventArgs e) // Select Region
        {
            if (rgnBox.Text == "EUNE")
                region = "eun1";
            else if (rgnBox.Text == "EUW")
                region = "euw1";
            else if (rgnBox.Text == "NA")
                region = "na1";
        }

        private void accIdBox_MouseDown(object sender, MouseEventArgs e) // Copy account ID on click
        {
            Clipboard.SetText(accIdBox.Text);
            MessageBox.Show("Account ID copied!");
        }

        private void quitBtn_Click(object sender, EventArgs e) // Quit application
        {
            Application.Exit();
        }

        public void crntMtchBtn_Click(object sender, EventArgs e) //Create current match form on button click
        {
            Form currentMatch = new CurrentMatch(smnrIdBox.Text); //Create current match form, form is shown in the form initalization
        }


    }
}
