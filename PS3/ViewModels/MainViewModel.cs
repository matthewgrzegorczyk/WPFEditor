using System.Collections.ObjectModel;
using System.Windows.Media;

namespace PS3.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<string> radioButtonHorizontal;
        public ObservableCollection<string> RadioButtonHorizontal { get { return radioButtonHorizontal; } }

        private ObservableCollection<string> radioButtonVertical;
        public ObservableCollection<string> RadioButtonVertical { get { return radioButtonVertical; } }

        private ObservableCollection<string> comboBoxColor;
        public ObservableCollection<string> ComboBoxColor { get { return comboBoxColor; } }

        public MainViewModel()
        {
            radioButtonHorizontal = new ObservableCollection<string>() { "Left", "Center", "Right", "Stretch" };
            radioButtonVertical = new ObservableCollection<string>() { "Top", "Center", "Bottom", "Stretch" };

            comboBoxColor = new ObservableCollection<string>() { "Red", "Green", "Blue", "Cyan", "Yellow", "Magenta" };
        }
    }
}
