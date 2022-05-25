using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vpkp.ViewModels.StaticTableCreateRowViewModels
{
    public class MatchStatisticViewModel : ViewModelBase
    {
        public MatchStatisticViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            MatchStatistic = new vpkp.Models.Database.MatchStatistic();
        }
        public vpkp.Models.Database.MatchStatistic MatchStatistic { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
