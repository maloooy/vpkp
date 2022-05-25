using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using vpkp.ViewModels;

namespace vpkp.Views
{
    public partial class SelectDBView : Window
    {
        public SelectDBView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }
        public SelectDBView(MainWindowViewModel? mainContext) : this()
        {
            this.DataContext = new SelectDBViewModel(mainContext);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}