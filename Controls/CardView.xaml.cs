using System.Windows;
using System.Windows.Controls;
using StudySystem.Core.JCard;

namespace StudySystem.Controls
{
    public partial class CardView : UserControl
    {
        public CardView()
        {
            InitializeComponent();
        }

        public void SetCard(Card card)
        {
            DataContext = card;
        }

        public void SetAnswerVisible(bool visible)
        {
            CardAnswerText.Visibility = visible
                ? Visibility.Visible
                : Visibility.Hidden;
        }
    }
}
