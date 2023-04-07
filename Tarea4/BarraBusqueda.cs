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
        BarraBusqueda barraBusqueda;
        public void IniciarPruebas()
        {
            barraBusqueda = new();
            barraBusqueda.IntroducirCaracterAleatorio();
            barraBusqueda.IntroducirCaracterBusqueda();
            barraBusqueda.BusquedaVacia();

        }
        private void IntroducirCaracterAleatorio()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://www.intrant.gob.do/";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.Name("searchword"));
                element.Click();
                element.SendKeys("wedskfjnfk");
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda Insersion caracteres aleatorios.jpg");
                element.Submit();
                driver.Manage().Window.Maximize();
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda resultado caracteres aleatorios.jpg");
            }
            finally
            {
                driver.Quit();
            }
        }

        private void IntroducirCaracterBusqueda()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://www.intrant.gob.do/";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.Name("searchword"));
                element.Click();
                element.SendKeys("Licencia categoria 02");
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda Insersion busqueda.jpg");
                element.Submit();
                driver.Manage().Window.Maximize();
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda resultado busqueda.jpg");
            }
            finally
            {
                driver.Quit();
            }
        }
        private void BusquedaVacia()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://www.intrant.gob.do/";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.Name("searchword"));
                element.Click();
                element.SendKeys("");
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda Insersion vacia.jpg");
                element.Submit();
                driver.GetScreenshot().SaveAsFile("./Resultados/barra busqueda resultado busqueda vacia.jpg");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}