using Acr.UserDialogs;
using System.Windows.Controls;

namespace Arci.UserDialogs
{
    /// <summary>
    /// Interaction logic for XAML
    /// </summary>
    public partial class ActionSheetControl : ContentControl
    {
        public ActionSheetControl()
        {
            InitializeComponent();
            this.List.SelectionChanged += (s, e) => { (this.List.SelectedItem as ActionSheetOption)?.Action?.Invoke(); };
        }
    }
}
