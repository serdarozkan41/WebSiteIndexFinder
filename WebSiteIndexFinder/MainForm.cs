using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSiteIndexFinder
{
    public partial class MainForm : Form
    {
        List<Quest> Quests = new List<Quest>();


        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Quests.Add(new Quest()
            {
                Keyword = "d7ksuper",
                WebSite = "https://apps.apple.com",
                IsPc = true,
            });
            this.LoadQuests();
            Work(Quests.First());
        }

        private void BuAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbWebSite.Text))
            {
                MessageBox.Show("Lütfen Web Site Bilgisini Giriniz.");
                return;
            }

            if (!TbWebSite.Text.Contains("http"))
            {
                MessageBox.Show("Lütfen Geçerli bir adres giriniz. https://ahmet.com gibi.");
                return;
            }


            if (string.IsNullOrEmpty(TbKeyword.Text))
            {
                MessageBox.Show("Lütfen Anahtar Kelime Bilgisini Giriniz.");
                return;
            }

            Quests.Add(new Quest
            {
                IsMobile = RbMobile.Checked,
                IsPc = RbPc.Checked,
                Keyword = TbKeyword.Text,
                WebSite = TbWebSite.Text,
                Status = false
            });

            this.LoadQuests();
        }

        void LoadQuests()
        {
            LvQuests.Items.Clear();

            foreach (var quest in Quests)
            {
                string mobile = "Hayır";
                if (quest.IsMobile)
                {
                    mobile = "Evet";
                }

                string pc = "Hayır";
                if (quest.IsPc)
                {
                    pc = "Evet";
                }

                string status = "Başlamadı";
                if (quest.Status)
                {
                    status = "Başladı";
                }

                string finish = "Hayır";
                if (quest.Finish)
                {
                    finish = "Evet";
                }

                var row = new ListViewItem(new string[] { quest.WebSite, quest.Keyword, mobile, pc, status ,finish});
                row.Tag = quest;
                LvQuests.Items.Add(row);
            }
        }

        private void BuSearch_Click(object sender, EventArgs e)
        {
            if (LvQuests.Items.Count == 0)
            {
                MessageBox.Show("Önce görev ekleyiniz.");
                return;
            }

            var notStartedQuests = Quests.Where(s => !s.Status).ToList();

            foreach (var quest in notStartedQuests)
            {
                this.Work(quest);
            }
        }

        void Work(Quest quest)
        {

            Task.Factory.StartNew(() =>
            {

                Quests.FirstOrDefault(s => s.WebSite == quest.WebSite && s.Keyword == quest.Keyword && s.IsMobile == quest.IsMobile && s.IsPc == quest.IsPc).Status = true;
                this.LoadQuests();

                IWebDriver driver = null;

                if (quest.IsPc)
                {
                    ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"Browsers");
                    service.HideCommandPromptWindow = true;

                    var options = new ChromeOptions();
                    //options.AddArgument("headless");

                    driver = new ChromeDriver(service, options); //<-Add your path
                }

                driver.Navigate().GoToUrl("https://www.google.com");

                IWebElement searchText = driver.FindElement(By.Name("q"));

                searchText.SendKeys(quest.Keyword);
                searchText.Submit();

                IWebElement resultsPanel = driver.FindElement(By.Id("search"));

                ReadOnlyCollection<IWebElement> searchResults = resultsPanel.FindElements(By.XPath(".//a"));

                int index = 1;
                foreach (IWebElement result in searchResults)
                {
                    if (result.GetAttribute("href").Contains(quest.WebSite))
                    {
                        LvResults.Items.Add($"{quest.WebSite} - Sıra: {index}");
                        Quests.FirstOrDefault(s => s.WebSite == quest.WebSite && s.Keyword == quest.Keyword && s.IsMobile == quest.IsMobile && s.IsPc == quest.IsPc).Finish = true;

                        break;
                    }
                    index++;
                }
            });
        }
    }

    public class Quest
    {
        public string WebSite { get; set; }
        public string Keyword { get; set; }
        public bool IsMobile { get; set; }
        public bool IsPc { get; set; }
        public bool Status { get; set; }
        public bool Finish { get; set; }
    }
}
