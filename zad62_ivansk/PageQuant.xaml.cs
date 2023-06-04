using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace zad62_ivansk
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageQuant : ContentPage
    {
        public event EventHandler<int> QuantitySelected;
        private int selectedQuantity { get; set; }
        private Movie movie;
        public Movie SelectedMovie { get; set; }

        public PageQuant(Movie selectedMovie)
        {
            InitializeComponent();
            this.SelectedMovie = selectedMovie;
            movie = selectedMovie;

            var titleLabel = new Label
            {
                Text = "Выбор количества билетов",
                Style = (Style)Application.Current.Resources["TitleLabelStyle"]
            };
            var movieImage = new Image
            {
                Source = selectedMovie.ImagePath,
                Aspect = Aspect.AspectFit,
                HeightRequest = 400
            };
            var movieLabel = new Label
            {
                Text = $"Фильм: {movie.Title}\n\n{movie.Summary}",
                Style = (Style)Application.Current.Resources["MovieLabelStyle"]
            };

            var quantityEntry = new Entry
            {
                Placeholder = "Введите количество билетов",
                Keyboard = Keyboard.Numeric,
                Style = (Style)Application.Current.Resources["EntryStyle"]
            };

            var selectButton = new Button
            {
                Text = "Выбрать",
                HorizontalOptions = LayoutOptions.Center,
                Style = (Style)Application.Current.Resources["ButtonStyle"]
            };

            selectButton.Clicked += (sender, e) =>
            {
                if (int.TryParse(quantityEntry.Text, out int quantity))
                {
                    if (quantity <= movie.Capacity)
                    {
                        selectedQuantity = quantity;
                        QuantitySelected?.Invoke(this, quantity);
                        Navigation.PopAsync();
                    }
                    else
                    {
                        DisplayAlert("Ошибка", "Количество выбранных билетов превышает вместимость", "OK");
                    }
                }
                else
                {
                    DisplayAlert("Ошибка", "Некорректное количество билетов", "OK");
                }
            };

            Content = new StackLayout
            {
                Children =
                {
                    titleLabel,
                    movieLabel,
                    movieImage,
                    quantityEntry,
                    selectButton
                },
                BackgroundColor = Color.White
            };
        }
    }
}
