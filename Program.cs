// See https://aka.ms/new-console-template for more information
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class FirstSelenium
{
    static void Main()
    {
        CreateReportDirectories();


        IWebDriver driver = new ChromeDriver();
       ExtentReports extentReports = new ExtentReports();
        ExtentSparkReporter reportpath = new ExtentSparkReporter(@"C:\ReportLocation\Report"+DateTime.Now.ToString("-MMddyyyy_hhmmtt")+".html");

        extentReports.AttachReporter(reportpath);

        ExtentTest test = extentReports.CreateTest("Login Test", "This is our first Test Case");
      

        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        test.Log(Status.Info, "Open browser");




        Console.WriteLine("Open Browser");

        driver.Manage().Window.Maximize();
        Console.WriteLine("Browser Maximize");
        test.Log(Status.Info, "Browser Maximize");

        driver.FindElement(By.Id("username")).SendKeys("student");
        Console.WriteLine("Provide username");
        test.Log(Status.Info, "Provide username");

        driver.FindElement(By.Id("password")).SendKeys("Password123");
        Console.WriteLine("Provide Password");
        test.Log(Status.Info, "Provide Password");

        driver.FindElement(By.Id("submit")).Click();
        Console.WriteLine("Hit Submit button");
        test.Log(Status.Info, "Hit Submit button");
        try
        {
            driver.FindElement(By.CssSelector(".wp-block-button__link")).Click();
            test.Log(Status.Pass, "Login Succesfully");
        }
        catch
        {
            Console.WriteLine("Failed Login");
            test.Log(Status.Fail, "Login Failed");
        }


        driver.Quit();
        extentReports.Flush();

    }
    private static void CreateReportDirectories()
    {
        string ReportPath = @"C:\Report-Location";
        if (!Directory.Exists(ReportPath))
        {
            Directory.CreateDirectory(ReportPath);

        }

    }      
   
}
