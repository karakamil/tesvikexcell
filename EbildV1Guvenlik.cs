using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace tesvik10
{
    public partial class EbildV1Guvenlik : Form
    {
        private object v1driver1;

        public EbildV1Guvenlik()
        {
            InitializeComponent();
        }

        private void btnTmm_Click(object sender, EventArgs e)
        {
            //var v1guvenliksozcugu = ebildirgev1.V1driver.FindElement(By.XPath("//*[@id=\"formA\"]/table/tbody/tr[5]/td/table/tbody/tr[2]/td[2]/img")).GetAttribute();
            //pictureBox1.ImageLocation = ebildirgev1.V1driver.FindElement(By.XPath("//*[@id=\"formA\"]/table/tbody/tr[5]/td/table/tbody/tr[2]/td[2]/img")).Displayed;

            v1guvenliksozcugu.v1guvenlik = txtV1Guvenlik.Text.ToString();
            this.Close();
        }

        private void EbildV1Guvenlik_Load(object sender, EventArgs e)
        {

            var driverPath = Application.StartupPath;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("intl.accept_languages", "tr");
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            var v1driver1 = new ChromeDriver(driverPath, chromeOptions);
            v1driver.v1driver1 = v1driver1;

            //v1driver1.Navigate().GoToUrl("https://ebildirge.sgk.gov.tr/WPEB/amp/loginldap");

            //v1driver1.Navigate().GoToUrl("https://ebildirge.sgk.gov.tr/WPEB/PG");



            //pictureBox1.ImageLocation = v1driver1.FindElement(By.XPath("//*[@id=\"formA\"]/table/tbody/tr[5]/td/table/tbody/tr[2]/td[2]/img")).GetAttribute("");
            //pictureBox1.LoadAsync(imageurl);
            //var request = WebRequest.Create(imageurl);

            //using (var response = request.GetResponse())
            //using (var stream = response.GetResponseStream())
            //{
            //    pictureBox1.Image = Bitmap.FromStream(stream);
            //}



            //v1driver1.Navigate().GoToUrl("https://ebildirge.sgk.gov.tr/WPEB/PG");
            // string Resim = v1driver1.FindElement(By.XPath("/html/body/img")).GetAttribute("src");

            // WebClient wc = new WebClient();
            // wc.DownloadFile(Resim,driverPath);

            // pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\PG.jpg");
            // //Bitmap Resim = v1driver1.FindElement(By.XPath("//*[@id=\"formA\"]/table/tbody/tr[5]/td/table/tbody/tr[2]/td[2]/img")).GetAttribute("src");



            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ////pictureBox1.Image = Resim(v1driver1.FindElement(By.XPath("/html/body/img")).GetAttribute("src"));


            //Bitmap Resim(string Url)

            //{
            //    WebRequest rs = WebRequest.Create(Url);
            //    return (Bitmap)Bitmap.FromStream(rs.GetResponse().GetResponseStream());
            //}

            v1driver1.Navigate().GoToUrl("https://ebildirge.sgk.gov.tr/WPEB/amp/loginldap");
            IWebElement img = v1driver1.FindElement(By.XPath("//*[@id=\"formA\"]/table/tbody/tr[5]/td/table/tbody/tr[2]/td[2]/img"));
            var url = img.GetAttribute("src");
            WebClient downloader = new WebClient();
            v1driver1.GetScreenshot().SaveAsFile("url");
            downloader.DownloadFile(url.jpg, driverPath+"PG.JPG");
            v1driver1.GetScreenshot(WebResponse)
        }
    }
}
