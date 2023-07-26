using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCapas.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\edmar.dduarte\source\repos\GerenciadorCapas\GerenciadorCapas\Model\Capasbd.mdf;Integrated Security=True";
        }
    }
}
