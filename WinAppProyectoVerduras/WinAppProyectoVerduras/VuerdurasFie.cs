using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppProyectoVerduras
{
    internal class VuerdurasFie
    {
       public void VerdurasFie()
        {

        }
       

        
    }
    public class cEmpleados
    {

        DataSet1.EmpleadoDataTable empleados;

        public cEmpleados()
        {
            cargarEmpleados();
        }

        public void cargarEmpleados()
        {
            if (!(File.Exists("e:\\empleados.xml")))
            {
                empleados = new DataSet1.EmpleadoDataTable();
                empleados.WriteXml("e:\\empleados.xml");
            }
            else
            {
                empleados = new DataSet1.EmpleadoDataTable();
                this.empleados.ReadXml("e:\\empleados.xml");
            }
        }


        public void guardarEmpleado(object[] vec)
        {
            empleados.Rows.Add(vec);
            empleados.WriteXml("e:\\empleados.xml");

        }

        public DataSet1.EmpleadoDataTable getEmpleadosAll()
        {
            return empleados;
        }

        public void editarEmpleado(object[] empleado)
        {
            empleados.Rows.Add(empleado);
            empleados.WriteXml("e:\\empleados.xml");

        }

        public object getEmpleadoId(int empleadoId)
        {
            object[] empleado = new object[5];
            return empleado;
        }

        public void EliminarEmpleado()
        {

        }

        public int cantidadEmpleados()
        {
            int cantidad = 0;
            cantidad = empleados.Count();
            return cantidad;
        }
    }
    //---------------------CLASE PRODUCTOS-----------------------------------
    public class cProductos
    {

        DataSet1.ProductoDataTable productos;

        public cProductos()
        {
            cargarProductos();
        }

        public void cargarProductos()
        {
            if (!(File.Exists("e:\\productos.xml")))
            {
                productos = new DataSet1.ProductoDataTable();
                productos.WriteXml("e:\\productos.xml");
            }
            else
            {
                productos = new DataSet1.ProductoDataTable();
                this.productos.ReadXml("e:\\productos.xml");
            }
        }


        public void guardarProducto(object[] vec)
        {
            productos.Rows.Add(vec);
            productos.WriteXml("e:\\productos.xml");

        }

        public DataSet1.ProductoDataTable getProcutosAll()
        {
            return productos;
        }

        public void editarProducto(object[] producto)
        {
            productos.Rows.Add(producto);
            productos.WriteXml("e:\\productos.xml");

        }

        public object getProductoId(int productosId)
        {
            object[] producto = new object[5];
            return producto;
        }

        public void EliminarEmpleado()
        {

        }

        public int cantidadEmpleados()
        {
            int cantidad = 0;
            cantidad = productos.Count();
            return cantidad;
        }
    }

    //---------------------CLASE CLIENTES-----------------------------------
    public class cClientes
    {

        DataSet1.ClienteDataTable clientes;

        public cClientes()
        {
            cargarClientes();
        }

        public void cargarClientes()
        {
            if (!(File.Exists("e:\\clientes.xml")))
            {
                clientes = new DataSet1.ClienteDataTable();
                clientes.WriteXml("e:\\clientes.xml");
            }
            else
            {
                clientes = new DataSet1.ClienteDataTable();
                this.clientes.ReadXml("e:\\clientes.xml");
            }
        }


        public void guardarCliente(object[] cliente)
        {
            clientes.Rows.Add(cliente);
            clientes.WriteXml("e:\\clientes.xml");

        }

        public DataSet1.ClienteDataTable getProcutosAll()
        {
            return clientes;
        }

        public void editarProducto(object[] producto)
        {
            clientes.Rows.Add(producto);
            clientes.WriteXml("e:\\productos.xml");

        }

        public object getClienteId(int productosId)
        {
            object[] cliente = new object[5];
            return cliente;
        }

        public void EliminarCliente(int clienteId)
        {

        }

        public int cantidadClientes()
        {
            int cantidad = 0;
            cantidad = clientes.Count();
            return cantidad;
        }
    }
}
