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
    class PruebaExamen
    {

        //metodo de inicio de prueba
        public void IniciarPruebas()
        {
            
            IniciarPruebaCat02();
            IniciarPruebaMotocicletas();
            IniciarPruebaVehiculosPesados();

        }

        #region Pruebas
        /// <summary>
        /// Método que inicia la prueba automatizada de un examen de categoría 02
        /// </summary>
        private void IniciarPruebaCat02()
        {
            // Crear un driver para el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página de login de la oficina virtual
                driver.Url = "https://ov.intrant.gob.do/#/login";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/prueba examen login oficina virtual.jpg");
                // Buscar el elemento input para ingresar el usuario
                var element = driver.FindElement(By.XPath("/html/body/app-root/login/div/div/div[2]/div[1]/mat-card/mat-card-content/form/mat-form-field/div/div[1]/div/input"));
                // Enviar el usuario al elemento input
                element.SendKeys("40212012799");
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/prueba examen ingreso credenciales oficina virtual.jpg");
                // Buscar el elemento button para iniciar sesión
                element = driver.FindElement(By.XPath("/html/body/app-root/login/div/div/div[2]/div[1]/mat-card/mat-card-actions/button[2]"));
                // Hacer clic en el elemento button
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/prueba examen inicio oficina virtual.jpg");
                // Navegar a la página de inicio de los exámenes
                driver.Url = "https://examen.intrant.gob.do/Home/Probar?token=8dd34b1c-24bb-4b24-9179-842db45e88bd&manual=0";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/prueba examen inicio examenes.jpg");
                // Buscar el elemento <a> para iniciar el examen de categoría 02
                element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/p/a"));
                // Hacer clic en el elemento <a>
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/prueba examen inicio examen cat 02.jpg");
                // Buscar el elemento input para iniciar la primera pregunta del examen
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/form/div[5]/div[2]/input"));
                // Hacer clic en el elemento input
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/prueba examen primera pregunta examen cat 02.jpg");
                // Buscar los elementos input que contienen las opciones de respuesta
                var elementList = driver.FindElements(By.Name("respo"));
                // Seleccionar el segundo elemento input de la lista (el que tiene el índice 1)
                element = elementList.ElementAt(1);
            }
            catch (Exception ex)
            {
                // Manejar las posibles excepciones que puedan ocurrir durante la prueba 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }
        /// <summary>
        /// Método que inicia la prueba automatizada de un examen de motocicletas
        /// </summary>
        private void IniciarPruebaMotocicletas()
        {
            // Crear un driver para el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página de login de la oficina virtual
                driver.Url = "https://ov.intrant.gob.do/#/login";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Buscar el elemento input para ingresar el usuario
                var element = driver.FindElement(By.XPath("/html/body/app-root/login/div/div/div[2]/div[1]/mat-card/mat-card-content/form/mat-form-field/div/div[1]/div/input"));
                // Enviar el usuario al elemento input
                element.SendKeys("40212012799");
                // Buscar el elemento button para iniciar sesión
                element = driver.FindElement(By.XPath("/html/body/app-root/login/div/div/div[2]/div[1]/mat-card/mat-card-actions/button[2]"));
                // Hacer clic en el elemento button
                element.Click();
                // Navegar a la página de inicio de los exámenes
                driver.Url = "https://examen.intrant.gob.do/Home/Probar?token=8dd34b1c-24bb-4b24-9179-842db45e88bd&manual=0";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Buscar el elemento <a> para iniciar el examen de motocicletas
                element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/p/a"));
                // Hacer clic en el elemento <a>
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/prueba examen inicio examen motocicletas.jpg");
                // Buscar el elemento input para iniciar la primera pregunta del examen
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/form/div[5]/div[2]/input"));
                // Hacer clic en el elemento input
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/prueba examen primera pregunta examen motocicletas.jpg");
                // Buscar los elementos input que contienen las opciones de respuesta
                var elementList = driver.FindElements(By.Name("respo"));
                // Seleccionar el segundo elemento input de la lista (el que tiene el índice 1)
                element = elementList.ElementAt(1);
                // Hacer clic en el elemento input
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/prueba examen respuesta primera pregunta motocicletas.jpg");
            }
            catch (Exception ex)
            {
                // Manejar las posibles excepciones que puedan ocurrir durante la prueba 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }
        /// <summary>
        /// Método que inicia la prueba automatizada de un examen de vehículos pesados
        /// </summary>
        private void IniciarPruebaVehiculosPesados()
        {
            // Crear un driver para el navegador Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página de login de la oficina virtual
                driver.Url = "https://ov.intrant.gob.do/#/login";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Buscar el elemento input para ingresar el usuario
                var element = driver.FindElement(By.XPath("/html/body/app-root/login/div/div/div[2]/div[1]/mat-card/mat-card-content/form/mat-form-field/div/div[1]/div/input"));
                // Enviar el usuario al elemento input
                element.SendKeys("40212012799");
                // Buscar el elemento button para iniciar sesión
                element = driver.FindElement(By.XPath("/html/body/app-root/login/div/div/div[2]/div[1]/mat-card/mat-card-actions/button[2]"));
                // Hacer clic en el elemento button
                element.Click();
                // Navegar a la página de inicio de los exámenes
                driver.Url = "https://examen.intrant.gob.do/Home/Probar?token=8dd34b1c-24bb-4b24-9179-842db45e88bd&manual=0";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Buscar el elemento <a> para iniciar el examen de vehículos pesados
                element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/p/a"));
                // Hacer clic en el elemento <a>
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/prueba examen inicio examen vehiculos pesados.jpg");
                // Buscar el elemento input para iniciar la primera pregunta del examen
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/form/div[5]/div[2]/input"));
                // Hacer clic en el elemento input
                element.Click();
                // Tomar una captura de pantalla y guardarla en la carpeta Resultados
                driver.GetScreenshot().SaveAsFile("./Resultados/prueba examen primera pregunta examen vehiculos pesados.jpg");
                // Buscar los elementos input que contienen las opciones de respuesta
                var elementList = driver.FindElements(By.Name("respo"));
                // Seleccionar el segundo elemento input de la lista (el que tiene el índice 1)
                element = elementList.ElementAt(1);
                // Hacer clic en el elemento input
                element.Click();
            }
            catch (Exception ex)
            {
                // Manejar las posibles excepciones que puedan ocurrir durante la prueba 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }
        #endregion
    }
}
