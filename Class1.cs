using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Class1 : Interface1
    {
        private double _myProperty;
        public float MyProperty { 
            get { return (float)(_myProperty * 1.23); }
            set { _myProperty = value; }
        }

        public int Zmienna { get; set; }

        public virtual void fun()
        {

        }

        public void Metoda()
        {
            try
            {

            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
