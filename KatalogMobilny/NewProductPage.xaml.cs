namespace KatalogMobilny;

public partial class NewProductPage : ContentPage
{
    public NewProductPage()
    {
        InitializeComponent();
    }
    private int licznik = 0;
    private int znaki = 0;
    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
        //licznik++;
        //EtykietaWyniku2.Text = $"Kliknięto {licznik} razy";
        if (double.TryParse(CenaEntry.Text, out double cena))
        {
            EtykietaWyniku2.Text = "Niepoprawna cena!";
            return;
        }

        if (double.TryParse(CenaEntry.Text, out double ilosc))
        {
            EtykietaWyniku2.Text = "Niepoprawna ilosc!";
            return;
        }
        if(cena <0 || ilosc < 0)
        {
            EtykietaWyniku2.Text = "Niepoprawna ilość lub cena";
            return;
        }
        double wartosc = cena * ilosc;
        string? nazwa = NazwaEntry.Text;
        if (string.IsNullOrWhiteSpace(nazwa))
        {
            EtykietaWyniku2.Text = "Niepoprawna nazwa!";
            return;
        }
        if (KategoriaPicker.SelectedItem == null)
        {
            EtykietaWyniku2.Text = "Nie wybrano kategorii!";
            return;
        }
        EtykietaWyniku2.Text = $"Produkt: {nazwa}, cena: {cena}, kategoria: {KategoriaPicker.SelectedItem}, wartosc: {wartosc}";
    }



    private void IleZnakow(object sender, EventArgs e)
    {
        string tekstNazwy = ZnakiNazwy.Text;
        int IloscZnakow = tekstNazwy.Length;
        ZnakiNazwy.Text = $"Nazwa ma {znaki} znaków";
    }
    private void KtoraKategoria(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int WybranyIndex = picker.SelectedIndex;
        WybranaKategoria.Text = $"Kategoria: {(string)picker.ItemsSource[WybranyIndex]}";
    }
    private void CzyDostepny(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            DostepnyLabel.Text = "Produkt dostępny";
        }
        else
        {
            DostepnyLabel.Text = "Produkt Niedostępny";
        } }
        private void Powrot_Clicked(object sender, EventArgs e)
    {
        licznik = 0;
        EtykietaWyniku2.Text = "";
        ZnakiNazwy.Text = "";
        WybranaKategoria.Text = "";
        EtykietaWyniku2.Text = "";
    }


}
