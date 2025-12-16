using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__FF
{
    public static class VoteRepository
    {
        public static List<Vote> Votes = new List<Vote>();
    }
    public class Vote
    {
        public string FullName { get; set; } = "";
        public string Candidate { get; set; } = "";
        public DateTime VoteDate { get; set; } = DateTime.Now;
        public VoteStatus Status { get; set; }
    }
    public enum VoteStatus
    {
        Qebul_Edildi,
        Natamam,
        Legv_Edildi
    }

}
