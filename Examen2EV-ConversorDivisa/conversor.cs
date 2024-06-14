using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenEX_ConversorDivisa
{
    class conversor
    {
        // Declaramos la constante que convierte entre euros y dolares.
        //
        public const double CONV1 = 0.826;  // 1 dolar, 0,826 euros
        public const double CONV2 = 1.1485; // 1 libra, 1,1485 euros

        public double conv1(String text) {  // dólares a euros
            if (text.Length==0)
                return 0;           // Error, el texto no puede estar vacío

            double dolares;

            dolares = double.Parse(text);
            return dolares*CONV1;
        }

        public double conv2(String text) // euros a dólares
        {  
            if (text.Length==0)
                return 0;           // Error, el texto no puede estar vacío

            double euros;

            euros = double.Parse(text);
            return euros/CONV1;
        }
        public double conv3(String text) // libras a euros
        {  
            if (text.Length==0)
                return 0;           // Error, el texto no puede estar vacío

            double libras;

            libras = double.Parse(text);
            return libras*CONV2;
        }

        public double conv4(String text) // euros a libras
        {
            if (text.Length==0)
                return 0;           // Error, el texto no puede estar vacío

            double euros;

            euros = double.Parse(text);
            return euros/CONV2;
        }
    }
}
