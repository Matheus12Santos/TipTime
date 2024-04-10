namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Percentage15Button_Clicked(object sender, EventArgs e)
        {
            TipPercentageSlider.Value = 15;
        }

        private void Percentage30Button_Clicked(object sender, EventArgs e)
        {
            TipPercentageSlider.Value = 30;
        }

        private void RoundDownButton_Clicked(object sender, EventArgs e)
        {
            //Arredondar o número para o inteiro menor ao valor.
            //Pegar o valor da refeição
            //Pegar a porcentagem que o usuário selecionou 
            //Calcular o valor da gorjeta
            //Arredondar
            //Calcular o total
            //Exibir 

            double valorDaRefeição = Convert.ToDouble(ValueEntry.Text);
            double porcentagemDaGorjeta = TipPercentageSlider.Value / 100;
            double valorDaGorjeta = valorDaRefeição * porcentagemDaGorjeta;
            valorDaGorjeta = Math.Floor(valorDaGorjeta);
            double totalRefeição = valorDaGorjeta + valorDaRefeição;

            TotalLabel.Text = totalRefeição.ToString();
            TipLabel.Text = valorDaGorjeta.ToString();

        }

        private void RoundUpButton_Clicked(object sender, EventArgs e)
        {
            double valorDaRefeição = Convert.ToDouble(ValueEntry.Text);
            double porcentagemDaGorjeta = TipPercentageSlider.Value / 100;
            double valorDaGorjeta = valorDaRefeição * porcentagemDaGorjeta;
            valorDaGorjeta = Math.Ceiling(valorDaGorjeta);
            double totalRefeição = valorDaGorjeta + valorDaRefeição;

            TotalLabel.Text = totalRefeição.ToString();
            TipLabel.Text = valorDaGorjeta.ToString();
        }

        private void OnTipPercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double valorDoSlider = TipPercentageSlider.Value;
            TipPorcentagemLabel.Text = valorDoSlider.ToString();
        }
    }

}
