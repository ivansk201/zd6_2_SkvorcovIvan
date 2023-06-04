using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Xamarin.Forms;


namespace zad62_ivansk
{
    public partial class MainPage : ContentPage
    {
        private int selectedQuantity;
        private List<Movie> movies;
        private async void OnQuantitySelected(object sender, int quantity)
        {
            selectedQuantity = quantity;
            await Navigation.PopAsync();
        }
        public MainPage()
        {



            InitializeComponent();

            movies = new List<Movie>
            {
                new Movie
                {
                    Title = "Человек-Паук 1 (2002)",
                    Studio = "Marvel",
                     Category = "Боевик/Фэнтези",
                    Capacity =125,
                    Theater = "Аида",
                    Hall = "Средний",
                    Seat = "2",
                    Time = "14:00",
                    Date = System.DateTime.Today,
                    Director = "Сэм Рэйми",
                    Year= 2002,
                    Country = "США",
                    Summary = "Школьник-неудачник Питер Паркер становится супергероем.",
                    TicketPrice = 150,
                    ImagePath = "mov3.png"


                },
                new Movie
                {
                     Title = "Человек-Паук 2 (2004)",
                   Studio = "Marvel",
                    Category = "Боевик/Фэнтези",
                    Capacity =125,
                    Theater = "ПаркХаус",
                    Hall = "Средний",
                    Seat = "2",
                    Time = "16:00",
                    Date = System.DateTime.Today,
                    Director = "Сэм Рэйми",
                    Year= 2004,
                    Country = "США",
                    Summary = "Нью-Йорку угрожает Осьминог, а у супергероя пропали способности.",
                    TicketPrice = 250,
                    ImagePath = "mov1.jpg"

                },
                new Movie
                {
                     Title = "Человек-Паук 3 (2007)",
                    Studio = "Marvel",
                    Category = "Боевик/Фэнтези",
                    Capacity =550,
                    Theater = "Сити-маолл",
                    Hall = "Большой",
                    Seat = "10",
                    Time = "18:00",
                    Date = System.DateTime.Today,
                   Director = "Сэм Рэйми",
                    Year= 2007,
                    Country = "США",
                    Summary = "Питер Паркер борется с новыми врагами и своей темной стороной.",
                    TicketPrice = 450,
                    ImagePath = "mov2.jpg"
                },
                new Movie
                {
                     Title = "Новый Человек-паук (2012)",
                   Studio = "Marvel",
                    Category = "Фантастика/Боевик/Приключения",
                    Capacity =300,
                    Theater = "Аура",
                    Hall = "Средний",
                    Seat = "1",
                    Time = "17:00",
                    Date = System.DateTime.Today,
                    Director = "Марк Уэбб",
                    Year= 2012,
                    Country = "США",
                    Summary = "Питер был обычным примерным школьником, подвергался нападкам хулиганов и был влюблён в свою одноклассницу Гвен Стэйси, которая сама втайне отвечала ему взаимностью. Но после укуса генетически изменённого паука, Питер получает невероятные сверхспособности и его жизнь меняется навсегда..",
                    TicketPrice = 500,
                    ImagePath = "mov4.jpg"

                },
                new Movie
                {
                     Title = "Новый Человек-паук: Высокое напряжение (2014)",
                   Studio = "Marvel",
                    Category = "Фантастика/Боевик/Приключения",
                    Capacity =400,
                    Theater = "РОССИЧ",
                    Hall = "Больщой",
                    Seat = "3",
                    Time = "12:00",
                    Date = System.DateTime.Today,
                    Director = "Марк Уэбб",
                    Year= 2014,
                    Country = "США",
                    Summary = "Питер Паркер под маской Человека-паука по-прежнему спасает мир от злодеев и преступников, а свободное время проводит со своей возлюбленной Гвен, но школьная пора близится к концу, и впереди героев ждет взрослая жизнь. Питер помнит о том, что дал отцу Гвен слово навсегда уйти из жизни девушки, тем самым больше не подвергая ее опасности. Однако сдержать это обещание не так просто. ",
                    TicketPrice = 345,
                    ImagePath = "mov5.jpg"

                },
                 new Movie
                {
                     Title = "Человек-паук: Возвращение домой (2017)",
                   Studio = "Marvel",
                    Category = "Фантастика/Боевик/Приключения",
                    Capacity =220,
                    Theater = "Гера",
                    Hall = "Средний",
                    Seat = "3",
                    Time = "92:00",
                    Date = System.DateTime.Today,
                    Director = "Джон Уоттс",
                    Year= 2017,
                    Country = "США",
                    Summary = "После встречи с командой Мстителей Питер Паркер возвращается домой и пытается жить обычной жизнью под опекой тёти Мэй. Но теперь за Питером приглядывает кое-кто ещё. ",
                    TicketPrice = 234,
                    ImagePath = "mov6.jpg"

                },
                new Movie
{
    Title = "Веном (2018)",
    Studio = "Sony Pictures",
    Category = "Боевик/Фантастика",
    Capacity = 150,
    Theater = "Аида",
    Hall = "Большой",
    Seat = "3",
    Time = "16:30",
    Date = System.DateTime.Today,
    Director = "Рубен Фляйшер",
    Year = 2018,
    Country = "США",
    Summary = "Репортёр Эдди Брок получает сверхспособности и превращается в Венома.",
    TicketPrice = 180,
    ImagePath = "mov7.png"
},
 new Movie
            {
                Title = "Веном 2 (2021)",
                Studio = "Sony Pictures",
                Category = "Боевик/Фантастика",
                Capacity = 180,
                Theater = "Аида",
                Hall = "Большой",
                Seat = "3",
                Time = "19:00",
                Date = System.DateTime.Today,
                Director = "Энди Серкис",
                Year = 2021,
                Country = "США",
                Summary = "Веном объединяется с Эдди Броком, чтобы сражаться с новыми угрозами.",
                TicketPrice = 200,
                ImagePath = "mov8.png"
            },
                new Movie
            {
                Title = "Железный человек (2008)",
                Studio = "Marvel",
                Category = "Боевик/Научная фантастика",
                Capacity = 200,
                Theater = "Аида",
                Hall = "Средний",
                Seat = "1",
                Time = "18:00",
                Date = System.DateTime.Today,
                Director = "Джон Фавро",
                Year = 2008,
                Country = "США",
                Summary = "Тони Старк становится супергероем Железным человеком.",
                TicketPrice = 170,
                ImagePath = "mov9.png"
            },
            new Movie
            {
                Title = "Железный человек 2 (2010)",
                Studio = "Marvel",
                Category = "Боевик/Научная фантастика",
                Capacity = 180,
                Theater = "Аида",
                Hall = "Средний",
                Seat = "1",
                Time = "21:00",
                Date = System.DateTime.Today,
                Director = "Джон Фавро",
                Year = 2010,
                Country = "США",
                Summary = "Тони Старк сражается с новыми врагами в качестве Железного человека.",
                TicketPrice = 190,
                ImagePath = "mov10.png"

        },
            new Movie
{
    Title = "Железный человек 3 (2013)",
    Studio = "Marvel",
    Category = "Боевик/Научная фантастика",
    Capacity = 200,
    Theater = "Аида",
    Hall = "Средний",
    Seat = "2",
    Time = "19:30",
    Date = System.DateTime.Today,
    Director = "Шейн Блэк",
    Year = 2013,
    Country = "США",
    Summary = "Тони Старк сражается с новым мощным врагом, используя свою технологию Железного человека.",
    TicketPrice = 180,
    ImagePath = "mov11.png"
},
            new Movie
{
    Title = "Темный рыцарь (2008)",
    Studio = "Warner Bros.",
    Category = "Боевик/Драма",
    Capacity = 180,
    Theater = "Аида",
    Hall = "Большой",
    Seat = "3",
    Time = "21:00",
    Date = DateTime.Today,
    Director = "Кристофер Нолан",
    Year = 2008,
    Country = "США",
    Summary = "Бэтмен сталкивается с преступным гений-маньяком, известным как Джокер.",
    TicketPrice = 200,
    ImagePath = "mov12.png"
},
            new Movie
{
    Title = "Начало (2010)",
    Studio = "Warner Bros.",
    Category = "Боевик/Научная фантастика",
    Capacity = 160,
    Theater = "Аида",
    Hall = "Средний",
    Seat = "5",
    Time = "19:30",
    Date = DateTime.Today,
    Director = "Кристофер Нолан",
    Year = 2010,
    Country = "США",
    Summary = "Группа воров специализируется на краже секретов из подсознания людей во время сна.",
    TicketPrice = 180,
    ImagePath = "mov13.png"
},
            new Movie
{
    Title = "Матрица (1999)",
    Studio = "Warner Bros.",
    Category = "Боевик/Научная фантастика",
    Capacity = 140,
    Theater = "Аида",
    Hall = "Малый",
    Seat = "2",
    Time = "17:00",
    Date = DateTime.Today,
    Director = "Лана Вачовски, Лилли Вачовски",
    Year = 1999,
    Country = "США",
    Summary = "Программист Нео обнаруживает, что мир, в котором он живет, на самом деле является компьютерной симуляцией.",
    TicketPrice = 150,
    ImagePath = "mov14.png"
},
            new Movie
{
    Title = "Люди в черном (1997)",
    Studio = "Columbia Pictures",
    Category = "Комедия/Научная фантастика",
    Capacity = 150,
    Theater = "Аида",
    Hall = "Большой",
    Seat = "1",
    Time = "20:00",
    Date = DateTime.Today,
    Director = "Барри Зонненфельд",
    Year = 1997,
    Country = "США",
    Summary = "Тайное правительственное агентство борется с инопланетными угрозами на Земле.",
    TicketPrice = 160,
    ImagePath = "mov15.png"
}, new Movie
{
    Title = "Люди в черном 2 (2002)",
    Studio = "Columbia Pictures",
    Category = "Комедия/Научная фантастика",
    Capacity = 140,
    Theater = "Аида",
    Hall = "Средний",
    Seat = "4",
    Time = "19:00",
    Date = DateTime.Today,
    Director = "Барри Зонненфельд",
    Year = 2002,
    Country = "США",
    Summary = "Агенты Кей и Джей возвращаются, чтобы спасти мир от новой угрозы.",
    TicketPrice = 150,
    ImagePath = "mov16.png"
},
            new Movie
{
    Title = "Люди в черном 3 (2012)",
    Studio = "Columbia Pictures",
    Category = "Комедия/Научная фантастика",
    Capacity = 160,
    Theater = "Аида",
    Hall = "Малый",
    Seat = "3",
    Time = "21:30",
    Date = DateTime.Today,
    Director = "Барри Зонненфельд",
    Year = 2012,
    Country = "США",
    Summary = "Агент Кей отправляется в прошлое, чтобы спасти своего партнера и предотвратить инопланетную инвазию.",
    TicketPrice = 170,
    ImagePath = "mov17.png"
}, new Movie
    {
        Title = "Люди в черном: Интернэшнл (2019)",
        Studio = "Columbia Pictures",
        Category = "Боевик/Научная фантастика",
        Capacity = 120,
        Theater = "Маяк",
        Hall = "Средний",
        Seat = "3",
        Time = "16:30",
        Date = DateTime.Today,
        Director = "Ф. Гэри Грей",
        Year = 2019,
        Country = "США",
        Summary = "Агенты МиБ сражаются с новой угрозой из другой галактики.",
        TicketPrice = 150,
        ImagePath = "mov18.png"
    },
                new Movie
    {
        Title = "Побег из Шоушенка (1994)",
        Studio = "Columbia Pictures",
        Category = "Драма/Криминал",
        Capacity = 110,
        Theater = "Палладиум",
        Hall = "Большой",
        Seat = "4",
        Time = "18:00",
        Date = DateTime.Today,
        Director = "Фрэнк Дарабонт",
        Year = 1994,
        Country = "США",
        Summary = "Умный заключенный Анди Дюфрейнт находит способ сбежать из тюрьмы.",
        TicketPrice = 120,
        ImagePath = "mov19.png"
    },
    new Movie
    {
        Title = "Зеленая миля (1999)",
        Studio = "Castle Rock Entertainment",
        Category = "Драма/Фэнтези",
        Capacity = 115,
        Theater = "Палладиум",
        Hall = "Средний",
        Seat = "2",
        Time = "20:15",
        Date = DateTime.Today,
        Director = "Фрэнк Дарабонт",
        Year = 1999,
        Country = "США",
        Summary = "Сотрудники тюрьмы сталкиваются с загадочным заключенным с необычными способностями.",
        TicketPrice = 130,
        ImagePath = "mov20.png"
    },
    new Movie
    {
        Title = "Форрест Гамп (1994)",
        Studio = "Paramount Pictures",
        Category = "Драма/Комедия",
        Capacity = 120,
        Theater = "Палладиум",
        Hall = "Малый",
        Seat = "1",
        Time = "22:30",
        Date = DateTime.Today,
        Director = "Роберт Земекис",
        Year = 1994,
        Country = "США",
        Summary = "Простодушный Форрест Гамп проживает необычную жизнь, влияя на исторические события.",
        TicketPrice = 140,
        ImagePath = "mov21.png"
    },
    new Movie
    {
        Title = "Титаник (1997)",
        Studio = "20th Century Fox",
        Category = "Драма/Романтика",
        Capacity = 125,
        Theater = "Киномакс",
        Hall = "Большой",
        Seat = "3",
        Time = "16:30",
        Date = DateTime.Today,
        Director = "Джеймс Кэмерон",
        Year = 1997,
        Country = "США",
        Summary = "Романтическая история о любви между пассажирами Титаника.",
        TicketPrice = 150,
        ImagePath = "mov22.png"
    },
    new Movie
    {
        Title = "Аватар (2009)",
        Studio = "20th Century Fox",
        Category = "Научная фантастика/Боевик",
        Capacity = 130,
        Theater = "Киномакс",
        Hall = "Средний",
        Seat = "2",
        Time = "19:00",
        Date = DateTime.Today,
        Director = "Джеймс Кэмерон",
        Year = 2009,
        Country = "США",
        Summary = "Бывший морской пехотинец вступает в битву за инопланетный мир.",
        TicketPrice = 160,
        ImagePath = "mov23.png"
    },
    new Movie
    {
        Title = "История игрушек (1995)",
        Studio = "Pixar Animation Studios",
        Category = "Мультфильм/Приключения",
        Capacity = 110,
        Theater = "Киномакс",
        Hall = "Малый",
        Seat = "1",
        Time = "21:00",
        Date = DateTime.Today,
        Director = "Джон Лассетер",
        Year = 1995,
        Country = "США",
        Summary = "Игрушки оживают, когда их владелец не видит.",
        TicketPrice = 120,
        ImagePath = "mov24.png"
    },
    new Movie
    {
        Title = "Храбрая сердцем (2012)",
        Studio = "Pixar Animation Studios",
        Category = "Мультфильм/Приключения",
        Capacity = 115,
        Theater = "Киномакс",
        Hall = "Большой",
        Seat = "4",
        Time = "17:30",
        Date = DateTime.Today,
        Director = "Марк Эндрюс",
        Year = 2012,
        Country = "США",
        Summary = "Девочка Мерида сражается с древним проклятием и спасает свою семью.",
        TicketPrice = 130,
        ImagePath = "mov25.png"
    },
    new Movie
    {
        Title = "Как приручить дракона (2010)",
        Studio = "DreamWorks Animation",
        Category = "Мультфильм/Приключения",
        Capacity = 120,
        Theater = "Киномакс",
        Hall = "Средний",
        Seat = "3",
        Time = "20:00",
        Date = DateTime.Today,
        Director = "Крис Сандерс, Дин Деблуа",
        Year = 2010,
        Country = "США",
        Summary = "Подросток Викк с драконом Беззубиком спасает свой остров.",
        TicketPrice = 140,
        ImagePath = "mov26.png"
    },
    new Movie
    {
        Title = "Головоломка (2015)",
        Studio = "Pixar Animation Studios",
        Category = "Мультфильм/Приключения",
        Capacity = 125,
        Theater = "Киномакс",
        Hall = "Малый",
        Seat = "2",
        Time = "22:30",
        Date = DateTime.Today,
        Director = "Пит Доктер",
        Year = 2015,
        Country = "США",
        Summary = "Девочка Райли пытается разобраться в своих эмоциях.",
        TicketPrice = 150,
        ImagePath = "mov27.png"
    },
    new Movie
    {
        Title = "Холодное сердце (2013)",
        Studio = "Walt Disney Animation Studios",
        Category = "Мультфильм/Приключения",
        Capacity = 130,
        Theater = "Планета кино",
        Hall = "Большой",
        Seat = "4",
        Time = "16:00",
        Date = DateTime.Today,
        Director = "Крис Бак, Дженнифер Ли",
        Year = 2013,
        Country = "США",
        Summary = "Принцесса Эльза пытается контролировать свои магические способности.",
        TicketPrice = 160,
        ImagePath = "mov28.png"
    },
    new Movie
    {
        Title = "Монстры, Inc. (2001)",
        Studio = "Pixar Animation Studios",
        Category = "Мультфильм/Комедия",
        Capacity = 110,
        Theater = "Планета кино",
        Hall = "Средний",
        Seat = "2",
        Time = "18:30",
        Date = DateTime.Today,
        Director = "Пит Доктер",
        Year = 2001,
        Country = "США",
        Summary = "Монстры занимаются сбором криков детей для получения энергии.",
        TicketPrice = 120,
        ImagePath = "mov29.png"
    },
    new Movie
    {
        Title = "Вверх (2009)",
        Studio = "Pixar Animation Studios",
        Category = "Мультфильм/Приключения",
        Capacity = 115,
        Theater = "Планета кино",
        Hall = "Малый",
        Seat = "1",
        Time = "20:00",
        Date = DateTime.Today,
        Director = "Пит Доктер",
        Year = 2009,
        Country = "США",
        Summary = "Пожилой человек отправляется в приключение с домом, прикрепленным к воздушным шарам.",
        TicketPrice = 130,
        ImagePath = "mov30.png"
    },
    new Movie
    {
        Title = "История игрушек 2 (1999)",
        Studio = "Pixar Animation Studios",
        Category = "Мультфильм/Приключения",
        Capacity = 120,
        Theater = "Планета кино",
        Hall = "Большой",
        Seat = "3",
        Time = "22:30",
        Date = DateTime.Today,
        Director = "Джон Лассетер",
        Year = 1999,
        Country = "США",
        Summary = "Игрушки оказываются в новом приключении, когда Вуди похищают.",
        TicketPrice = 140,
        ImagePath = "mov31.png"
    },
    new Movie
    {
        Title = "В поисках Немо (2003)",
        Studio = "Pixar Animation Studios",
        Category = "Мультфильм/Приключения",
        Capacity = 125,
        Theater = "Атмосфера",
        Hall = "Большой",
        Seat = "4",
        Time = "17:30",
        Date = DateTime.Today,
        Director = "Эндрю Стэнтон",
        Year = 2003,
        Country = "США",
        Summary = "Отец-рыба Марлин искусственно находит своего сына Немо.",
        TicketPrice = 150,
        ImagePath = "mov32.png"
    },
    new Movie
    {
        Title = "ВАЛЛ-И (2008)",
        Studio = "Pixar Animation Studios",
        Category = "Мультфильм/Научная фантастика",
        Capacity = 130,
        Theater = "Атмосфера",
        Hall = "Средний",
        Seat = "2",
        Time = "19:00",
        Date = DateTime.Today,
        Director = "Эндрю Стэнтон",
        Year = 2008,
        Country = "США",
        Summary = "Маленький робот ВАЛЛ-И оказывается в великом приключении.",
        TicketPrice = 160,
        ImagePath = "mov33.png"
    }, new Movie
    {
        Title = "Звездные войны: Эпизод IV - Новая надежда (1977)",
        Studio = "Lucasfilm Ltd.",
        Category = "Научная фантастика/Фэнтези",
        Capacity = 120,
        Theater = "Атмосфера",
        Hall = "Средний",
        Seat = "3",
        Time = "19:30",
        Date = DateTime.Today,
        Director = "Джордж Лукас",
        Year = 1977,
        Country = "США",
        Summary = "Повстанцы сражаются с Империей в далекой галактике.",
        TicketPrice = 140,
        ImagePath = "mov34.png"
    },
    new Movie
    {
        Title = "Властелин колец: Братство кольца (2001)",
        Studio = "New Line Cinema",
        Category = "Фэнтези/Приключения",
        Capacity = 125,
        Theater = "Атмосфера",
        Hall = "Малый",
        Seat = "2",
        Time = "22:00",
        Date = DateTime.Today,
        Director = "Питер Джексон",
        Year = 2001,
        Country = "США",
        Summary = "Фродо отправляется в опасное путешествие, чтобы уничтожить Кольцо Всевластья.",
        TicketPrice = 150,
        ImagePath = "mov35.png"
    },
    new Movie
    {
        Title = "Гарри Поттер и Философский камень (2001)",
        Studio = "Warner Bros. Pictures",
        Category = "Фэнтези/Приключения",
        Capacity = 130,
        Theater = "Атмосфера",
        Hall = "Большой",
        Seat = "1",
        Time = "17:45",
        Date = DateTime.Today,
        Director = "Крис Коламбус",
        Year = 2001,
        Country = "США",
        Summary = "Мальчик-волшебник Гарри Поттер учится в Хогвартсе.",
        TicketPrice = 160,
        ImagePath = "mov36.png"
    },
    new Movie
    {
        Title = "Назад в будущее (1985)",
        Studio = "Universal Pictures",
        Category = "Научная фантастика/Комедия",
        Capacity = 110,
        Theater = "Атмосфера",
        Hall = "Средний",
        Seat = "2",
        Time = "19:00",
        Date = DateTime.Today,
        Director = "Роберт Земекис",
        Year = 1985,
        Country = "США",
        Summary = "Молодой Марти отправляется в прошлое, чтобы спасти будущее.",
        TicketPrice = 120,
        ImagePath = "mov37.png"
    },new Movie
    {
        Title = "Назад в будущее 2 (1989)",
        Studio = "Universal Pictures",
        Category = "Фантастика/Приключения",
        Capacity = 120,
        Theater = "Люксор",
        Hall = "Большой",
        Seat = "4",
        Time = "16:15",
        Date = DateTime.Today,
        Director = "Роберт Земекис",
        Year = 1989,
        Country = "США",
        Summary = "Марти и Док путешествуют в будущее, чтобы спасти свою семью.",
        TicketPrice = 160,
        ImagePath = "mov38.png"
    },
    new Movie
    {
        Title = "Назад в будущее 3 (1990)",
        Studio = "Universal Pictures",
        Category = "Фантастика/Приключения",
        Capacity = 115,
        Theater = "Люксор",
        Hall = "Малый",
        Seat = "2",
        Time = "20:30",
        Date = DateTime.Today,
        Director = "Роберт Земекис",
        Year = 1990,
        Country = "США",
        Summary = "Марти и Док путешествуют в прошлое и сталкиваются с диким Западом.",
        TicketPrice = 170,
        ImagePath = "mov39.png"
    },
    new Movie
    {
        Title = "СССР (2022)",
        Studio = "Кинокомпания",
        Category = "Драма/Исторический",
        Capacity = 100,
        Theater = "Родина",
        Hall = "Малый",
        Seat = "3",
        Time = "17:45",
        Date = DateTime.Today,
        Director = "Имя Режиссера",
        Year = 2022,
        Country = "СССР",
        Summary = "История о жизни в СССР и его значимости в мировой истории.",
        TicketPrice = 150,
        ImagePath = "mov40.png"
    },


        };
            var titleLabel = new Label
            {
                Text = "Онлайн-кинотеатр (покупка билетов)",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Red,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            var listView = new ListView
            {
                ItemTemplate = new DataTemplate(typeof(TextCell)),
                ItemsSource = movies,
                SeparatorVisibility = SeparatorVisibility.Default
            };
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listView.ItemSelected += OnMovieSelected;
            var quantityButton = new Button
            {
                Text = "Выбор количества билетов",
                BackgroundColor = Color.Gray,
                TextColor = Color.White
            };
            quantityButton.Clicked += async (sender, e) =>
            {
                var selectedMovie = listView.SelectedItem as Movie;
                if (selectedMovie != null)
                {
                    var quantityPage = new PageQuant(selectedMovie);
                    quantityPage.QuantitySelected += OnQuantitySelected;
                    await Navigation.PushAsync(quantityPage);
                }
                else
                {
                    await DisplayAlert("Ошибка", "Пожалуйста, выберите фильм.", "OK");
                }
            };
            var assembly = typeof(MainPage).Assembly;
            var costButton = new Button
            {
                Text = "Расчет стоимости билетов",
                BackgroundColor = Color.Gray,
                TextColor = Color.White
            };
            costButton.Clicked += async (sender, e) =>
            {
                var selectedMovie = listView.SelectedItem as Movie;
                if (selectedMovie != null)
                {
                    if (selectedQuantity > 0)
                    {
                        var costPage = new PageCost(selectedMovie.TicketPrice, selectedMovie, selectedQuantity);
                        await Navigation.PushModalAsync(costPage);
                    }
                    else
                    {
                        selectedQuantity = 1;
                        var costPage = new PageCost(selectedMovie.TicketPrice, selectedMovie, selectedQuantity);
                        await Navigation.PushModalAsync(costPage);
                    }
                }
                else
                {
                    await DisplayAlert("Ошибка", "Пожалуйста, выберите фильм.", "OK");
                }
            };

            BackgroundColor = Color.White;
            titleLabel.TextColor = Color.Black;
            quantityButton.BackgroundColor = Color.Red;
            quantityButton.TextColor = Color.White;
            costButton.BackgroundColor = Color.Red;
            costButton.TextColor = Color.White;
            listView.SeparatorColor = Color.Black;
            Content = new StackLayout
            {
                Children =
                {
                    titleLabel,
                    listView,
                    quantityButton,
                    costButton
                }
            };


            async void OnMovieSelected(object sender, SelectedItemChangedEventArgs e)
            {
                var selectedMovie = e.SelectedItem as Movie;
                if (selectedMovie != null)
                {
                    await DisplayAlert("Информация о фильме", $"Название: {selectedMovie.Title}\n" +
                                                             $"Киностудия: {selectedMovie.Studio}\n" +
                                                             $"Категория: {selectedMovie.Category}\n" +
                                                             $"Вместимость: {selectedMovie.Capacity}\n" +
                                                             $"Кинотеатр: {selectedMovie.Theater}\n" +
                                                             $"Зал: {selectedMovie.Hall}\n" +
                                                             $"Место: {selectedMovie.Seat}\n" +
                                                             $"Время: {selectedMovie.Time}\n" +
                                                             $"Дата: {selectedMovie.Date}\n" +
                                                             $"Режиссер: {selectedMovie.Director}\n" +
                                                              $"Год выпуска: {selectedMovie.Year}\n" +
                                                             $"Страна: {selectedMovie.Country}\n" +
                                                             $"Краткое содержание: {selectedMovie.Summary}\n" +
                                                              $"Цена билета: {selectedMovie.TicketPrice}\n"


                                                             , "OK");

                }
            }

        }
    }
}
