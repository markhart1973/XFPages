using System.Linq;
using Xamarin.Forms;

namespace XFPages
{
    class CourseMasterDetailDB : MasterDetailPage
    {
        public CourseMasterDetailDB()
        {
            var listView = new ListView();
            listView.ItemsSource = PluralsightCourse.GetCourseList();
            listView.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem == null)
                {
                    return;
                }
                Detail.BindingContext = e.SelectedItem;

                IsPresented = false;
            };
            Master = new ContentPage
            {
                Title = "Courses",
                Content = listView
            };

            Detail = new CoursePageDB();
            Detail.BindingContext = PluralsightCourse.GetCourseList().First();
        }

    }
}
