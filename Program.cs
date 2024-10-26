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

using AventStack.ExtentReports;
using CsvHelper;
using Demo_Registration;
=======
// See https://aka.ms/new-console-template for more information
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Globalization;


public class FirstSelenium
{
    public static string DataCSVFile = System.IO.Directory.GetCurrentDirectory();


    static void Main()
    {
<<<<<<< HEAD
        var testDataList = Readfile(DataCSVFile + "\\Data\\data.csv");



        IWebDriver driver = new ChromeDriver();
        ExtentReports extentReports = new ExtentReports();

=======
        CreateReportDirectories();


        IWebDriver driver = new ChromeDriver();
       ExtentReports extentReports = new ExtentReports();
        ExtentSparkReporter reportpath = new ExtentSparkReporter(@"C:\ReportLocation\Report"+DateTime.Now.ToString("-MMddyyyy_hhmmtt")+".html");

        extentReports.AttachReporter(reportpath);

        ExtentTest test = extentReports.CreateTest("Login Test", "This is our first Test Case");
      
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250

        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        test.Log(Status.Info, "Open browser");




        Console.WriteLine("Open Browser");

        driver.Manage().Window.Maximize();
        Console.WriteLine("Browser Maximize");
        test.Log(Status.Info, "Browser Maximize");

<<<<<<< HEAD


        foreach (var Testdata in testDataList)
        {
            driver.FindElement(By.Id("username")).SendKeys(Testdata.username);
            Console.WriteLine("Provide username: " +Testdata.username);
       

            driver.FindElement(By.Id("password")).SendKeys(Testdata.password);
            Console.WriteLine("Provide Password: " +Testdata.password);




            driver.FindElement(By.Id("submit")).Click();
            Console.WriteLine("Hit Submit button");
            try
            {
                driver.FindElement(By.CssSelector(".wp-block-button__link")).Click();
                break;
            }
            catch
            {
                Console.WriteLine("Failed Login");
            }
=======
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
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250
        }



        driver.Quit();




    }
    static List<Testdata> Readfile(string filepath)
    {
        using (var reader = new StreamReader(filepath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
<<<<<<< HEAD
            return new List<Testdata>(csv.GetRecords<Testdata>());

=======
            Console.WriteLine("Failed Login");
            test.Log(Status.Fail, "Login Failed");
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250
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
<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
using AventStack.ExtentReports;
using CsvHelper;
using Demo_Registration;
=======
// See https://aka.ms/new-console-template for more information
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Globalization;


public class FirstSelenium
{
    public static string DataCSVFile = System.IO.Directory.GetCurrentDirectory();


    static void Main()
    {
<<<<<<< HEAD
        var testDataList = Readfile(DataCSVFile + "\\Data\\data.csv");



        IWebDriver driver = new ChromeDriver();
        ExtentReports extentReports = new ExtentReports();

=======
        CreateReportDirectories();


        IWebDriver driver = new ChromeDriver();
       ExtentReports extentReports = new ExtentReports();
        ExtentSparkReporter reportpath = new ExtentSparkReporter(@"C:\ReportLocation\Report"+DateTime.Now.ToString("-MMddyyyy_hhmmtt")+".html");

        extentReports.AttachReporter(reportpath);

        ExtentTest test = extentReports.CreateTest("Login Test", "This is our first Test Case");
      
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250

        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        test.Log(Status.Info, "Open browser");




        Console.WriteLine("Open Browser");

        driver.Manage().Window.Maximize();
        Console.WriteLine("Browser Maximize");
        test.Log(Status.Info, "Browser Maximize");

<<<<<<< HEAD


        foreach (var Testdata in testDataList)
        {
            driver.FindElement(By.Id("username")).SendKeys(Testdata.username);
            Console.WriteLine("Provide username: " +Testdata.username);
       

            driver.FindElement(By.Id("password")).SendKeys(Testdata.password);
            Console.WriteLine("Provide Password: " +Testdata.password);




            driver.FindElement(By.Id("submit")).Click();
            Console.WriteLine("Hit Submit button");
            try
            {
                driver.FindElement(By.CssSelector(".wp-block-button__link")).Click();
                break;
            }
            catch
            {
                Console.WriteLine("Failed Login");
            }
=======
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
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250
        }



        driver.Quit();




    }
    static List<Testdata> Readfile(string filepath)
    {
        using (var reader = new StreamReader(filepath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
<<<<<<< HEAD
            return new List<Testdata>(csv.GetRecords<Testdata>());

=======
            Console.WriteLine("Failed Login");
            test.Log(Status.Fail, "Login Failed");
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250
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

    <<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
using AventStack.ExtentReports;
using CsvHelper;
using Demo_Registration;
=======
// See https://aka.ms/new-console-template for more information
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Globalization;


public class FirstSelenium
{
    public static string DataCSVFile = System.IO.Directory.GetCurrentDirectory();


    static void Main()
    {
<<<<<<< HEAD
        var testDataList = Readfile(DataCSVFile + "\\Data\\data.csv");



        IWebDriver driver = new ChromeDriver();
        ExtentReports extentReports = new ExtentReports();

=======
        CreateReportDirectories();


        IWebDriver driver = new ChromeDriver();
       ExtentReports extentReports = new ExtentReports();
        ExtentSparkReporter reportpath = new ExtentSparkReporter(@"C:\ReportLocation\Report"+DateTime.Now.ToString("-MMddyyyy_hhmmtt")+".html");

        extentReports.AttachReporter(reportpath);

        ExtentTest test = extentReports.CreateTest("Login Test", "This is our first Test Case");
      
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250

        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        test.Log(Status.Info, "Open browser");




        Console.WriteLine("Open Browser");

        driver.Manage().Window.Maximize();
        Console.WriteLine("Browser Maximize");
        test.Log(Status.Info, "Browser Maximize");

<<<<<<< HEAD


        foreach (var Testdata in testDataList)
        {
            driver.FindElement(By.Id("username")).SendKeys(Testdata.username);
            Console.WriteLine("Provide username: " +Testdata.username);
       

            driver.FindElement(By.Id("password")).SendKeys(Testdata.password);
            Console.WriteLine("Provide Password: " +Testdata.password);




            driver.FindElement(By.Id("submit")).Click();
            Console.WriteLine("Hit Submit button");
            try
            {
                driver.FindElement(By.CssSelector(".wp-block-button__link")).Click();
                break;
            }
            catch
            {
                Console.WriteLine("Failed Login");
            }
=======
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
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250
        }



        driver.Quit();




    }
    static List<Testdata> Readfile(string filepath)
    {
        using (var reader = new StreamReader(filepath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
<<<<<<< HEAD
            return new List<Testdata>(csv.GetRecords<Testdata>());

=======
            Console.WriteLine("Failed Login");
            test.Log(Status.Fail, "Login Failed");
>>>>>>> 925d30ddb3750f24e1ebbb337d170cf99adb3250
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
