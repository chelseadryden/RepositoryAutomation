using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Core
{
    public class SharedMethods
    {
        public IWebDriver driver = new ChromeDriver();

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickButton(string id)
        {
            driver.FindElement(By.Id(id)).Click();
        }

        public void SendKeys(string id, string keys)
        {
            driver.FindElement(By.Id(id)).SendKeys(keys);
        }

        public void SendKeysWithElement(IWebElement webElement, string keys)
        {
            webElement.SendKeys(keys);
        }

        public void SelecFromDropdown(string id, string indexOrText)
        {
            var dropdownElement = driver.FindElement(By.Id(id));

            var dropdown = new SelectElement(dropdownElement);

            bool type = int.TryParse(indexOrText, out int index);

            if (type)
            {
                dropdown.SelectByIndex(index);
            }
            else
            {
                dropdown.SelectByText(indexOrText);
            }
        }

        public void CloseDriver()
        {
            driver.Close();

            //stop the process running
        }
    }
}
