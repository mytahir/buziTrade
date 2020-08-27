using Xamanimation;
using Xamarin.Forms.Xaml;

namespace buziTrade.Pages.Walkthrough
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartView : IAnimatedView
    {
        public ChartView()
        {
            InitializeComponent();
        }

		public void StartAnimation()
		{
			if (Resources["BackgroundColorAnimation"] is ColorAnimation backgroundColorAnimation)
			{
				backgroundColorAnimation.Begin();
			}

			if (Resources["InfoPanelAnimation"] is StoryBoard animation)
			{
				animation.Begin();
			}
		}

        private void BtnLog_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}