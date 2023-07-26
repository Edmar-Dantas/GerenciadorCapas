using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCapas.Model
{
    internal class MdFuncionario
    {
        private static int codigo;
        private static string nome;
        private static string quantidade;
        private static float pagamento;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Quantidade { get => quantidade; set => quantidade = value; }
        public static float Pagamento { get => pagamento; set => pagamento = value; }
    }
}
