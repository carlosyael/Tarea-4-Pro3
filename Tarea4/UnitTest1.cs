using System;
using Xunit;

namespace Tarea4
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            PagoVirtual prueba= new();
            prueba.IniciarPruebas();
        }
        [Fact]
        public void Test2()
        {
            BarraBusqueda prueba = new();
            prueba.IniciarPruebas();
        }
        [Fact]
        public void Test3()
        {
            Citas prueba = new();
            prueba.IniciarPruebas();
        }

    }
}
