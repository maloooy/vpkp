using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using vpkp.ViewModels;

namespace vpkp.Views
{
    public partial class JoinDBView : Window
    {
        public JoinDBView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }
        public JoinDBView(MainWindowViewModel? mainContext) : this()
        {
            this.DataContext = new JoinDBViewModel(mainContext);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}