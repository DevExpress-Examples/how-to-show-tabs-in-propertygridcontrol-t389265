using System.Windows;
using System.ComponentModel.DataAnnotations;

namespace dxSampleGrid {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
          
            DataContext = new MyViewModel();
        }
    }



    public  class Person {
   
        public Person(int i) {
            FirstName = "FirstName" + i;
            LastName = "LastName" + i;
            Age = i * 10;
            HasChildren = i % 2 == 0;
        }
    
        [Display(GroupName = "Tab1")]
        public string FirstName { get; set; }
        [Display(GroupName = "Tab1")]
        public string LastName { get; set; }


        [Display(GroupName = "Tab2")]
        public int Age { get; set; }
        [Display(GroupName = "Tab2")]
        public bool HasChildren { get; set; }
    }

    public class MyViewModel {
        public MyViewModel() {
            SelectedPerson = new Person(55);
        }
        public Person SelectedPerson { get; set; }
    }


}
