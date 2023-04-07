using System;
using Xunit;

namespace Tarea4
{
    //Clase donde se declaran los diferentes tests
    public class UnitTest1
    {
        // Este m�todo prueba el pago virtual
        [Fact]
        public void TestPagoVirtual()
        {
            // Crea un objeto de la clase PagoVirtual
            PagoVirtual prueba = new();
            // Llama al m�todo IniciarPruebas de la clase PagoVirtual
            prueba.IniciarPruebas();
        }
        // Este m�todo prueba la barra de b�squeda
        [Fact]
        public void TestBarraBusqueda()
        {
            // Crea un objeto de la clase BarraBusqueda
            BarraBusqueda prueba = new();
            // Llama al m�todo IniciarPruebas de la clase BarraBusqueda
            prueba.IniciarPruebas();
        }
        // Este m�todo prueba las citas
        [Fact]
        public void TestCitas()
        {
            // Crea un objeto de la clase Citas
            Citas prueba = new();
            // Llama al m�todo IniciarPruebas de la clase Citas
            prueba.IniciarPruebas();
        }
        // Este m�todo prueba el registro de la oficina virtual
        [Fact]
        public void TestRegistroOficinaVirtual()
        {
            // Crea un objeto de la clase RegistroOfVirtual
            RegistroOfVirtual prueba = new();
            // Llama al m�todo IniciarPruebas de la clase RegistroOfVirtual
            prueba.IniciarPruebas();
        }
        // Este m�todo prueba los ex�menes
        [Fact]
        public void TestExamenes()
        {
            // Crea un objeto de la clase PruebaExamen
            PruebaExamen prueba = new();
            // Llama al m�todo IniciarPruebas de la clase PruebaExamen
            prueba.IniciarPruebas();
        }
    }
}
