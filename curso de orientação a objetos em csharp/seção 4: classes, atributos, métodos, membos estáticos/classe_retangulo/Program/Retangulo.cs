﻿using System;

namespace Program {
    class Retangulo {

        public double Largura;
        public double Altura;
        public double Area() {
            return (Largura * Altura);
        }
        public double Perimetro() {
            return (Largura + Altura) * 2;
        }
        public double Diagonal() {
            return Math.Sqrt((Largura * Largura)+(Altura * Altura));
        }

 }
}
