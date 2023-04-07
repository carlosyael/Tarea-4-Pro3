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
    public class RegistroOfVirtual
    {
        /// <summary>
        /// Método que inicia las pruebas automatizadas de un formulario de registro de oficina
        /// </summary>
        public void IniciarPruebas()
        {
            // Llamar al método que prueba el envío del formulario vacío
            FormularioVacio();
            // Llamar al método que prueba el envío del formulario con caracteres erróneos
            InsertarCaracteresErroneos();
            // Llamar al método que prueba el envío del formulario con datos incorrectos
            InsertarDatosIncorrectos();
            // Llamar al método que prueba el envío del formulario con datos correctos
            InsertarDatosCorrectos();
        }

        /// <summary>
        /// Método que prueba el envío del formulario vacío
        /// </summary>
        private void FormularioVacio()
        {
            // Crear un driver para el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página del formulario de registro de oficina
                driver.Url = "https://ov.intrant.gob.do/#/usuarios?cedu=";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Buscar el elemento button para enviar el formulario
                var element = driver.FindElement(By.XPath("//button [@type='submit']"));
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina envio formulario vacio.jpg");
                // Hacer clic en el elemento button
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina validacion formulario vacio.jpg");
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
        private void InsertarCaracteresErroneos()
        {
            // Crear un driver para el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página del formulario de registro de oficina
                driver.Url = "https://ov.intrant.gob.do/#/usuarios?cedu=";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Buscar el elemento input para ingresar la cédula
                var element = driver.FindElement(By.Id("mat-input-5"));
                // Enviar caracteres erróneos al elemento input
                element.SendKeys("*9+5654+5656");
                // Buscar el elemento input para ingresar el nombre
                element = driver.FindElement(By.Id("mat-input-6"));
                // Enviar caracteres erróneos al elemento input
                element.SendKeys("dsdx");
                // Buscar el elemento input para ingresar el teléfono
                element = driver.FindElement(By.Id("mat-input-7"));
                // Enviar caracteres erróneos al elemento input
                element.SendKeys("(sds) sfd-wdfs");
                // Buscar el elemento input para ingresar el correo electrónico
                element = driver.FindElement(By.Id("mat-input-0"));
                // Enviar caracteres erróneos al elemento input
                element.SendKeys("dsdwdsds");
                // Esperar un segundo para que se carguen los datos
                Thread.Sleep(1000);
                // Buscar el elemento button para enviar el formulario
                element = driver.FindElement(By.XPath("//button [@type='submit']"));
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina envio caracter Incorrecto.jpg");
                // Hacer clic en el elemento button
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina validacion caracter Incorrecto.jpg");
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
        /// Método que prueba el envío del formulario con datos incorrectos
        /// </summary>
        private void InsertarDatosIncorrectos()
        {
            // Crear un driver para el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página del formulario de registro de oficina
                driver.Url = "https://ov.intrant.gob.do/#/usuarios?cedu=";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Buscar el elemento input para ingresar la cédula
                var element = driver.FindElement(By.Id("mat-input-0"));
                // Enviar datos incorrectos al elemento input
                element.SendKeys("40212025799");
                // Buscar el elemento button para enviar el formulario
                element = driver.FindElement(By.XPath("//button [@type='submit']"));
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina envio formulario Incorrecto.jpg");
                // Hacer clic en el elemento button
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina validacion formulario Incorrecto.jpg");
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
        /// Método que prueba el envío del formulario con datos correctos
        /// </summary>
        private void InsertarDatosCorrectos()
        {
            // Crear un driver para el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página del formulario de registro de oficina
                driver.Url = "https://ov.intrant.gob.do/#/usuarios?cedu=";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Buscar el elemento input para ingresar la cédula
                var element = driver.FindElement(By.Id("mat-input-0"));
                // Enviar datos correctos al elemento input
                element.SendKeys("40212012799");
                // Esperar un segundo para que se carguen los datos
                Thread.Sleep(1000);
                // Buscar el elemento input para ingresar el correo electrónico
                element = driver.FindElement(By.Id("mat-input-5"));
                // Enviar datos correctos al elemento input
                element.SendKeys("carlosyael78645321@gmail.com");
                // Buscar el elemento input para ingresar el teléfono
                element = driver.FindElement(By.Id("mat-input-6"));
                // Enviar datos correctos al elemento input
                element.SendKeys("(809) 856-9706");
                // Buscar el elemento input para confirmar el teléfono
                element = driver.FindElement(By.Id("mat-input-7"));
                // Enviar datos correctos al elemento input
                element.SendKeys("(809) 856-9706");
                // Buscar el elemento button para enviar el formulario
                element = driver.FindElement(By.XPath("//button [@type='submit']"));
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina envio formulario correcto.jpg");
                // Hacer clic en el elemento button
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina validacion formulario correcto.jpg");
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
