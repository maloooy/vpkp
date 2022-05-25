using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vpkp.Models.Database;

namespace vpkp.Models.StaticTabs
{
    public class ClubTab : StaticTab
    {
        public ClubTab(string h = "", DbSet<Club>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("ClubId");
            DataColumns.Add("PlayersAmount");
            DataColumns.Add("Division");
            DataColumns.Add("Titile");
            DataColumns.Add("CityId");
        }

        new public DbSet<Club>? DBS { get; set; }
    }
}
