using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenEX_ConversorDivisa
{
    class conversor
    {
        public double conv1(String text) {  // dólares a euros, un dólar -> 0,83 euros
            if (text.Length==0)
                return 0;           // Error, el texto no puede estar vacío

            double dolares;

            dolares = double.Parse(text);
            return dolares/0.83;
        }

        public double conv2(String text) // euros a dólares
        {  
            if (text.Length==0)
                return 0;           // Error, el texto no puede estar vacío

            double euros;

            euros = double.Parse(text);
            return euros*0.83;
        }
        public double conv3(String text) // libras a euros, 1 libra -> 1,15 euros
        {  
            if (text.Length==0)
                return 0;           // Error, el texto no puede estar vacío

            double libras;

            libras = double.Parse(text);
            return libras/1.15;
        }

        public double conv4(String text) // euros a libras
        {
            if (text.Length==0)
                return 0;           // Error, el texto no puede estar vacío

            double euros;

            euros = double.Parse(text);
            return euros*1.15;
        }
    }
}
