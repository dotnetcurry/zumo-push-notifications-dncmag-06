using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZumoFakeTweet.Models
{
    public class ChannelSub
    {
        public int Id { get; set; }

        [DataMember(Name = "channel")]
        public string Channel { get; set; }

        [DataMember(Name = "myId")]
        public string MyId { get; set; }

        [DataMember(Name = "acceptBroadcast")]
        public bool AcceptBroadcast { get; set; }
    }
}
