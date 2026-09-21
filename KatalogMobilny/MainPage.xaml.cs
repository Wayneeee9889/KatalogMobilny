namespace KatalogMobilny
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void PokazButton(object sender, EventArgs e)
        {
            EtykietaWyniku.Text = "Processor wybrano!";
        }

        //private void OnCounterClicked(object? sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Kopnąłeś {count} raz";
        //    else
        //        CounterBtn.Text = $"Kopnąłeś {count} razy";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}
    }
}
