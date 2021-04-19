using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;


namespace Analiz.pl
{

    public class Tests
    {
        public IWebDriver driver;
        //SetUp
        //Test 1
        private By _scrolBarPercentOfRyskFirstElement = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[2]/div[2]/div[3]/div[2]/div/div[1]/div[2]/div");
        private By _bar6 = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[2]/div[2]/div[3]/div[2]/div/div[2]/div[92]");
        private By _scrolbarMinFirstPay2element = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[5]/div[1]/div[2]/div/div[1]/div[3]/div");
        private By _barTo100 = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[5]/div[1]/div[2]/div/div[2]/div[28]");
        private By _resultText = By.XPath("//*[@id='fundsQuotationsContainer']/div/p[2]");
        private By _closeButton = By.XPath("/html/body/div[2]/div/div/div/button");
        //test 2
        private By _dropDownListCompanyName = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[1]/div[2]/section");
        private By _dropDownListKategory = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[2]/div[2]/div[1]/div[2]/section");
        private By _kategoryItem = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[2]/div[2]/div[1]/div[2]/section/div/div[4]/div/label/span");
        private By _companyNameItem = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[1]/div[2]/section/div/div/div/div[1]/div/div/div[1]/div/label/span");
        private By _result = By.XPath("/html/body/div[4]/main/h1/span[1]");
        //test 3
        private By _dropDownListWaluta = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/p");
        private By _pln = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[1]/div/label/span");
        private By _aud = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[4]/div/label/span");
        private By _chf = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[5]/div/label/span");
        private By _zar = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[6]/div/label/span");
        private By _cad = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[7]/div/label/span");
        private By _czk = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[8]/div/label/span");
        private By _hkd = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[9]/div/label/span");
        private By _nzd = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[10]/div/label/span");
        private By _sgd = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[11]/div/label/span");
        private By _huf = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[12]/div/label/span");
        private By _gbp = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[13]/div/label/span");
        private By _jpy = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[14]/div/label/span");
        private By _nok = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[15]/div/label/span");
        private By _cny = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div/div[16]/div/label/span");
        private By _kategoryItemAbsoluteReturn = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[2]/div[2]/div[1]/div[2]/section/div/div[3]/div/label/span");
        // test4
        private By _dropDownListGeo = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[2]/div[2]/div[2]/div[2]/section/p");
        private By _moreOptions = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[2]/div[2]/div[2]/div[2]/section/div/div[3]/a");
        private By _bric = By.XPath("/html/body/div[2]/div/div[1]/section/div/div[2]/div/div[1]/div/div[8]/div/input");
        private By _europe = By.XPath("//*[@id='standard']");
        private By _submit = By.CssSelector("#confirmAreaPopup");
        //Test 5
        private By _sholderISF = By.XPath("/html/body/div[4]/main/div/div[2]/div/div[2]/div[2]/div/div[1]/a");
        private By _datePickerFrom = By.XPath("/html/body/main/div[3]/div/div[1]/div[2]/div[1]/div[1]/div[1]/div/div/label[1]/div/input");
        private By _datePickerFromSwitch = By.XPath("/html/body/div[19]/div[1]/table/thead/tr[1]/th[2]");
        private By _datePickerFromSwitchPrev = By.XPath("/html/body/div[19]/div[3]/table/thead/tr/th[1]");
        private By _datePickerFrom2018 = By.XPath("/html/body/div[19]/div[3]/table/tbody/tr/td/span[10]");

        private By _datePickerTo = By.XPath("/html/body/main/div[3]/div/div[1]/div[2]/div[1]/div[1]/div[1]/div/div/label[2]/div/input");
        private By _stopaZwrotu = By.XPath("/html/body/main/div[3]/div/div[1]/div[2]/div[1]/div[1]/div[3]/div/div[2]/span/span/span");
        //Test 6 
        private By _wartJednostkiButton = By.XPath("/html/body/main/div[3]/div/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/label/svg");
        private By _wartJednostkiResult = By.XPath("/html/body/main/div[3]/div/div[1]/div[2]/div[1]/div[1]/div[3]/div/div[2]/span/span/span[1]");



        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.analizy.pl/fundusze-zagraniczne/notowania?&#quotationsFundAbroad");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1 ()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement closeButton = driver.FindElement(_closeButton);
            closeButton.Click();
            Thread.Sleep(1000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement scrolBarFirstElement = driver.FindElement(_scrolBarPercentOfRyskFirstElement);
            IWebElement bar6 = driver.FindElement(_bar6);
            IWebElement scrolbarMinFirstPay2element = driver.FindElement(_scrolbarMinFirstPay2element);
            IWebElement barTo100 = driver.FindElement(_barTo100);
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Actions actions = new Actions(driver);
            actions.DragAndDrop(scrolBarFirstElement, bar6).Build().Perform();
            Thread.Sleep(2000);

            actions.DragAndDrop(scrolbarMinFirstPay2element, barTo100).Build().Perform();
            Thread.Sleep(2000);

            IWebElement resultText = driver.FindElement(_resultText);


            Assert.AreEqual("Brak wyników", resultText.Text);



        }


        [Test]
        public void Test2()
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.analizy.pl/fundusze-zagraniczne/notowania?&#quotationsFundAbroad");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement dropDownListKategory = driver.FindElement(_dropDownListKategory);
            IWebElement dropDownListCompanyName = driver.FindElement(_dropDownListCompanyName);
            IWebElement kategoryItem = driver.FindElement(_kategoryItem);
            IWebElement companyNameItem = driver.FindElement(_companyNameItem);
            IWebElement closeButton = driver.FindElement(_closeButton);


            closeButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            dropDownListKategory.Click();
            Thread.Sleep(1000);
            kategoryItem.Click();
            Thread.Sleep(1000);
            dropDownListCompanyName.Click();
            Thread.Sleep(1000);
            companyNameItem.Click();
            Thread.Sleep(1000);

            IWebElement result = driver.FindElement(_result);
            int wynik = Convert.ToInt32(result.Text);

            if (wynik > 5)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }



            /* SelectElement selectDropDownListKategory = new SelectElement(dropDownListKategory);
             selectDropDownListKategory.SelectByText("D³u¿ne");

             SelectElement selectDropDownListCompanyName = new SelectElement(dropDownListCompanyName);
             selectDropDownListCompanyName.SelectByText("AllianceBernstein");*/

        }

        [Test]
        public void Test3()
        {

            // driver.Navigate().GoToUrl("https://www.analizy.pl/fundusze-zagraniczne/notowania?&#quotationsFundAbroad");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement dropDownListWaluta = driver.FindElement(_dropDownListWaluta);
            IWebElement pln = driver.FindElement(_pln);
            IWebElement aud = driver.FindElement(_aud);
            IWebElement chf = driver.FindElement(_chf);
            IWebElement zar = driver.FindElement(_zar);
            IWebElement cad = driver.FindElement(_cad);
            IWebElement czk = driver.FindElement(_czk);
            IWebElement hkd = driver.FindElement(_hkd);
            IWebElement nzd = driver.FindElement(_nzd);
            IWebElement sgd = driver.FindElement(_sgd);
            IWebElement huf = driver.FindElement(_huf);
            IWebElement gbp = driver.FindElement(_gbp);
            IWebElement jpy = driver.FindElement(_jpy);
            IWebElement nok = driver.FindElement(_nok);
            IWebElement cny = driver.FindElement(_cny);
            IWebElement dropDownListKategory = driver.FindElement(_dropDownListKategory);
            IWebElement kategoryItemAbsoluteReturn = driver.FindElement(_kategoryItemAbsoluteReturn);
            IWebElement result = driver.FindElement(_result);

            IWebElement closeButton = driver.FindElement(_closeButton);


            closeButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            dropDownListWaluta.Click();
            pln.Click();
            Thread.Sleep(2000);
            dropDownListWaluta.Click();
            Thread.Sleep(1000);
            aud.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            chf.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            zar.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            cad.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            czk.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            hkd.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            nzd.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            sgd.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            huf.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            gbp.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            jpy.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            nok.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            cny.Click();
            Thread.Sleep(1000);

            dropDownListKategory.Click();
            Thread.Sleep(1000);
            kategoryItemAbsoluteReturn.Click();

            int wynik = Convert.ToInt32(result.Text);

            if (wynik > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

            // SelectElement selectDropDownListWaluta = new SelectElement(dropDownListWaluta);

            // List<IWebElement> waluta = (List<IWebElement>)dropDownListWaluta.FindElement(By.XPath("/html/body/div[4]/main/div/div[2]/div/div[1]/section[2]/div[2]/div[3]/div[2]/div[2]/div[2]/section/div"));
            /* SelectElement select = new SelectElement(dropDownListWaluta);
             select.SelectByValue( "AUD");*/
            /*foreach (IWebElement walutas in waluta)
            {

                if (waluta.Equals("PLN".....))
                {
                    waluta.SelectElement();
                }
            }*/
        }

        [Test]
        public void Test4()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);





            IWebElement closeButton = driver.FindElement(_closeButton);


            closeButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Thread.Sleep(1000);
            IWebElement dropDownListGeo = driver.FindElement(_dropDownListGeo);
            dropDownListGeo.Click();
            Thread.Sleep(1000);
            IWebElement moreOptions = driver.FindElement(_moreOptions);
            moreOptions.Click();
            Thread.Sleep(1000);

            IWebElement bric = driver.FindElement(_bric);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            bric.Click();
            Thread.Sleep(1000);
            IWebElement europe = driver.FindElement(_europe);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            europe.Click();
            IWebElement submit = driver.FindElement(_submit);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            submit.Click();
            Thread.Sleep(1000);
        }
        [Test]
        public void Test5()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement dropDownListWaluta = driver.FindElement(_dropDownListWaluta);
            IWebElement pln = driver.FindElement(_pln);
            IWebElement aud = driver.FindElement(_aud);
            IWebElement chf = driver.FindElement(_chf);
            IWebElement zar = driver.FindElement(_zar);
            IWebElement cad = driver.FindElement(_cad);
            IWebElement czk = driver.FindElement(_czk);
            IWebElement hkd = driver.FindElement(_hkd);
            IWebElement nzd = driver.FindElement(_nzd);
            IWebElement sgd = driver.FindElement(_sgd);
            IWebElement huf = driver.FindElement(_huf);
            IWebElement gbp = driver.FindElement(_gbp);
            IWebElement jpy = driver.FindElement(_jpy);
            IWebElement nok = driver.FindElement(_nok);
            IWebElement cny = driver.FindElement(_cny);
            IWebElement dropDownListKategory = driver.FindElement(_dropDownListKategory);
            IWebElement kategoryItemAbsoluteReturn = driver.FindElement(_kategoryItemAbsoluteReturn);
            IWebElement result = driver.FindElement(_result);

            IWebElement closeButton = driver.FindElement(_closeButton);


            closeButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            dropDownListWaluta.Click();
            pln.Click();
            Thread.Sleep(2000);
            dropDownListWaluta.Click();
            Thread.Sleep(1000);
            aud.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            chf.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            zar.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            cad.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            czk.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            hkd.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            nzd.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            sgd.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            huf.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            gbp.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            jpy.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            nok.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            cny.Click();
            Thread.Sleep(1000);

            dropDownListKategory.Click();
            Thread.Sleep(1000);
            kategoryItemAbsoluteReturn.Click();
            Thread.Sleep(2000);
            IWebElement sholderIFS = driver.FindElement(_sholderISF);
            sholderIFS.Click();
            Thread.Sleep(2000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            
           
            IWebElement datePickerFrom = driver.FindElement(_datePickerFrom);
            IWebElement datePickerTo = driver.FindElement(_datePickerTo);
            IWebElement stopaZwrotu = driver.FindElement(_stopaZwrotu);

            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('datePickerTermStart').value='2018-02-01'");
            js.ExecuteScript("document.getElementById('datePickerTermEnd').value='2020-12-31'");

            var stopa =Convert.ToInt32(js.ExecuteScript("return arguments[0].value", stopaZwrotu));
            if (stopa > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }


            

        }
        [Test]
        public void Test6()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement dropDownListWaluta = driver.FindElement(_dropDownListWaluta);
            IWebElement pln = driver.FindElement(_pln);
            IWebElement aud = driver.FindElement(_aud);
            IWebElement chf = driver.FindElement(_chf);
            IWebElement zar = driver.FindElement(_zar);
            IWebElement cad = driver.FindElement(_cad);
            IWebElement czk = driver.FindElement(_czk);
            IWebElement hkd = driver.FindElement(_hkd);
            IWebElement nzd = driver.FindElement(_nzd);
            IWebElement sgd = driver.FindElement(_sgd);
            IWebElement huf = driver.FindElement(_huf);
            IWebElement gbp = driver.FindElement(_gbp);
            IWebElement jpy = driver.FindElement(_jpy);
            IWebElement nok = driver.FindElement(_nok);
            IWebElement cny = driver.FindElement(_cny);
            IWebElement dropDownListKategory = driver.FindElement(_dropDownListKategory);
            IWebElement kategoryItemAbsoluteReturn = driver.FindElement(_kategoryItemAbsoluteReturn);
            IWebElement result = driver.FindElement(_result);

            IWebElement closeButton = driver.FindElement(_closeButton);


            closeButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            dropDownListWaluta.Click();
            pln.Click();
            Thread.Sleep(2000);
            dropDownListWaluta.Click();
            Thread.Sleep(1000);
            aud.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            chf.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            zar.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            cad.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            czk.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            hkd.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            nzd.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            sgd.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            huf.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            gbp.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            jpy.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            nok.Click();
            Thread.Sleep(1000);
            dropDownListWaluta.Click();
            cny.Click();
            Thread.Sleep(1000);

            dropDownListKategory.Click();
            Thread.Sleep(1000);
            kategoryItemAbsoluteReturn.Click();
            Thread.Sleep(2000);
            IWebElement sholderIFS = driver.FindElement(_sholderISF);
            sholderIFS.Click();
            Thread.Sleep(2000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


            IWebElement wartJednostkiButton = driver.FindElement(_wartJednostkiButton);
            IWebElement wartJednostkiResult = driver.FindElement(_wartJednostkiResult);

            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('datePickerTermStart').value='2018-02-01'");
            js.ExecuteScript("document.getElementById('datePickerTermEnd').value='2020-12-31'");
            Thread.Sleep(5000);
            wartJednostkiButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            var wartosc = Convert.ToInt32(js.ExecuteScript("return arguments[0].value", wartJednostkiResult));
            if (wartosc > 100)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }


        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }


    }
}