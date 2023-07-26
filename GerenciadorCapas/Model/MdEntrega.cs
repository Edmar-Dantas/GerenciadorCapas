using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCapas.Model
{
    internal class MdEntrega
    {
        private static int codigo;
        private static int pedido;
        private static string data;
        private static string quantidade;
        private static string situacao;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static int Pedido { get => pedido; set => pedido = value; }
        public static string Data { get => data; set => data = value; }
        public static string Quantidade { get => quantidade; set => quantidade = value; }
        public static string Situacao { get => situacao; set => situacao = value; }
    }
}
