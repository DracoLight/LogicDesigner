using LogicDesigner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicDesigner.ViewModels
{
    public class icon : BaseModel
    {

        // Needs to be property to be bound to view
        public ExampleModel Test { get; set; }
        private string test2;

        public string Test2
        {
            get { return test2; }
            set {
                test2 = value;
                NotifyPropertyChanged();
            }
        }


        // constructor
        public icon ()
        {
            Test = new ExampleModel();
            Test.ExampleString = "Hello World";
        }

        public void example_Click()
        {
            Test.ExampleInt += 1;
        }


    }
}
