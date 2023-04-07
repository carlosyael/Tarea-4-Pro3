using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
namespace Tarea4
{
    class Citas
    {
        /// <summary>
        /// Método que inicia las pruebas automatizadas del formulario de citas
        /// </summary>
        public void IniciarPruebas()
        {
            // Llamar al método que prueba el envío del formulario vacío
            EnvioFormularioVacio();
            // Llamar al método que prueba el envío del formulario con caracteres erróneos
            IntroducirCaracteresErroneos();
            // Llamar al método que prueba el envío del formulario con caracteres correctos
            IntroducirCaracteresCorrectos();
        }

        /// <summary>
        /// Método que prueba el envío del formulario vacío
        /// </summary>
        private void EnvioFormularioVacio()
        {
            // Crear un driver para el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página del formulario de citas
                driver.Url = "https://citas.intrant.gob.do/Turnos/Domini3";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Buscar el elemento input para enviar el formulario
                var element = driver.FindElement(By.Id("op1"));
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/citas formulario cita vacio.jpg");
                // Hacer clic en el elemento input
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/citas resultado envio formulario vacio.jpg");
            }
            catch (Exception ex)
            {
                // Manejar las posibles excepciones que puedan ocurrir durante la prueba 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Cerrar el navegador
                driver.Quit();
            }
        }

        /// <summary>
        /// Método que prueba el envío del formulario con caracteres erróneos
        /// </summary>
        private void IntroducirCaracteresErroneos()
        {
            // Crear un driver para el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página del formulario de citas
                driver.Url = "https://citas.intrant.gob.do/Turnos/Domini3";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Buscar el elemento input para ingresar la cédula
                var element = driver.FindElement(By.Name("cedula"));
                // Enviar caracteres erróneos al elemento input
                element.SendKeys("sffdss");
                // Buscar el elemento input para ingresar el teléfono
                element = driver.FindElement(By.Name("telefono"));
                // Enviar caracteres erróneos al elemento input
                element.SendKeys("ddffgsss");
                // Buscar el elemento input para ingresar la fecha
                element = driver.FindElement(By.Name("fecha"));
                // Enviar caracteres erróneos al elemento input
                element.SendKeys("ssd");
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/citas insersion caracteres erroneos.jpg");
                // Buscar el elemento input para enviar el formulario
                element = driver.FindElement(By.Id("op1"));
                // Hacer clic en el elemento input
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/citas resultado envio varacteres erroneo.jpg");
            }
            catch (Exception ex)
            {
                // Manejar las posibles excepciones que puedan ocurrir durante la prueba 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Cerrar el navegador 
                driver.Quit();
            }
        }
        /// <summary>
        /// Método que prueba el envío del formulario con caracteres correctos
        /// </summary>
        private void IntroducirCaracteresCorrectos()
        {
            // Crear un driver para el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página del formulario de citas
                driver.Url = "https://citas.intrant.gob.do/Turnos/Domini3";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Buscar el elemento input para ingresar la cédula
                var element = driver.FindElement(By.Name("cedula"));
                // Enviar caracteres correctos al elemento input
                element.SendKeys("40212012799");
                // Buscar el elemento input para ingresar la fecha
                element = driver.FindElement(By.Name("fecha"));
                // Enviar caracteres correctos al elemento input
                element.SendKeys("09052023");
                // Buscar el elemento input para ingresar el correo electrónico
                element = driver.FindElement(By.Name("correo"));
                // Enviar caracteres correctos al elemento input
                element.SendKeys("carlosyael03@hotmail.com");
                // Buscar el elemento select para seleccionar el día de nacimiento
                IWebElement dropdown = driver.FindElement(By.Name("dia"));
                // Crear un objeto SelectElement para manipular el elemento select
                SelectElement select = new SelectElement(dropdown);
                // Seleccionar el día de nacimiento por el texto visible
                select.SelectByText("03");
                // Buscar el elemento select para seleccionar el mes de nacimiento
                dropdown = driver.FindElement(By.Name("mes"));
                // Crear un objeto SelectElement para manipular el elemento select
                SelectElement select1 = new SelectElement(dropdown);
                // Seleccionar el mes de nacimiento por el texto visible
                select1.SelectByText("AGOSTO");
                // Buscar el elemento select para seleccionar el año de nacimiento
                dropdown = driver.FindElement(By.Name("ano"));
                // Crear un objeto SelectElement para manipular el elemento select
                SelectElement select2 = new SelectElement(dropdown);
                // Seleccionar el año de nacimiento por el texto visible
                select2.SelectByText("2001");
                // Buscar el elemento input para seleccionar el servicio de renovación de licencia
                element = driver.FindElement(By.Id("serv4"));
                // Hacer clic en el elemento input
                element.Click();
                // Buscar el elemento input para seleccionar el turno matutino
                element = driver.FindElement(By.Id("turno1"));
                // Hacer clic en el elemento input
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/citas insersion datos correctos.jpg ");
                // Buscar el elemento input para enviar el formulario
                element = driver.FindElement(By.Id("op1"));
                // Hacer clic en el elemento input
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/citas resultado envio caracteres correctos.jpg");
            }
            catch (Exception ex)
            {
                // Manejar las posibles excepciones que puedan ocurrir durante la prueba 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Cerrar el navegador 
                driver.Quit();
            }
        }
    }
}
