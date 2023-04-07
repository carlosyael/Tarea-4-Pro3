using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Threading;

namespace Tarea4
{
    class PagoVirtual
    {
        /// <summary>
        /// Este método inicia las pruebas de la página de pago virtual
        /// </summary>
        public void IniciarPruebas()
        {
            // Prueba introducir una cédula incorrecta en el campo de búsqueda
            IntroducirCedulaIncorrecta();
            // Prueba introducir una cédula correcta en el campo de búsqueda
            IntroducirCedulaCorrecta();
            // Prueba introducir un carácter erróneo en el campo de búsqueda
            IntroducirCaracterErroneo();
        }

        /// <summary>
        /// Este método introduce una cédula correcta en el campo de búsqueda y toma capturas de pantalla del resultado
        /// </summary>
        private void IntroducirCedulaCorrecta()
        {
            // Crea un objeto driver para usar el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Abre la página web de pago virtual del Intrant
                driver.Url = "https://consultalicencia.intrant.gob.do/Default?id=4";
                // Maximiza la ventana del navegador
                driver.Manage().Window.Maximize();
                // Busca el elemento que tiene el nombre "cedula" (el campo de búsqueda)
                var element = driver.FindElement(By.Name("cedula"));
                // Escribe una cédula correcta en el elemento
                element.SendKeys("40212012799");
                // Toma una captura de pantalla del campo de búsqueda con la cédula correcta y la guarda en una carpeta llamada "Resultados"
                driver.GetScreenshot().SaveAsFile("./Resultados/pago virtual introducir cedula correcta.jpg");
                // Busca el elemento que tiene el nombre "ctl00$MainContent$btnBuscar" (el botón de buscar)
                element = driver.FindElement(By.Name("ctl00$MainContent$btnBuscar"));
                // Hace clic en el elemento
                element.Click();
                // Toma una captura de pantalla del resultado de la búsqueda y la guarda en la misma carpeta
                driver.GetScreenshot().SaveAsFile("./Resultados/pago virtual validacion cedula correcta.jpg");
            }
            catch (Exception ex)
            {
                // Manejar las posibles excepciones que puedan ocurrir durante la prueba 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Cierra el navegador
                driver.Quit();
            }
        }
        /// <summary>
        /// Este método introduce una cédula incorrecta en el campo de búsqueda y toma capturas de pantalla del resultado
        /// </summary>
        private void IntroducirCedulaIncorrecta()
        {
            // Crea un objeto driver para usar el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Abre la página web de pago virtual del Intrant
                driver.Url = "https://consultalicencia.intrant.gob.do/Default?id=4";
                // Maximiza la ventana del navegador
                driver.Manage().Window.Maximize();
                // Busca el elemento que tiene el nombre "cedula" (el campo de búsqueda)
                var element = driver.FindElement(By.Name("cedula"));
                // Escribe una cédula incorrecta en el elemento
                element.SendKeys("402120799");
                // Toma una captura de pantalla del campo de búsqueda con la cédula incorrecta y la guarda en una carpeta llamada "Resultados"
                driver.GetScreenshot().SaveAsFile("./Resultados/pago virtual introducir cedula Incorrecta.jpg");
                // Busca el elemento que tiene el nombre "ctl00$MainContent$btnBuscar" (el botón de buscar)
                element = driver.FindElement(By.Name("ctl00$MainContent$btnBuscar"));
                // Hace clic en el elemento
                element.Click();
                // Toma una captura de pantalla del resultado de la búsqueda y la guarda en la misma carpeta
                driver.GetScreenshot().SaveAsFile("./Resultados/pago vitual Validacion cedula incorrecta.jpg");
            }
            catch (Exception ex)
            {
                // Manejar las posibles excepciones que puedan ocurrir durante la prueba 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Cierra el navegador
                driver.Quit();
            }
        }
        /// <summary>
        /// Este método introduce un carácter erróneo en el campo de búsqueda y toma capturas de pantalla del resultado
        /// </summary>
        private void IntroducirCaracterErroneo()
        {
            // Crea un objeto driver para usar el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Abre la página web de pago virtual del Intrant
                driver.Url = "https://consultalicencia.intrant.gob.do/Default?id=4";
                // Maximiza la ventana del navegador
                driver.Manage().Window.Maximize();
                // Busca el elemento que tiene el nombre "cedula" (el campo de búsqueda)
                var element = driver.FindElement(By.Name("cedula"));
                // Escribe un carácter erróneo en el elemento
                element.SendKeys("sfdsfdfhghgdf");
                // Toma una captura de pantalla del campo de búsqueda con el carácter erróneo y la guarda en una carpeta llamada "Resultados"
                driver.GetScreenshot().SaveAsFile("./Resultados/pago virtual introducir caracter erroneo.jpg");
                // Busca el elemento que tiene el nombre "ctl00$MainContent$btnBuscar" (el botón de buscar)
                element = driver.FindElement(By.Name("ctl00$MainContent$btnBuscar"));
                // Hace clic en el elemento
                element.Click();
                // Toma una captura de pantalla del resultado de la búsqueda y la guarda en la misma carpeta
                driver.GetScreenshot().SaveAsFile("./Resultados/pago virtual validacion caracter erroneo.jpg");
            }
            catch (Exception ex)
            {
                // Manejar las posibles excepciones que puedan ocurrir durante la prueba 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Cierra el navegador
                driver.Quit();
            }
        }

    }
}
