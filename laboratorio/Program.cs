
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*El programa tendrá que tener estructuras de control. Elaborar una aplicación de consola
con los siguientes datos:
1.Se ingresarán 3 datos nombres, edad, departamento y municipio.
2. Los municipios deberán estar en lasados al departamento seleccionado.
3. Al darle agregar el dato se guardarán en un arregló.
4. Recorrer el arreglo y mostrar la edad.*/



class Persona
{
    public string nombre;
    public int edad;
    public Departamento departamento;
}

class Municipio
{
    public string nombre;
    public Departamento departamento;
}

class Departamento
{
    public string nombre;
    public List<Municipio> municipios;
}

class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, Departamento> departamentos = new Dictionary<string, Departamento>();


        string[] nombresDepartamentos = { "Ahuachapán", "Cabañas", "Chalatenango", "Cuscatlán", "La Libertad", "La Paz", "La Unión", "Morazán", "San Miguel", "San Salvador", "Santa Ana", "San Vicente", "Sonsonate", "Usulután" };
        string[][] nombresMunicipios = {
            new string[] { "Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "Guaymango", "Jujutla", "San Francisco Menéndez" },

            new string[] { "Sensuntepeque", "Dolores", "Guacotecti", "Ilobasco", "Jutiapa", "San Isidro", "Tejutepeque", "Victoria" },

            new string[] { "Chalatenango", "Agua Caliente", "Arcatao", "Azacualpa", "Citalá", "Comalapa", "Concepción Quezaltepeque", "Dulce Nombre de María" },


            new string[] { "Cojutepeque", "Candelaria", "El Carmen", "El Rosario", "Monte San Juan", "Oratorio de Concepción", "San Bartolomé Perulapía", "San Rafael Cedros" },
            new string[] { "Santa Tecla", "Antiguo Cuscatlán", "Chiltiupán", "Ciudad Arce", "Colón", "Comasagua", "Huizúcar", "Jayaque" },
            new string[] { "Zacatecoluca", "Cuyultitán", "El Rosario", "Jerusalén", "Mercedes La Ceiba", "Olocuilta", "Paraíso de Osorio", "San Juan Nonualco" },
            new string[] { "La Unión", "Anamorós", "Bolívar", "Concepción de Oriente", "Conchagua", "El Carmen", "El Sauce", "Intipucá" },
            new string[] { "San Francisco Gotera", "Arambala", "Corinto", "Delicias de Concepción", "El Divisadero", "El Rosario", "Gualococti", "Joateca" },
            new string[] { "San Miguel", "Carolina", "Chapeltique", "Chinameca", "Ciudad Barrios", "Comacarán", "El Tránsito", "Lolotique" },

            new string[] { "San Salvador", "Aguilares", "Apopa", "Ayutuxtepeque", "Cuscatancingo", "Delgado", "Ilopango", "Mejicanos"}
    }   }