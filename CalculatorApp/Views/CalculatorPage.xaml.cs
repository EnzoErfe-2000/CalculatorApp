using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        /*public class BookType
        {
            public string Type { get; set; }

        }
        
        public List<BookType> BkType
        {
            get => BkTypeData();
        }
        private List<BookType> BkTypeData()
        {
            var tempList = new List<BookType>();
            tempList.Add(new BookType { Type = "IB" });
            tempList.Add(new BookType { Type = "ABB" });

            return tempList;
        }
        
        public String SelectedBkType
        {
            get { return BkT.Type; }
            set
            {
                BkT.Type = value;
                OnPropertyChanged();
            }

        }*/
        public CalculatorPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public void Calculate(object sender, EventArgs e)
        {
            DisplayAlert("Completion Alert", "Successfully Added", "Back to Calculator");
            
        }
        async void GoToHome(object sender, EventArgs e)
        {
            //await Navigation.PopModalAsync();
            //await (Shell.Current as Xamarin.Forms.Shell).GoToAsync("//About/AboutPage");
            await Shell.Current.GoToAsync("//OrderListPage");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var pop = new PopupView();
            App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
        }
        /*
private void ShowPopup(object o, EventArgs e)
{
   PopupNavigation.Instance.PushAsync(new PopupView());
}
*/

    }
}