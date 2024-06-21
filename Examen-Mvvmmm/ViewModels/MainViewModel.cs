using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Mvvm.ViewModels

{

    public class MainViewModel : ObservableObject

    {

        private double _a;

        private double _b;

        private double _c;

        private double _x1;

        private double _x2;


        public double A

        {

            get => _a;

            set => SetProperty(ref _a, value);

        }


        public double B

        {

            get => _b;

            set => SetProperty(ref _b, value);

        }


        public double C

        {

            get => _c;

            set => SetProperty(ref _c, value);

        }


        public double X1

        {

            get => _x1;

            set => SetProperty(ref _x1, value);

        }


        public double X2

        {

            get => _x2;

            set => SetProperty(ref _x2, value);

        }


        public MainViewModel()

        {

        }


        public void Calculate()

        {

            if (A == 0)

            {

                throw new InvalidOperationException("El valor de a no puede ser cero");

            }


            var discriminant = B * B - 4 * A * C;

            if (discriminant < 0)

            {

                throw new InvalidOperationException("El resultado dentro de la raíz cuadrada no puede ser negativa");

            }


            var sqrtDiscriminant = Math.Sqrt(discriminant);

            X1 = (-B + sqrtDiscriminant) / (2 * A);

            X2 = (-B - sqrtDiscriminant) / (2 * A);

        }


        public void Clear()

        {

            A = 0;

            B = 0;

            C = 0;

            X1 = 0;

            X2 = 0;

        }

    }

}