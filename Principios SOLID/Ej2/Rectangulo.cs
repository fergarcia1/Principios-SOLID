using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_SOLID
{
    interface FigurasGeometricas
    {
        double CalculoArea();
    }
    class Rectangulo : FigurasGeometricas
    {
        private double baseRec;
        private double altura;

        public Rectangulo()
        {
        }

        public Rectangulo(double baseRec, double altura)
        {
            this.baseRec = baseRec;
            this.altura = altura;
        }

        public double BaseRec { get => baseRec; set => baseRec = value; }
        public double Altura { get => altura; set => altura = value; }

        public double CalculoArea()
        {
            return this.Altura * this.BaseRec;
        }
    }

    class CalcularArea
    {
        //la clase CalcularArea solo es util para rectangulos,pero si necesito calcular el area de cualquier otra
        //figura geometria no tiene utilidad, por eso seria mejor implementar una interfaz con el metodo calcular area
        //y en caso de necesitarlo, darle a cada figura su propio metodo de calcularArea.
        public double calcularArea(Rectangulo rec)
        {
            return rec.Altura * rec.BaseRec;
        }
    }

    class Circulo : FigurasGeometricas
    {
        private double radio;
        public double CalculoArea()
        {
            return (Math.PI * (this.radio * this.radio));
        }
    }
}
