using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OSINT_SEARCHER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            PanelSearchEngine.Visible = false;
            PanelVideoStreaming.Visible = false;
            PanelStudies.Visible = false;
        }

        private void HideSubMenu()
        {
            if(PanelSearchEngine.Visible == true)
            {
                PanelSearchEngine.Visible = false;
            }

            if (PanelVideoStreaming.Visible == true)
            {
                PanelVideoStreaming.Visible = false;
            }

            if (PanelStudies.Visible == true)
            {
                PanelStudies.Visible = false;
            }
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchGoogle(string GoogleQuery)
        {
            Process.Start("https://www.google.com/search?q=" + GoogleQuery);
        }
        private void SearchDDG(string DDGQuery)
        {
            Process.Start("https://duckduckgo.com/?q=" + DDGQuery);
        }
        private void SearchBing(string BingQuery)
        {
            Process.Start("https://www.bing.com/search?q=" + BingQuery);
        }
        private void SearchStartPage(string StartPageQuery)
        {
            Process.Start("https://www.startpage.com/do/search?q=" + StartPageQuery + "&segment=startpage.brave");
        }
        private void SearchYoutube(string YoutubeQuery)
        {
            Process.Start("https://www.youtube.com/results?search_query=" + YoutubeQuery);
        }
        private void SearchYoutubeMobile(string YoutubeMobileQuery)
        {
            Process.Start("https://www.youtube.com/results?search_query=" + YoutubeMobileQuery);
        }
        private void SearchVimeo(string VimeoQuery)
        {
            Process.Start("https://vimeo.com/search?q=" + VimeoQuery);
        }
        private void SearchDailymotion(string DailymotionQuery)
        {
            Process.Start("https://www.dailymotion.com/search/" + DailymotionQuery + "/videos");
        }
        private void SearchWikipedia(string WikipediaQuery)
        {
            Process.Start("https://en.wikipedia.org/w/index.php?search=" + WikipediaQuery + "&title=Special%3ASearch&fulltext=Search&ns0=1");
        }
        private void SearchWolframalfa(string WolframalfaQuery)
        {
            Process.Start("https://www.wolframalpha.com/input/?i=" + WolframalfaQuery);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchGoogle(textBox1.Text);
            HideSubMenu();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                textBox1.Text += "+";
                SendKeys.Send("{END}");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnGoogle.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchDDG(textBox1.Text);
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelSearchEngine);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchBing(textBox1.Text);
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchStartPage(textBox1.Text);
            HideSubMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(PanelVideoStreaming);
        }

        private void PanelSearchEngine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudies_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelStudies);
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            SearchYoutube(textBox1.Text);
            HideSubMenu();
        }

        private void btnYoutubeMobile_Click(object sender, EventArgs e)
        {
            SearchYoutubeMobile(textBox1.Text);
            HideSubMenu();
        }

        private void btnVimeo_Click(object sender, EventArgs e)
        {
            SearchVimeo(textBox1.Text);
            HideSubMenu();
        }

        private void btnDailyMotion_Click(object sender, EventArgs e)
        {
            SearchDailymotion(textBox1.Text);
            HideSubMenu();
        }

        private void btnWikipedia_Click(object sender, EventArgs e)
        {
            SearchWikipedia(textBox1.Text);
            HideSubMenu();
        }

        private void btnWolframAlfa_Click(object sender, EventArgs e)
        {
            SearchWolframalfa(textBox1.Text);
            HideSubMenu();
        }

        private void button32_Click(object sender, EventArgs e)
        {
          
        }
    }
}
