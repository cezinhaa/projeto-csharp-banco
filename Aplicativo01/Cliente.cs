using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo01
{
    internal class Cliente
    {
        public string nome;
        public double saldo;

        public void Creditar(double valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Coloque um valor maior que R$ 0,00");
            }
            this.saldo += valor;
        }
        public void Debitar(double valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Coloque um valor maior que R$ 0,00");
            }
            if (valor > saldo)
            {
                throw new Exception("Você não pode retirar um valor maior que seu saldo");
            }
            this.saldo -= valor;
        }

    }
}
