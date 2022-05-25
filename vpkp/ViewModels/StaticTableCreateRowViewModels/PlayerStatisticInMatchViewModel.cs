using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vpkp.ViewModels.StaticTableCreateRowViewModels
{
    public class PlayerStatisticInMatchViewModel : ViewModelBase
    {
        public PlayerStatisticInMatchViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            PlayerStatisticInMatch = new vpkp.Models.Database.PlayerStatisticInMatch();
        }
        public vpkp.Models.Database.PlayerStatisticInMatch PlayerStatisticInMatch { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
