using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TreinoForms
{
    class Sorteio
    {
        public static List<Participantes> participantes = new List<Participantes>();

        public static void Salvar()
        {
            FileStream cadastrados = new FileStream("Lista de participantes", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(cadastrados, participantes);

            cadastrados.Close();
        }

        public static void Carregar()
        {
            FileStream cadastrados = new FileStream("Lista de participantes", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            try
            {
                participantes = (List<Participantes>)encoder.Deserialize(cadastrados);
            }
            catch (Exception e)
            {
                participantes = new List<Participantes>();
            }

            cadastrados.Close();
        }
    }
}