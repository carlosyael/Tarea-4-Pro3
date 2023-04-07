using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Tarea4
{
    class BarraBusqueda
    {
        /// <summary>
        /// Este método inicia las pruebas de la barra de búsqueda
        /// </summary>
        public void IniciarPruebas()
        {
            // Prueba introducir un carácter aleatorio en la barra de búsqueda
            IntroducirCaracterAleatorio();
            // Prueba introducir un carácter de búsqueda en la barra de búsqueda
            IntroducirCaracterBusqueda();
            // Prueba dejar la barra de búsqueda vacía
            BusquedaVacia();

        }
        /// <summary>
        /// Este método introduce un carácter aleatorio en la barra de búsqueda y toma capturas de pantalla del resultado
        /// </summary>
        private void IntroducirCaracterAleatorio()
        {
            // Crea un objeto driver para usar el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Abre la página web del Intrant
                driver.Url = "https://www.intrant.gob.do/";
                // Maximiza la ventana del navegador
                driver.Manage().Window.Maximize();
                // Busca el elemento que tiene el nombre "searchword" (la barra de búsqueda)
                var element = driver.FindElement(By.Name("searchword"));
                // Hace clic en el elemento
                element.Click();
                // Escribe un carácter aleatorio en el elemento
                element.SendKeys("wedskfjnfk");
                // Toma una captura de pantalla de la barra de búsqueda con el carácter aleatorio y la guarda en una carpeta llamada "Resultados"
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda Insersion caracteres aleatorios.jpg");
                // Envía el elemento (presiona enter)
                element.Submit();
                // Toma una captura de pantalla del resultado de la búsqueda y la guarda en la misma carpeta
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda resultado caracteres aleatorios.jpg");
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
        /// Este método introduce un carácter de búsqueda en la barra de búsqueda y toma capturas de pantalla del resultado
        /// </summary>
        private void IntroducirCaracterBusqueda()
        {
            // Crea un objeto driver para usar el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Abre la página web del Intrant
                driver.Url = "https://www.intrant.gob.do/";
                // Maximiza la ventana del navegador
                driver.Manage().Window.Maximize();
                // Busca el elemento que tiene el nombre "searchword" (la barra de búsqueda)
                var element = driver.FindElement(By.Name("searchword"));
                // Hace clic en el elemento
                element.Click();
                // Escribe "Licencia categoria 02" en el elemento
                element.SendKeys("Licencia categoria 02");
                // Toma una captura de pantalla de la barra de búsqueda con la búsqueda y la guarda en una carpeta llamada "Resultados"
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda Insersion busqueda.jpg");
                // Envía el elemento (presiona enter)
                element.Submit();
                // Toma una captura de pantalla del resultado de la búsqueda y la guarda en la misma carpeta
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda resultado busqueda.jpg");
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
        /// Este método deja la barra de búsqueda vacía y toma capturas de pantalla del resultado
        /// </summary>
        private void BusquedaVacia()
        {
            // Crea un objeto driver para usar el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Abre la página web del Intrant
                driver.Url = "https://www.intrant.gob.do/";
                // Maximiza la ventana del navegador
                driver.Manage().Window.Maximize();
                // Busca el elemento que tiene el nombre "searchword" (la barra de búsqueda)
                var element = driver.FindElement(By.Name("searchword"));
                // Hace clic en el elemento
                element.Click();
                // No escribe nada en el elemento
                element.SendKeys("");
                // Toma una captura de pantalla de la barra de búsqueda vacía y la guarda en una carpeta llamada "Resultados"
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda Insersion vacia.jpg");
                // Envía el elemento (presiona enter)
                element.Submit();
                // Toma una captura de pantalla del resultado de la búsqueda vacía y la guarda en la misma carpeta
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda resultado busqueda vacia.jpg");
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