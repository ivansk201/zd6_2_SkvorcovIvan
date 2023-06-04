using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad62_ivansk
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCost : ContentPage
    {
        private int selectedQuantity;
        private decimal ticketPrice;
        private int quantityChildren;
        private int quantityPensioners;
        private int quantityStudents;
        private Movie movie;

        public PageCost(decimal price, Movie movie, int quantity)
        {
            InitializeComponent();
            selectedQuantity = quantity;

            ticketPrice = price;
            quantityChildren = 0;
            quantityPensioners = 0;
            quantityStudents = 0;
            this.movie = movie;

            var childrenEntry = new Entry
            {
                Placeholder = "Количество детей",
                Keyboard = Keyboard.Numeric,
                TextColor = Color.Black,
                PlaceholderColor = Color.DarkGray
            };

            var pensionersEntry = new Entry
            {
                Placeholder = "Количество пенсионеров",
                Keyboard = Keyboard.Numeric,
                TextColor = Color.Black,
                PlaceholderColor = Color.DarkGray
            };

            var studentsEntry = new Entry
            {
                Placeholder = "Количество студентов и учащихся",
                Keyboard = Keyboard.Numeric,
                TextColor = Color.Black,
                PlaceholderColor = Color.DarkGray
            };

            var titleLabel = new Label
            {
                Text = "Расчет стоимости билетов",
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.Black
            };

            var movieLabel = new Label
            {
                Text = $"Фильм: {movie.Title}\n\n{movie.Summary}",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black
            };

            var priceLabel = new Label
            {
                Text = $"Цена билета: {movie.TicketPrice:C}",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black
            };

            var calculateButton = new Button
            {
                Text = "Купить",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.White,
                BackgroundColor = Color.Red
            };

            var resultLabel = new Label
            {
                Text = "",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black
            };

            calculateButton.Clicked += async (sender, e) =>
            {
                if (!int.TryParse(childrenEntry.Text, out quantityChildren) ||
                    !int.TryParse(pensionersEntry.Text, out quantityPensioners) ||
                    !int.TryParse(studentsEntry.Text, out quantityStudents))
                {
                    await DisplayAlert("Ошибка", "Пожалуйста, введите правильное количество людей", "OK");
                    return;
                }

                int totalPeople = quantityChildren + quantityPensioners + quantityStudents;
                if (totalPeople > selectedQuantity)
                {
                    await DisplayAlert("Ошибка", "Сумма введенного количества людей больше, чем билетов", "OK");
                    return;
                }
                if (totalPeople < selectedQuantity)
                {
                    await DisplayAlert("Ошибка", "Сумма введенного количества людей меньше, чем билетов", "OK");
                    return;
                }
                decimal totalCost = CalculateTotalCost();
                int quantityMultichildFamilies = quantityChildren > 2 ? 1 : 0;
                resultLabel.Text = $"Дети (30%): {quantityChildren} - {ticketPrice * 0.7m * quantityChildren:C}\n" +
                                   $"Пенсионеры (20%): {quantityPensioners} - {ticketPrice * 0.8m * quantityPensioners:C}\n" +
                                   $"Студенты и учащиеся (20%): {quantityStudents} - {ticketPrice * 0.8m * quantityStudents:C}\n" +
                                   $"Многодетные семьи (10%): {quantityMultichildFamilies} - {ticketPrice * 0.9m * quantityMultichildFamilies:C}\n" +
                                   $"Общая стоимость: {totalCost:C}";

            };

            decimal CalculateTotalCost()
            {
                decimal totalCost = 0m;

                totalCost += ticketPrice * 0.7m * quantityChildren;
                totalCost += ticketPrice * 0.8m * quantityPensioners;
                totalCost += ticketPrice * 0.8m * quantityStudents;

                return totalCost;
            }

            Content = new StackLayout
            {
                BackgroundColor = Color.White,
                Children =
                {
                    titleLabel,
                    movieLabel,
                    priceLabel,
                    childrenEntry,
                    pensionersEntry,
                    studentsEntry,
                    calculateButton,
                    resultLabel
                }
            };
        }
    }
}
