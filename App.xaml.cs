
using MauiAppHotel.Models;

namespace MauiAppHotel
{
   
    
    
    public partial class App : Application
    {

        public List<Local> lista_local = new List<Local>
        { 
         new Local()
         {
          Paises = "Estados Unidos",
          Cidade = "Nova York"
         },

         new Local()
         {
          Paises = "Espanha",
          Cidade = "Madrid"
         },

         new Local()
         {
          Paises = "França",
          Cidade = "Paris"
         },

         new Local()
         {
          Paises = "Italia",
          Cidade = "Roma"
         },


         new Local()
         {
          Paises = "Inglaterra",
          Cidade = "Londres"
         }







        };
        
        
        
        
       
        
          
        


        public List<Quartos> lista_quartos = new List<Quartos>
        {
            new Quartos()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },

        new Quartos()
            {
                Descricao = "Suíte Super",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },
       
            new Quartos()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 25
            },
            new Quartos()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca = 12.5
            },
        };

        public App()
        {
            InitializeComponent();

            // Definindo a página principal com uma NavigationPage
            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 600;
            return window;
        }
    }
}