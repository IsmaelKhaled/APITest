using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing
{
    class CurrentGameInfo
    {
        public long gameId { get; set; }
        public long gameStartTime { get; set; }
        public string platformId { get; set; }
        public string gameMode { get; set; }
        public long mapId { get; set; }
        public string gameType { get; set; }
        public long gameLength { get; set; }
        public long gameQueueConfigId { get; set; }
        public List<CurrentGameParticipant> participants { get; set; }
    }
    class CurrentGameParticipant
    {
        public long profileIconId{ get; set; }
        public long championId{ get; set; }
        public string summonerName{ get; set; }
        public bool bot{ get; set; }
        public Perks perks{ get; set; }
        public long spell1Id{ get; set; }
        public long spell2Id{ get; set; }
        public long teamId{ get; set; }
        public long summonerId{ get; set; }
    }
    class Perks
    {
        public long perkStyle{ get; set; }
        public List<long> perkIds{ get; set; }
        public long perkSubStyle{ get; set; }

    }
}
