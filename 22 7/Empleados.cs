using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_7
{
    class Empleados
    {
        private int id;
        private string nombre;
        private int dui;
        private double salario;
       

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Dui
        {
            get { return dui; }
            set { dui = value; }
        }
        
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        
        }

        public double AFP (double salario) {
            double calAFP = salario * 0.0625;
            return calAFP;

        }
        public double ISSS(double salari) {
            double calisss = salario * 0.03;
            return calisss;
        
        }
        public double Salnet(double salari) {
            double calsalnet = salari - (ISSS(salari) + AFP(salari));
            return calsalnet;
        
        }
    }
}

