// See https://aka.ms/new-console-template for more information
// stuff

using OpenQA.Selenium.Chrome;   // new ChromeDriver()
using OpenQA.Selenium;          // IWebElement

public class HelloJSP_World {

    public static void Main(String[] args)
    {
        // 3. Selenium WebDriver
        // ------------------------------

        // 3.1 Create a WebDriver user agent
        IWebDriver driver = new ChromeDriver();
        try
        {
            // 3.2 Go to URL
            driver.Navigate().GoToUrl("file:///C:/MyApps/repos/AdnaneConsoleApp1/AdnaneConsoleApp1/web-page.html");
            //driver.Url = "file:///C:/MyApps/repos/AdnaneConsoleApp1/AdnaneConsoleApp1/web-page.html";
            driver.Manage().Window.Maximize();

            // 3.3 Selectors - Fill Form
            IWebElement fname = driver.FindElement(By.Name("fname"));
            IWebElement lname = driver.FindElement(By.Name("lname"));
            IWebElement submitBtn = driver.FindElement(By.TagName("button"));
            IWebElement message = driver.FindElement(By.Id("message"));

            fname.Clear();
            lname.Clear();
            fname.SendKeys("Adnane");
            lname.SendKeys("Stitou");
            submitBtn.Click();

            // 3.4 Submit Form

            // Check Expected Outputs
            Console.WriteLine(driver.Title);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Test Error: " + ex.Message);
        }
        finally
        {
            driver.Quit();
        }
        


        // 2. Use a Method
        // ------------------------------
        //HelloJSP_World a = new HelloJSP_World();
        //a.Adnane(10);


        // 1. Read & Write to Console :)
        // ------------------------------
        //Console.WriteLine("What is your Name ? ");
        //var text = Console.ReadLine();
        //Console.WriteLine("Welcome, " + text + " !!!");
    }


    public HelloJSP_World()
    {
        // Container
    }

    public void Adnane(int i)
    {
        Console.WriteLine("The number you input is: " + i);
    }

}

