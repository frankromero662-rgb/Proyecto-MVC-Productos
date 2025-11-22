namespace ProyectoMVC.Modelo
{
    public class Producto
    {
        private static int contador = 1;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            Id = contador++;
            Nombre = nombre;
            Precio = precio;
        }
    }
}