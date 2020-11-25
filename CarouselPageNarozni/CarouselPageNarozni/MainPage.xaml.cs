using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace CarouselPageNarozni
{
    public partial class MainPage : CarouselPage
    {
        ContentPage M4Carabin, ak, ak12, M4, glock, colt;
      
        public MainPage()
        {
            //InitializeComponent();
            Image img = new Image()
            {
                Source = "Guns.jpg"
                
            };
            Button btn1 = new Button()
            { 
                Text = "Автоматические Винтовки"
            };
            Button btn2 = new Button()
            {
                Text = "Автомат Калашникова"
            };
            
            Button btn4 = new Button()
            {
                Text = "Пистолет"
            };
            Button btn5 = new Button()
            {
                Text = "Больше информации"
            };
            Button btn6 = new Button()
            {
                Text = "Больше информации"
            };
            Button btn7 = new Button()
            {
                Text = "Больше информации"
            };
            Button btn8 = new Button()
            {
                Text = "Больше информации"
            };
            Button btn9 = new Button()
            {
                Text = "Больше информации"
            };
            Button btn10 = new Button()
            {
                Text = "Больше информации"
            };
            Button btn11 = new Button()
            {
                Text = "Больше информации"
            };


            StackLayout stack = new StackLayout();
            ContentPage content = new ContentPage();

            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn4.Clicked += Btn4_Clicked;
            btn5.Clicked += Btn5_Clicked;
            btn6.Clicked += Btn6_Clicked;
            btn7.Clicked += Btn7_Clicked;
            btn8.Clicked += Btn8_Clicked;
            btn9.Clicked += Btn9_Clicked;
            btn10.Clicked += Btn10_Clicked;
            btn11.Clicked += Btn11_Clicked;
            stack.Children.Add(img);
            stack.Children.Add(btn4);   
            stack.Children.Add(btn2);
            stack.Children.Add(btn1);


            content.Content = stack;

            M4Carabin = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.FromHex("2296f3"),
                            Content = new Label { Text = "M4 Carbine", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))}

                        },
                        new Image
                        {
                            Source = "unnamed.jpg",
                        },
                         new Label
                        {
                            Text = "M4 (войсковой индекс и наименование — Carbine, 5.56 mm, M4, заводской индекс изготовителя — Colt Model 920) — автоматический карабин, созданный в США на основе винтовки М16А2 и изначально предназначенный для вооружения экипажей боевых машин и расчётов вооружения и военной техники. "
                        },
                        btn5
                        
                    }
                }
            };
            M4 = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.FromHex("2296f3"),
                            Content = new Label { Text = "M16", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))}
                        },
                        new Image
                        {
                            Source = "mmm.jpg",
                        },
                        new Label
                        {
                            Text= "M16 (официальное обозначение — Rifle, Caliber 5.56 mm, M16) — американская автоматическая винтовка калибра 5,56 мм, разработанная и принятая на вооружение в 1960-х годах. "
                        },
                        
                        btn6
                    },
                }
            };
            ak = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.FromHex("2296f3"),
                            Content = new Label { Text = "АК-74", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))}

                        },
                        new Image
                        {
                            Source = "AK.jpg",
                     
                        },
                        new Label
                        {
                            Text = "5,45-мм автомат Калашникова образца 1974 года (индекс ГРАУ — 6П20)— автомат калибра 5,45 мм, разработанный в 1970 году советским конструктором М. Т. Калашниковым и принятый на вооружение вооружённых сил СССР в 1974 году. Является дальнейшим развитием АКМ. Разработка АК-74 связана с переходом на новый малоимпульсный патрон 5,45×39 мм."
                        },
                        btn7

                    }
                }
            };
            ak12 = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.FromHex("2296f3"),
                            Content = new Label { Text = "АК-12", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))}

                        },
                        new Image
                        {
                            Source = "akk.jpg",
                        
                        },
                        new Label
                        {
                            Text = "АК-12 - Представлял собой принципиально новый автомат, реализованный с использованием общей схемы и технических решений прежних АК. "
                        },
                        btn8

                    }
                }
            };
            glock = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.FromHex("2296f3"),
                            Content = new Label { Text = "АК-12", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))}

                        },
                        new Image
                        {
                            Source = "glock.jpg",

                        },
                        new Label
                        {
                            Text = "Пистолеты конструкции Гастона Глока производятся серийно с начала 80-х после победы данной конструкции на конкурсе, устроенном в 1980 г. австрийской армией. В настоящее время они состоят на вооружении более чем в 30 странах."
                        },
                        btn10
                        

                    }
                }
            };
            colt = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.FromHex("2296f3"),
                            Content = new Label { Text = "M1911", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))}

                        },
                        new Image
                        {
                            Source = "colt.jpg",

                        },
                        new Label
                        {
                            Text = "M1911 — самозарядный пистолет под патрон .45 ACP. Разработан Джоном Мозесом Браунингом в 1908 году (U.S. Patent 984519, 14 февраля 1911 года). Пистолет находился на вооружении лиц офицерского и сержантского состава всех видов вооружённых сил, родов войск и служб ВС США с 1911 по 1985 год, разрешён к использованию военными и полицейскими служащими в качестве личного оружия и в настоящее время. "
                        },
                        btn11

                    }
                }
            };
            Children.Add(content);
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            this.Children.Remove(M4Carabin);
            this.Children.Remove(M4);
            this.Children.Remove(ak);
            this.Children.Remove(ak12);
            this.Children.Add(glock);
            this.Children.Add(colt);
        }

        private async void Btn11_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://ru.wikipedia.org/wiki/M1911");
            await Browser.OpenAsync(url);
        }

        private async void Btn10_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://ru.wikipedia.org/wiki/Glock");
            await Browser.OpenAsync(url);
        }

        private async void Btn9_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://ru.wikipedia.org/wiki/%D0%90%D0%9A74");
            await Browser.OpenAsync(url);
        }

        private async void Btn8_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://ru.wikipedia.org/wiki/%D0%90%D0%9A-12");
            await Browser.OpenAsync(url);
        }

        private async void Btn7_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://ru.wikipedia.org/wiki/%D0%90%D0%9A74");
            await Browser.OpenAsync(url);
        }

        private async void Btn6_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://ru.wikipedia.org/wiki/M16_(%D0%B2%D0%B8%D0%BD%D1%82%D0%BE%D0%B2%D0%BA%D0%B0)");
            await Browser.OpenAsync(url);
        }

        private async void Btn5_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://ru.wikipedia.org/wiki/M4_(%D0%B0%D0%B2%D1%82%D0%BE%D0%BC%D0%B0%D1%82)");
            await Browser.OpenAsync(url);
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            this.Children.Remove(M4Carabin);
            this.Children.Remove(M4);
            this.Children.Remove(glock);
            this.Children.Remove(colt);
            this.Children.Add(ak);
            this.Children.Add(ak12);
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            this.Children.Remove(ak);
            this.Children.Remove(ak12);
            this.Children.Remove(glock);
            this.Children.Remove(colt);
            this.Children.Add(M4Carabin);
            this.Children.Add(M4);

        }
    }
}