using eCashWalletApp.ViewModels;

namespace eCashWalletApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (this.AnimationIsRunning("TransitionAnimation"))
            return;

        var parentAnimation = new Animation
        {
            Finished = null,
            Step = null,
            Name = null,
            StartDelay = 0,
            Duration = 0,
            Easing = null!,
            Repeats = false
        };

        //Planets Animation
        parentAnimation.Add(0, 0.2, new Animation(v => ImgCashTabLogo.Opacity = v, 0, 1, Easing.CubicIn));

        //Commit the animation
        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null);
    }
    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

