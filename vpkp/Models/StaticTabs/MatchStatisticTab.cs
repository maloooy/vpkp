using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vpkp.Models.Database;

namespace vpkp.Models.StaticTabs
{
    public class MatchStatisticTab : StaticTab
    {
        public MatchStatisticTab(string h = "", DbSet<MatchStatistic>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("MatchId");
            DataColumns.Add("ClubId");
            DataColumns.Add("PointsNumber");
        }

        new public DbSet<MatchStatistic>? DBS { get; set; }
    }
}
