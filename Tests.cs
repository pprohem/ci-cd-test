using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMathCICD
{
    internal class Tests
    {
        [Test]
    public void TestAdicao()
    {
      Equals(8, Program.Adicao(5, 3));
    }

    [Test]
    public void TestSubtracao()
    {
           Equals(3, Program.Subtracao(10, 7));
    }

    [Test]
    public void TestMultiplicacao()
    {
           Equals(24, Program.Multiplicacao(4, 6));
    }

    [Test]
    public void TestDivisao()
    {
            Equals(4, Program.Divisao(20, 5));
    }

    [Test]
    public void TestDivisaoPorZero()
    {
            Equals(() => Program.Divisao(10, 0), Throws.TypeOf<System.DivideByZeroException>());
    }
    }
}
