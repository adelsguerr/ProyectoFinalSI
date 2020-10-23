using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Adelso Guerra

namespace Proyecto_Final_Periodo3.Clases
{
    class claseManejoArchivo
    {
        
        public claseManejoArchivo()
        {
            List<Clases.claseMenu> listaMenu = new List<claseMenu>();
            if (!(File.Exists("archivoMenu.dat"))){
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoMenu.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, listaMenu);
                fs.Close();
            }

            List<Clases.claseUsuarios> listaUsuarios = new List<claseUsuarios>();
            if (!(File.Exists("archivoUsuarios.dat")))
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoUsuarios.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, listaUsuarios);
                fs.Close();
            }
        }

        public List<Clases.claseMenu> cargarMenu()
        {
            List<Clases.claseMenu> listaMenu = new List<Clases.claseMenu>();
            if(File.Exists("archivoMenu.dat")){
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoMenu.dat", FileMode.Open, FileAccess.Read);
                listaMenu = (List<Clases.claseMenu>)formater.Deserialize(fs);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Error al leer el archivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listaMenu;
        }


        public void guardarMenu(List<claseMenu> lista)
        {
            if (File.Exists("archivoMenu.dat"))
            {
                File.Delete("archivoMenu.dat");
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoMenu.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, lista);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar archivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<Clases.claseUsuarios> cargarUsuarios()
        {
            List<Clases.claseUsuarios> listaUsuarios = new List<Clases.claseUsuarios>();
            if (File.Exists("archivoUsuarios.dat"))
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoUsuarios.dat", FileMode.Open, FileAccess.Read);
                listaUsuarios = (List<Clases.claseUsuarios>)formater.Deserialize(fs);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Error al leer el archivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listaUsuarios;
        }

        public void guardarUsuarios(List<Clases.claseUsuarios> lista)
        {
            if (File.Exists("archivoUsuarios.dat"))
            {
                File.Delete("archivoUsuarios.dat");
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoUsuarios.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, lista);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar archivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<Clases.claseOrden> cargarOrden(int numeroMesa)
        {
            List<Clases.claseOrden> orden = new List<claseOrden>();

            if(!File.Exists("archivoMesa" + numeroMesa + ".dat"))
            {
                BinaryFormatter formaterCrear = new BinaryFormatter();
                FileStream fsCrear = new FileStream("archivoMesa" + numeroMesa + ".dat", FileMode.Create, FileAccess.Write);
                formaterCrear.Serialize(fsCrear, orden);
                fsCrear.Close();
            }

            BinaryFormatter formater = new BinaryFormatter();
            FileStream fs = new FileStream("archivoMesa" + numeroMesa + ".dat", FileMode.Open, FileAccess.Read);
            orden = (List<Clases.claseOrden>)formater.Deserialize(fs);
            fs.Close();
             
            return orden;
        }

        public void guardarOrden(List<claseOrden> listOrden, int numeroMesa)
        {
            if (File.Exists("archivoMesa" + numeroMesa + ".dat"))
            {
                File.Delete("archivoMesa" + numeroMesa + ".dat");
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoMesa" + numeroMesa + ".dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, listOrden);
                fs.Close();
            }
            else
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("archivoMesa" + numeroMesa + ".dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, listOrden);
                fs.Close();
            }
        }


        public Clases.claseMesa cargarMesa()
        {
            Clases.claseMesa mesa;

            if (!File.Exists("configuracion.dat"))
            {
                mesa = new claseMesa();
                BinaryFormatter formaterCrear = new BinaryFormatter();
                FileStream fsCrear = new FileStream("configuracion.dat", FileMode.Create, FileAccess.Write);
                formaterCrear.Serialize(fsCrear, mesa);
                fsCrear.Close();
            }

            BinaryFormatter formater = new BinaryFormatter();
            FileStream fs = new FileStream("configuracion.dat", FileMode.Open, FileAccess.Read);
            mesa = (Clases.claseMesa)formater.Deserialize(fs);
            fs.Close();

            return mesa;

        }

        public void guardarMesa(Clases.claseMesa objetoMesa)
        {
            if (File.Exists("configuracion.dat"))
            {
                File.Delete("configuracion.dat");
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("configuracion.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, objetoMesa);
                fs.Close();
            }
            else
            {
                BinaryFormatter formater = new BinaryFormatter();
                FileStream fs = new FileStream("configuracion.dat", FileMode.Create, FileAccess.Write);
                formater.Serialize(fs, objetoMesa);
                fs.Close();
            }
        }

    }
    }

