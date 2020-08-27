using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamanimation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace buziTrade.Pages.Walkthrough
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomeView : IAnimatedView
    {
        public WelcomeView()
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

            //if (Resources["PancakeAnimation"] is StoryBoard pananimate)
            //{
            //    pananimate.Begin();
            //}
        }
    }
}