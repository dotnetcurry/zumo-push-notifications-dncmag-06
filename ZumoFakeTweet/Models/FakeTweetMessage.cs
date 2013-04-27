using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZumoFakeTweet.Models
{
    class FakeTweetMessage
    {
        public int Id { get; set; }

        [DataMember(Name = "myId")]
        public string MyId { get; set; }

        [DataMember(Name = "fakeTweetText")]
        public string FakeTweetText { get; set; }

        [DataMember(Name = "toId")]
        public string ToId { get; set; }


    }
}
