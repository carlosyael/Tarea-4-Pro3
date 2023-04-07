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
        Citas citas;
        public void IniciarPruebas()
        {
            citas = new();
            citas.EnvioFormularioVacio();
            citas.IntroducirCaracteresErroneos();
            citas.IntroducirCaracteresCorrectos();
        }

        private void EnvioFormularioVacio()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://citas.intrant.gob.do/Turnos/Domini3";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.Id("op1"));
                driver.GetScreenshot().SaveAsFile("./Resultados/citas formulario cita vacio.jpg");
                element.Click();
                driver.GetScreenshot().SaveAsFile("./Resultados/citas resultado envio formulario vacio.jpg");
            }
            finally
            {
                driver.Quit();
            }

        }
        private void IntroducirCaracteresErroneos()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://citas.intrant.gob.do/Turnos/Domini3";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.Name("cedula"));
                element.SendKeys("sffdss");
                element = driver.FindElement(By.Name("telefono"));
                element.SendKeys("ddffgsss");
                element = driver.FindElement(By.Name("fecha"));
                element.SendKeys("ssd");
                driver.GetScreenshot().SaveAsFile("./Resultados/citas insersion caracteres erroneos.jpg");
                element = driver.FindElement(By.Id("op1"));
                element.Click();
                driver.Manage().Window.Maximize();
                driver.GetScreenshot().SaveAsFile("./Resultados/citas resultado envio varacteres erroneo.jpg");
            }
            finally
            {
                driver.Quit();
            }

        }
        private void IntroducirCaracteresCorrectos()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://citas.intrant.gob.do/Turnos/Domini3";
                driver.Manage().Window.Maximize();

                var element = driver.FindElement(By.Name("cedula"));
                element.SendKeys("40212012799");

                element = driver.FindElement(By.Name("fecha"));
                element.SendKeys("09052023");

                element = driver.FindElement(By.Name("correo"));
                element.SendKeys("carlosyael03@hotmail.com");

                
                IWebElement dropdown = driver.FindElement(By.Name("dia"));
                SelectElement select = new SelectElement(dropdown);
                select.SelectByText("03");
                
                 dropdown = driver.FindElement(By.Name("mes"));
                SelectElement select1 = new SelectElement(dropdown);
                select1.SelectByText("AGOSTO");

                dropdown = driver.FindElement(By.Name("ano"));
                SelectElement select2 = new SelectElement(dropdown);
                select2.SelectByText("2001");

                element = driver.FindElement(By.Id("serv4"));
                element.Click();

                element = driver.FindElement(By.Id("turno1"));
                element.Click();

                driver.GetScreenshot().SaveAsFile("./Resultados/citas insersion datos correctos.jpg ");
                element = driver.FindElement(By.Id("op1"));
                element.Click();
                driver.Manage().Window.Maximize();
                driver.GetScreenshot().SaveAsFile("./Resultados/citas resultado envio caracteres correctos.jpg");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
