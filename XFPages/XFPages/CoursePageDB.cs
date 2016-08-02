using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFPages
{
    class CoursePageDB : ContentPage
    {
        public CoursePageDB()
        {

            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            BackgroundColor = Color.Gray;

            //this.Title = course.TitleShort;
            this.SetBinding(ContentPage.TitleProperty, "TitleShort");

            var titleLabel = new Label
            {
                //Text = course.Title,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            titleLabel.SetBinding(Label.TextProperty, "Title");

            var authorLabel = new Label
            {
                //Text = course.Author,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            authorLabel.SetBinding(Label.TextProperty, "Author");

            var descriptionLabel = new Label
            {
                //Text = course.Description,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            descriptionLabel.SetBinding(Label.TextProperty, "Description");

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Spacing = 10,
                    Children = { titleLabel, authorLabel, descriptionLabel }
                }
            };
        }
    }
}
