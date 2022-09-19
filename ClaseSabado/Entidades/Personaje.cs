using System.Text;

namespace Entidades
{
    public class Personaje
    {
        
        private string nombre;
        private int vida;
        

        public Personaje()
        {

        }

        public Personaje(string nombre)
        {
            this.nombre = nombre;
        }

        public Personaje(string nomb, int vida):this(nomb)
        {
            nombre = nomb;
            this.vida = vida;
        }

        

        public string Nombre
        {
            get { return nombre; }
        }

        public int Vida
        {
            get { return vida; }
        }

        public string MonstrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"El nombre es {nombre}");
            sb.AppendLine($"La vida es {vida}");    

            return sb.ToString();
        }

        
    }
}