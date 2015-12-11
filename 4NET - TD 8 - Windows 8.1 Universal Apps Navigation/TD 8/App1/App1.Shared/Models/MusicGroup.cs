using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class MusicGroup
    {
        public int UniqueId { get; set; }
        public string Name { get; set; }
        public List<int> GroupMembers { get; set; }
        public List<Song> Songs { get; set; }

        public MusicGroup()
        {
            GroupMembers = new List<int>();
            Songs = new List<Song>();
        }
    }
}
