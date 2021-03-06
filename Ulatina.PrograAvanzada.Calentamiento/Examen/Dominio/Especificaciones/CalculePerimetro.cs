﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Dominio.Especificaciones
{
    public class CalculePerimetro
    {
        public double PerimetroTriangulo(double lado1, double lado2, double lado3)
        {
            double elResultado = 0;
            var laValidacion = new Validaciones.LadosValidos();
            bool ladosValidos = laValidacion.LadosTrianguloValidos(lado1, lado2, lado3);
            if (ladosValidos)
            {
                double elPerimetro = lado1 + lado2 + lado3;
                elResultado = elPerimetro;
            }
            return elResultado;
        }
    }
}