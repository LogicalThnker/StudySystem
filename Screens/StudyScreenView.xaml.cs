using StudySystem.Controls;
using System.Windows.Controls;

namespace StudySystem.Screens
{
    public partial class StudyScreenView : UserControl
    {
        public StudyScreenView()
        {
            InitializeComponent();
        }

        public Button ImportDeckButtonControl => ImportDeckButton;
        public Button StudyButtonControl => StudyButton;
        public Button BackButtonControl => BackButton;
        public ComboBox DeckSelectionComboBoxControl => DeckSelection;
    }
}
