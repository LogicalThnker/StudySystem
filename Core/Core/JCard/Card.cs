using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudySystem.Core.JCard.Card;

namespace StudySystem.Core.JCard
{
    public class Card
    {

        public string Front {  get; set; }
        public string Reading { get; set; }
        public string Pronunciation { get; set; }
        public string Answer { get; set; }
        public CardResult Difficulty { get; set; }

        [JsonIgnore]
        public CardResult? LastResult { get; set; }

        public enum CardResult
        {
            Hard = 0,
            Normal = 1,
            Easy = 2
        }
    }
}
