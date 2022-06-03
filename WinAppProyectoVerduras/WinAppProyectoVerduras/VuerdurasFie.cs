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
    // clase empleados
    public class cEmpleados
    {
        DataSet1.EmpleadoDataTable empleados = new DataSet1.EmpleadoDataTable();

        public cEmpleados()
        {
          
        }
        
        public bool ValidadExisteArchivo()
        {
            bool exise = false;

            if (File.Exists("e:\\empleados.xml"))
            {
                exise = true;
            }
            else
            {
                System.Console.WriteLine("No existe el contenido");
            }

            return exise;
        }

         public void guardarEmpleado(object[] vec)
        {
            if (ValidadExisteArchivo())
            {
                this.empleados.Clear();
                this.empleados.ReadXml("E:\\empleados.xml");
            }     
                empleados.Rows.Add(vec);
                empleados.WriteXml("E:\\empleados.xml");
                System.Console.WriteLine("Guardado Automaticamente");
                
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

        DataSet1.ClienteDataTable clientes = new DataSet1.ClienteDataTable();
        System.Data.DataRow[] vect;
        public cClientes()
        {
                 
        }

        public bool ValidadExisteArchivo()
        {
            bool exise = false;

            if (File.Exists("e:\\clientes.xml"))
            {
                exise = true;
            }
            else
            {
                System.Console.WriteLine("No existe el contenido");
            }

            return exise;
        }

        
        public void guardarCliente(object[] cliente)
        {
            if(ValidadExisteArchivo())
            {
                this.clientes.Clear();
                this.clientes.ReadXml("e:\\clientes.xml");
            }
            clientes.Rows.Add(cliente);
            clientes.WriteXml("e:\\clientes.xml");          

        }

        public DataSet1.ClienteDataTable getClientesAll() // funcion para cargar los datos
        {
                     
            if (ValidadExisteArchivo())
            {
                this.clientes.Clear();
                this.clientes.ReadXml("e:\\clientes.xml");
            }

            return clientes;
        }

        public void editarCliente(object[] cliente) // funcion para editar
        {
            vect[0]["cedula"] = cliente[0];
            vect[0]["nombre"] = cliente[1];
            vect[0]["apellido"] = cliente[2];
            vect[0]["telefono"] = cliente[3];
            vect[0]["direccion"] = cliente[4];
            vect[0]["correo"] = cliente[5];
            vect[0]["descripcion"] = cliente[6];
            vect[0].AcceptChanges();
            clientes.WriteXml("e:\\clientes.xml");
        }

        public object[] getClienteId(string cedula) // funcion para buscar por cédula
        {
            object[] cliente = new object[8];
            if (ValidadExisteArchivo())
            {
                this.clientes.Clear();
                clientes.ReadXml("e:\\clientes.xml");
                
                vect = clientes.Select("cedula ='" + cedula + "'");
                if (vect.Length > 0)
                {
                    cliente[0] = vect[0]["cedula"].ToString();
                    cliente[1] = vect[0]["nombre"].ToString();
                    cliente[2] = vect[0]["apellido"].ToString();
                    cliente[3] = vect[0]["telefono"].ToString();
                    cliente[4] = vect[0]["direccion"].ToString();
                    cliente[5] = vect[0]["correo"].ToString();
                    cliente[6] = vect[0]["descripcion"].ToString();
                }
            }

            return cliente;
        }

        public void EliminarCliente(object[] cliente)
        {
            vect[0]["cedula"] = cliente[0];
            vect[0]["nombre"] = cliente[1];
            vect[0]["apellido"] = cliente[2];
            vect[0]["telefono"] = cliente[3];
            vect[0]["direccion"] = cliente[4];
            vect[0]["correo"] = cliente[5];
            vect[0]["descripcion"] = cliente[6];
            vect[0].Delete();
            clientes.WriteXml("e:\\clientes.xml");
        }


        public bool getClienteCedula(string cedula) // funcion para buscar por cédula
        {
            bool encontrado = false;
            if (ValidadExisteArchivo())
            {
                this.clientes.Clear();
                clientes.ReadXml("e:\\clientes.xml");

                vect = clientes.Select("cedula ='" + cedula + "'");
                if (vect.Length > 0)
                {
                    encontrado = true;
                }
            }

            return encontrado;
        }

        public int cantidadClientes()
        {
            int cantidad = 0;
            cantidad = clientes.Count();
            return cantidad;
        }
    }
}
