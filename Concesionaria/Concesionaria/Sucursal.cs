using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        Gerente nombreGerente;
        int capacidadMaxima;
        List<Auto> listaAutos;
        string ubicacion;
        string telefono;
        
                

        public Sucursal(Gerente nombreGerente, int capacidadMaxima, string ubicacion)
        {
            this.nombreGerente = nombreGerente;
            this.capacidadMaxima = capacidadMaxima;            
            this.ubicacion = ubicacion;
            this.listaAutos = new List<Auto>();
        }

        public Sucursal(Gerente nombreGerente, int capacidadMaxima, string ubicacion, string telefono) : this(nombreGerente, capacidadMaxima, ubicacion)
        {
            this.telefono = telefono;
        }

        public bool AgregarAuto(Auto auxAuto)
        {
            if (auxAuto is null && listaAutos.Count == capacidadMaxima)
                return false;
                
           listaAutos.Add(auxAuto);
            return true;
        }
    }
}
