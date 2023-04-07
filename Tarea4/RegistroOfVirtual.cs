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
        RegistroOfVirtual registroOfVirtual;

        public void IniciarPruebas()
        {
            registroOfVirtual = new();
            registroOfVirtual.FormularioVacio();
            registroOfVirtual.InsertarCaracteresErroneos();
            registroOfVirtual.InsertarDatosIncorrectos();
            //registroOfVirtual.InsertarDatosCorrectos();
        }

        private void FormularioVacio()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://ov.intrant.gob.do/#/usuarios?cedu=";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.XPath("//button [@type='submit']"));
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina envio formulario vacio.jpg");
                element.Click();
                driver.Manage().Window.Maximize();
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina validacion formulario vacio.jpg");
            }
            finally
            {
                driver.Quit();
            }
        }

        private void InsertarCaracteresErroneos()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://ov.intrant.gob.do/#/usuarios?cedu=";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.Id("mat-input-5"));
                element.SendKeys("*9+5654+5656");
                element = driver.FindElement(By.Id("mat-input-6"));
                element.SendKeys("dsdx");
                element = driver.FindElement(By.Id("mat-input-7"));
                element.SendKeys("(sds) sfd-wdfs");
                element = driver.FindElement(By.Id("mat-input-0"));
                element.SendKeys("dsdwdsds");
                Thread.Sleep(1000);
                element = driver.FindElement(By.XPath("//button [@type='submit']"));
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina envio caracter Incorrecto.jpg");
                element.Click();
                driver.Manage().Window.Maximize();
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina validacion caracter Incorrecto.jpg");
            }
            finally
            {
                driver.Quit();
            }

        }
        private void InsertarDatosIncorrectos()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://ov.intrant.gob.do/#/usuarios?cedu=";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.Id("mat-input-0"));
                element.SendKeys("40212025799");
                element = driver.FindElement(By.XPath("//button [@type='submit']"));
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina envio formulario Incorrecto.jpg");
                element.Click();
                driver.Manage().Window.Maximize();
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina validacion formulario Incorrecto.jpg");
            }
            finally
            {
                driver.Quit();
            }
        }
        private void InsertarDatosCorrectos()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://ov.intrant.gob.do/#/usuarios?cedu=";
                driver.Manage().Window.Maximize();
                var element = driver.FindElement(By.Id("mat-input-0"));
                element.SendKeys("40212012799");
                Thread.Sleep(1000);
                element = driver.FindElement(By.Id("mat-input-5"));
                element.SendKeys("carlosyael78645321@gmail.com");
                element = driver.FindElement(By.Id("mat-input-6"));
                element.SendKeys("(809) 856-9706");
                element = driver.FindElement(By.Id("mat-input-7"));
                element.SendKeys("(809) 856-9706");
                element = driver.FindElement(By.XPath("//button [@type='']"));
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina envio formulario correcto.jpg");
                element.Click();
                driver.Manage().Window.Maximize();
                driver.GetScreenshot().SaveAsFile("./Resultados/registro oficina validacion formulario correcto.jpg");
            }
            finally
            {
                driver.Quit();
            }
        }

    }
}
