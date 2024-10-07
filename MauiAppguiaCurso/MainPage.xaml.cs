namespace MauiAppguiaCurso
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void b1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.NewPage1());
        }

        private void b2_Clicked(object sender, EventArgs e)
        {

        }

        private void b3_Clicked(object sender, EventArgs e)
        {

        }
    }

}
