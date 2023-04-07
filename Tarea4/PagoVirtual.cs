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
        PagoVirtual pagoVirtual;
        public void IniciarPruebas()
        {
            pagoVirtual = new();
            pagoVirtual.IntroducirCedulaIncorrecta();
            pagoVirtual.IntroducirCedulaCorrecta();
            pagoVirtual.IntroducirCaracterErroneo();

        }

        private void IntroducirCedulaCorrecta()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://consultalicencia.intrant.gob.do/Default?id=4";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.Name("cedula"));
                element.SendKeys("40212012799");
                driver.GetScreenshot().SaveAsFile("./Resultados/pago virtual introducir cedula correcta.jpg");
                element = driver.FindElement(By.Name("ctl00$MainContent$btnBuscar"));
                element.Click();
                driver.Manage().Window.Maximize();
                driver.GetScreenshot().SaveAsFile("./Resultados/pago virtual validacion cedula correcta.jpg");
            }
            finally
            {
               driver.Quit();                
            }


        }
        private void IntroducirCedulaIncorrecta()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://consultalicencia.intrant.gob.do/Default?id=4";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.Name("cedula"));
                element.SendKeys("402120799");
                driver.GetScreenshot().SaveAsFile("./Resultados/pago virtual introducir cedula Incorrecta.jpg");
                element = driver.FindElement(By.Name("ctl00$MainContent$btnBuscar"));
                element.Click();
                driver.Manage().Window.Maximize();
                driver.GetScreenshot().SaveAsFile("./Resultados/pago vitual Validacion cedula incorrecta.jpg");
            }
            finally
            {
              driver.Quit();
            }
            
        }
        private void IntroducirCaracterErroneo()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://consultalicencia.intrant.gob.do/Default?id=4";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.Name("cedula"));
                element.SendKeys("sfdsfdfhghgdf");
                driver.GetScreenshot().SaveAsFile("./Resultados/pago virtual introducir caracter erroneo.jpg");
                element = driver.FindElement(By.Name("ctl00$MainContent$btnBuscar"));
                element.Click();
                driver.GetScreenshot().SaveAsFile("./Resultados/pago virtual validacion caracter erroneo.jpg");
            }
            finally
            {
                driver.Quit();
            }           
        }

    }
}
