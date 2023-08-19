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
		};

    }
	void CalculateTip(bool roundUp, bool roundDown)
	{
		double t;
		if (double.TryParse(billInut.Text, out t)&& t > o)
		{
			double pct = Math.Round(tipPercentSlider.Value);
			double tip = Math.Round(t * (pct / 100.0), 2);

			double final = t + tip;

			if (roundUp)
			{
				final = Math.Ceiling(final);
				tip = final - t;
			}

			tipOutput.Text = tip.ToString(tip);
			totalOutput.Text = final.ToString(final);
		}

	}
}

