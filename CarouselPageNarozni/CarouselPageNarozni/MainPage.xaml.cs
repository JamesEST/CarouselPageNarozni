using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselPageNarozni
{
    public partial class MainPage : CarouselPage
    {
        ContentPage M4Carabin;
        public MainPage()
        {
            //InitializeComponent();
            Image img = new Image()
            {
                Source = "Guns.jpg"
            };
            Button btn1 = new Button()
            { 
                Text = "Автоматический карабин"
            };
            Button btn2 = new Button()
            {
                Text = "Автомат Калашникова"
            };
            Button btn3 = new Button()
            {
                Text = "Пистолет Пулемёт"
            };
            Button btn4 = new Button()
            {
                Text = "Пистолет"
            };
            StackLayout stack = new StackLayout();
            ContentPage content = new ContentPage();

            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            stack.Children.Add(img);
            stack.Children.Add(btn1);
            stack.Children.Add(btn2);
            stack.Children.Add(btn3);
            stack.Children.Add(btn4);
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
                            BackgroundColor = Color.Blue,
                            Source = "unnamed.jpg",

                        },
                    }
                }
            };

            var ak47 = new ContentPage
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
                            BackgroundColor = Color.Blue,
                            Source = "AK.jpg",
                        },
                    }
                }
            };
            Children.Add(content);
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            this.Children.Remove(M4Carabin);
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            this.Children.Add(M4Carabin);

        }
    }
}