namespace TipoCalculetor;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		//Nese contexto, o +=
		billInput.TestChanged += (s, e) => CalculateTip(false, false);
		roundDown.Clicked += (s, e) => CalculateTip(false, true);
        roundUp.Clicked += (s, e) => CalculateTip(true, false);

		tipPercentSlider.ValueChanged += (s, e) =>
		{
			double pct = Math.Round(e.NewValue);
			tipPercent.Text = pct + "%";
            CalculateTip(false, false);
        }

    }

}

