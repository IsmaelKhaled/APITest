using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing
{
    public class SummonerDTO
    {
        public int profileIconid { get; set; }
        public string name {get; set;}
        public long summonerLevel {get; set;}
        public long revisionDate{get; set;}
        public long id {get; set;}
        public long accountid{get; set;}
    }
    public class ChampionDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string key { get; set; }
    }
    public class ChampionListDto
    {
        public SortedDictionary<string, ChampionDto> data { get; set; }
    }
}
