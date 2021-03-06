using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SpecFlowProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.LeaguesPages
{
    internal class ChampionLeague : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[text()='Scores & Fixtures']")]
        private IWebElement goToScoresAndFixtures;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='previous']")]
        private IWebElement goToPrevious;

        [FindsBy(How = How.XPath, Using = "//a[@href='/sport/football/champions-league/scores-fixtures/2021-09']")]
        private IWebElement selectSeptembet;




        public void ClickSelectJuly() { selectSeptembet.Click(); }

        public void ClickGoToPrevious() { goToPrevious.Click(); }

        public void ClickOnGoToScoresAndFixtures() { goToScoresAndFixtures.Click(); }

        public ChampionLeague(WebDriver driver) : base(driver) { }

    }
}
