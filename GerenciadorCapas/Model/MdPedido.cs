using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCapas.Model
{
    internal class MdPedido
    {
        private static int codigo;
        private static string dataInicio;
        private static string dataEntrega;
        private static float valor;
        private static string quantidade;
        private static int fornecedor;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string DataInicio { get => dataInicio; set => dataInicio = value; }
        public static string DataEntrega { get => dataEntrega; set => dataEntrega = value; }
        public static float Valor { get => valor; set => valor = value; }
        public static string Quantidade { get => quantidade; set => quantidade = value; }
        public static int Fornecedor { get => fornecedor; set => fornecedor = value; }
    }
}
