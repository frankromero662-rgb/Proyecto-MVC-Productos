using System.Collections.Generic;
using System.Linq;

namespace ProyectoMVC.Modelo
{
    public class ProductoRepositorio
    {
        private List<Producto> productos = new List<Producto>();

        public void Agregar(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }

        public void Editar(Producto productoEditado)
        {
            var encontrado = productos.FirstOrDefault(p => p.Id == productoEditado.Id);

            if (encontrado != null)
            {
                encontrado.Nombre = productoEditado.Nombre;
                encontrado.Precio = productoEditado.Precio;
            }
        }

        public void Eliminar(int id)
        {
            var productoEliminar = productos.FirstOrDefault(p => p.Id == id);
            if (productoEliminar != null)
            {
                productos.Remove(productoEliminar);
            }
        }
    }
}