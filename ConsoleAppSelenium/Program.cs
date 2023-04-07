using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ConsoleAppSelenium
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Iniciar driver
            // Adicionar caminho do Driver do Chrome
            // O Driver pode ser encontrado em https://www.selenium.dev/documentation/webdriver/getting_started/install_drivers/
            IWebDriver driver = new ChromeDriver(@"\drivers");
            
            // Implicity wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            // Execução ação - Navegar até o site
            driver.Navigate().GoToUrl("https://www.google.com.br");
            
            // Buscar item com essa classe
            IWebElement textBox = driver.FindElement(By.ClassName("gLFyf"));

            // Inserir texto no Input
            textBox.SendKeys("teste");
            
            // Buscar botão de pesquisa
            IWebElement submitBtn = driver.FindElement(By.ClassName("gNO89b"));
            
            // Pressionar o botão para pesquisa
            submitBtn.Click();
            
            // Buscar pelos títulos
            IList<IWebElement> titles = driver.FindElements(By.ClassName("LC20lb"));
            
            // Exibir os 2 primeiros items da lista de títulos
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(titles[i].Text);
            }
            
            // Fechar o navegador
            driver.Quit();
        }
    }


    
}