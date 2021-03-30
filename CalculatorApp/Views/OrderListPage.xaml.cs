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
    public partial class OrderListPage : ContentPage
    {
        public class Booking
        {
            public string Property { get; set; }
            public string Type { get; set; }
            public string Duration { get; set; }
            public string Total { get; set; }

        }
        public List<Booking> Bookings
        {
            get => BookingData();
        }
        private List<Booking> BookingData()
        {
            var tempList = new List<Booking>();
            tempList.Add(new Booking { Property = "22", Type = "IB", Duration = "[1/2/21 ~ 12/1/22]", Total = "RM 70.00" });
            tempList.Add(new Booking { Property = "23", Type = "ABB", Duration = "[1/2/21 ~ 12/1/22]", Total = "RM 70.00" });
            tempList.Add(new Booking { Property = "24", Type = "ABB", Duration = "[1/2/21 ~ 12/1/22]", Total = "RM 70.00" });
            tempList.Add(new Booking { Property = "22", Type = "IB", Duration = "[1/2/21 ~ 12/1/22]", Total = "RM 70.00" });
            tempList.Add(new Booking { Property = "23", Type = "ABB", Duration = "[1/2/21 ~ 12/1/22]", Total = "RM 70.00" });
            tempList.Add(new Booking { Property = "24", Type = "ABB", Duration = "[1/2/21 ~ 12/1/22]", Total = "RM 70.00" });
            tempList.Add(new Booking { Property = "22", Type = "IB", Duration = "[1/2/21 ~ 12/1/22]", Total = "RM 70.00" });
            tempList.Add(new Booking { Property = "23", Type = "ABB", Duration = "[1/2/21 ~ 12/1/22]", Total = "RM 70.00" });
            tempList.Add(new Booking { Property = "24", Type = "ABB", Duration = "[1/2/21 ~ 12/1/22]", Total = "RM 70.00" });

            return tempList;
        }

        public OrderListPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        
    }
}