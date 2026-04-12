using StudySystem.Controls;
using System.Windows.Controls;

namespace StudySystem.Screens
{
    public partial class CardScreenView : UserControl
    {
        public CardScreenView()
        {
            InitializeComponent();
        }

        public Button HardButtonControl => HardButton;
        public Button NormalButtonControl => NormalButton;
        public Button EasyButtonControl => EasyButton;
        public Button ShowAnswerButtonControl => ShowAnswerButton;
        public Button NextCardButtonControl => NextCardButton;
        public Button StudyButtonControl => StudyButton;
        public CardView MainCardViewControl => MainCardView;
    }
}
