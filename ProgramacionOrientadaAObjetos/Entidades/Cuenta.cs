using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string razonSocial;
        private float cantidad;

        public Cuenta()
        {
            this.razonSocial = "";
        }
        
        public Cuenta(string razonSocial, float cantidad)
        {
            this.razonSocial = razonSocial;
            this.cantidad = cantidad;
        }

        public string RazonSocial 
        { 
            get { return razonSocial; }
        }

        public float Cantidad
        {
            get { return cantidad; }
        }

        public string Mostrar()
        {                 

            StringBuilder sb = new  StringBuilder();
            sb.AppendLine($"Razon social: {RazonSocial}");
            sb.AppendLine($"Saldo: ${Cantidad}");

            return sb.ToString();
        }

        public void Ingresar(float montoIngresado, Cuenta cuenta)
        {
            if(montoIngresado > 0)
            {
                cuenta.cantidad += montoIngresado;
            }
        }

        public void Retirar(float montoRetirado, Cuenta cuenta)
        {
            if (montoRetirado > 0)
            {
                cuenta.cantidad -= montoRetirado;
            }
        }
    }
}