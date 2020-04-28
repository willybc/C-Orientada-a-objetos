using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
    public class Rectangle
    {
        public double basis;    //base
        public double height;   //altura
        public double Area()
        {
            double area = this.basis * this.height;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = (this.basis * 2) + (this.height * 2);
            return perimetro;
        }

        //Añade un metodo Grow (crecer en ingles) que acepte un parametro double, que haga que
        //tanto la base como la altura del rectangulo crezcan la cantidad indicada en el parametro
        public void Grow(double quantify)
        {
            this.basis = this.basis + quantify;
            this.height = this.height + quantify;
        }

        //Añade un metodo para comprar 2 rectangulos y dar la diferencia de ambos rectangulos
        public double Compare(Rectangle rect)
        {
            return this.Area() - rect.Area();
        }

    }
}
