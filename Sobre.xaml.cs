namespace MauiAppHotel.Views
{
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();

            // Definir dinamicamente a data de desenvolvimento
            var dataDesenvolvimento = DateTime.Now.ToString("dd/MM/yyyy");
            lblDataDesenvolvimento.Text = $"Data de Desenvolvimento: {dataDesenvolvimento}";
        }
    }
}