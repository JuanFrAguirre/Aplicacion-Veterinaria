using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgHernan
{
    class Mascota
    {
        // propiedades autoimplementadas
        public string Nombre { get; set; }
        public bool Sexo { get; set; }
        public int Tipo { get; set; }
        public double Precio { get; set; }

        //---------------------------------------------------
        // constructores
        //constructor sin parametros (inicializa las variables)
        public Mascota()
        {
            Nombre = "";
            Sexo = true;
            Tipo = 0;
            Precio = 0;
        }


        // constructor con parametros, asigna los parametros a las propiedades
        public Mascota(string nombre, bool sexo, int tipo, double precio)
        {
            Nombre = nombre;
            Sexo = sexo;
            Tipo = tipo;
            Precio = precio;
        }

        //---------------------------------------------------
        // metodo para transformar el sexo de Bool a String
        public string cSexo()
        {
            if (Sexo) // si el sexo es true, es porque es macho (porq selecciono el boton de macho)
            {
                return "Macho";
            }
            else
            {
                return "Hembra";
            }
        }
        // metodo para transformar el tipo de Int a String
        public string cTipo()
        {
            switch (Tipo) // al seleccionar una de las opciones, se marca un indice determinado del combobox, lo que nos da un Int, y con ese Int podemos pasarlo a las 3 opciones de texto
            {
                case 1:
                    return "Perro";
                case 2: 
                    return "Gato";
                default: 
                    return "Ave";
            }
        }

        // metodo para mostrar datos
        public string MostrarDatos()
        {
            string mensaje = "-----------------\n" +
                $"Nombre: {Nombre}\n" +
                $"Sexo: {cSexo()}\n" +
                $"Especie: {cTipo()}\n" +
                $"Precio: {Precio}\n" +
                $"-----------------";

            return mensaje;
        }


        






    }
}
