using ProyectoMVC.Modelo;
using System.Collections.Generic;

namespace ProyectoMVC.Controlador
{
    public class ProductoControlador
    {
        private ProductoRepositorio repo = new ProductoRepositorio();

        public void AgregarProducto(string nombre, double precio)
        {
            Producto nuevo = new Producto(nombre, precio);
            repo.Agregar(nuevo);
        }

        public List<Producto> ObtenerProductos()
        {
            return repo.ObtenerProductos();
        }

        public void EditarProducto(int id, string nuevoNombre, double nuevoPrecio)
        {
            Producto editado = new Producto(nuevoNombre, nuevoPrecio)
            {
                Id = id
            };
            repo.Editar(editado);
        }

        public void EliminarProducto(int id)
        {
            repo.Eliminar(id);
        }
    }
}