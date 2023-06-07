
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.Browser;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ben10DownloadAutomater
{

    namespace Ben10DownloadAutomater
    {
        public class Automater
        {
            enum SeleniumTypes { XPath, TagName };
            public void killEdgePrograms()
            {
                foreach (var process in Process.GetProcessesByName("msedge"))
                {
                    process.Kill();
                }
                foreach (var process in Process.GetProcessesByName("msedgedriver"))
                {
                    process.Kill();
                }
            }
            public string runWorker(string URL)
            {
                string driveLink = "NOTHING";
                EdgeOptions edgeOptions = new EdgeOptions();
                edgeOptions.AddArgument("headless");
                EdgeDriver browser = new EdgeDriver(edgeOptions);
                browser.Navigate().GoToUrl(URL);

                Thread.Sleep(10000);
                runButtonClickerXPath(browser, "//*[@id=\"yuidea\"]/input[3]", false, false);
                runButtonClickerXPath(browser, "//*[@id=\"yuidea-generate\"]/a", false, true);
                runButtonClickerXPath(browser, "//*[@id=\"btn6\"]", false, false);
            //browser.SwitchTo().Frame(0);
            // frameSwitcher(browser, 0); btn btn-success btn-lg get-link
            // frameSwitcher(browser);
            // runButtonClickerXPath(browser, "/html/body/div/div/div/span",true);
            //runButtonClickerXPath(browser, "//span[.='Close']");
            // runButtonClickerTagName(browser, "a");
            tryer:
                try
                {
                    IWebElement urlNav = browser.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[6]/a"));
                    /*
                    if(urlNav.Text == "Please wait..." || urlNav.Text == "Getting link...")
                    {
                        goto tryer;
                    }
                    */
                    if (urlNav.Text == "Get Link")
                    {
                        driveLink = urlNav.GetAttribute("href");
                        Console.WriteLine(driveLink);
                        // MessageBox.Show(driveLink);

                    }
                    else
                    {
                        goto tryer;
                    }
                }
                catch (Exception k)
                {
                    k.Source = null;
                    goto tryer;
                }

                browser.Close();
                string finalLink = driveLink.Substring(0, 65) + "&export=download";
                return finalLink;
            }

            private void runButtonClickerXPath(EdgeDriver driver, string XPath, bool switcher, bool scroll)
            {
                Console.WriteLine("Running " + XPath);
                bool isFound = false;
                while (!isFound)
                {
                    if (scroll)
                    {
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript("window.scrollBy(0,350)", "");
                    }
                    Console.WriteLine("Hello from " + XPath);
                    try
                    {
                        IWebElement clickContinueButton = driver.FindElement(By.XPath(XPath));
                        if (clickContinueButton != null)
                        {
                            if (clickContinueButton.Displayed)
                            {
                                clickContinueButton.Click();
                                isFound = true;
                                //MessageBox.Show("Clicked!");
                                break;
                            }
                        }
                        //  MessageBox.Show("Click Button Found!");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        if (switcher)
                        {
                            frameSwitcher(driver);
                        }
                    }
                }
                Thread.Sleep(2000);
            }
            private void frameSwitcher(EdgeDriver driver)
            {
                Console.WriteLine("Running Frame Switch");
                bool isFound = false;
                while (!isFound)
                {
                    Console.WriteLine("Hello from Frame Switch");
                    try
                    {
                        var el = driver.FindElements(By.TagName("iframe"));
                        driver.SwitchTo().Frame(el[0]);
                        isFound = true;
                        Console.WriteLine("Frame Switched");
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                Thread.Sleep(2000);
            }
            private void runButtonClickerTagName(EdgeDriver driver, string tagName)
            {
                bool isFound = false;
                while (!isFound)
                {
                    Console.WriteLine("Hello from loop");
                    try
                    {
                        IWebElement clickContinueButton = driver.FindElement(By.TagName(tagName));
                        if (clickContinueButton != null)
                        {

                            if (clickContinueButton.Displayed)
                            {
                                isFound = true;
                                clickContinueButton.Click();
                                //MessageBox.Show("Clicked!");
                                break;
                            }
                        }
                        //  MessageBox.Show("Click Button Found!");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    Thread.Sleep(2000);
                }
            }

        }

    }
}