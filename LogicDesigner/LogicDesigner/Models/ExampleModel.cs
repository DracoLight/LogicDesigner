using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDesigner.Models
{
    public class ExampleModel : BaseModel
    {
        // property can be created with 'propfull'+[Tab]+[Tab]
        private int exampleInt = 0;

        public int ExampleInt
        {
            get { return exampleInt; }
            set
            {
                exampleInt = value;
                NotifyPropertyChanged();
            }
        }

        private string exampleString;

        public string ExampleString
        {
            get { return exampleString; }
            set
            {
                exampleString = value;
                NotifyPropertyChanged();
            }
        }




    }
}
