using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using HtmlAgilityPack;
using Tulpep.NotificationWindow;
using System.IO;

namespace tht_uye_takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("data.base")) { Oku(); }
            CheckForIllegalCrossThreadCalls = false;
        }
        Dictionary<string, Thread> the_listesi = new Dictionary<string, Thread>();
        enum Durum
        {
            Uzakta,
            Mesgul,
            Online
        }
        bool calis = true;
        public void cek(ListViewItem lv)
        {

                while (true) {
                    try
                    {
                        string mesaj_Sayisi = "";
                        string uye_ismi = "";
                        string son_aktivite = "";
                        Uri url = new Uri(lv.SubItems[1].Text);
                        WebClient _wc_ = new WebClient();
                        _wc_.Headers.Add("User-Agent: Other");
                        _wc_.Encoding = Encoding.Default;
                        string h = _wc_.DownloadString(url);
                        HtmlAgilityPack.HtmlDocument _dokuman_ = new HtmlAgilityPack.HtmlDocument();
                        _dokuman_.LoadHtml(h);
                        HtmlNodeCollection _post_icerigi_ = _dokuman_.DocumentNode.SelectNodes("//div[contains(@class, 's-profile-content')]");
                        for (int i = 0; i < _post_icerigi_.Count; i++)
                        {
                            mesaj_Sayisi += _post_icerigi_[i].InnerText;
                            uye_ismi += _post_icerigi_[i].InnerText;
                            son_aktivite += _post_icerigi_[i].InnerText;
                        }
                        mesaj_Sayisi = mesaj_Sayisi.Substring(mesaj_Sayisi.IndexOf("Mesaj Sayısı: ", 0) + "Mesaj Sayısı: ".Length, mesaj_Sayisi.IndexOf("Günlük", mesaj_Sayisi.IndexOf("Mesaj Sayısı: ", 0) + "Mesaj Sayısı: ".Length) - mesaj_Sayisi.IndexOf("Mesaj Sayısı: ", 0) + "Mesaj Sayısı: ".Length);
                        mesaj_Sayisi = mesaj_Sayisi.Replace(mesaj_Sayisi.Substring(mesaj_Sayisi.IndexOf("Günlük") + 1), "").Replace(" G", "");
                        uye_ismi = uye_ismi.Substring(uye_ismi.IndexOf("arat ", 0) + "arat".Length, uye_ismi.IndexOf("üyesinin", uye_ismi.IndexOf("arat ", 0) + "arat".Length) - uye_ismi.IndexOf("arat ", 0) + "arat".Length).Replace("üyesinin", "");
                        son_aktivite = son_aktivite.Substring(son_aktivite.IndexOf("Son Aktivitesi: ", 0) + "Son Aktivitesi: ".Length, son_aktivite.IndexOf("Üyelik", son_aktivite.IndexOf("Son Aktivitesi: ", 0) + "Son Aktivitesi: ".Length) - son_aktivite.IndexOf("Son Aktivitesi: ", 0) + "Son Aktivitesi: ".Length).Replace("Üyelik", "");
                        son_aktivite = son_aktivite.Replace(son_aktivite.Substring(son_aktivite.IndexOf(" tarihi") + 1), "");
                        lv.Text = uye_ismi;
                        if (!the_listesi.ContainsKey(uye_ismi)) { the_listesi.Add(uye_ismi, the); }
                        foreach (ListViewItem l in listView1.Items)
                        {
                            if (url.ToString().Substring(url.ToString().LastIndexOf(@"/") + 1).Replace(".html", "") == l.SubItems[1].Text.Substring(url.ToString().LastIndexOf(@"/") + 1).Replace(".html", ""))
                            {
                                lv.SubItems[3].Text = son_aktivite;
                                msj(l, mesaj_Sayisi);
                                lv.SubItems[2].Text = mesaj_Sayisi;
                                if (!son_aktivite.Contains(" Saat") && !son_aktivite.Contains(" saat")
                                    && !son_aktivite.Contains(" gün") && !son_aktivite.Contains(" Gün") && !son_aktivite.Contains("-"))
                                {
                                    son_aktivite = son_aktivite.Replace("Bir dakika önce", "1");
                                    int sure = int.Parse(son_aktivite.Replace(" Dakika önce", ""));
                                    if (sure <= 5)
                                    {
                                        if (lv.ImageIndex == (int)Durum.Mesgul && checkBox2.Checked)
                                        {
                                            url_s = l.SubItems[1].Text;
                                            Invoke(new force_popup(show_popup),
                                            l.Text + " adlı kullanıcı Online!", "Üye Sayfasına Gitmek İçin Tıkla! "
                                          + l.SubItems[1].Text);

                                        }

                                        lv.ImageIndex = (int)Durum.Online;
                                    }
                                    else if (sure > 5 && sure <= 15)
                                    {
                                        lv.ImageIndex = (int)Durum.Uzakta;
                                    }
                                    else if (sure > 15)
                                    {
                                        lv.ImageIndex = (int)Durum.Mesgul;
                                    }
                                }
                                else { lv.ImageIndex = (int)Durum.Mesgul; }
                            }

                        }
                        Thread.Sleep(Convert.ToInt32(numericUpDown1.Value));
                    }
                    catch (Exception) { }
                   if(calis == false) { break; }
                }

        }
        public delegate void force_popup(string title, string context);
        public void show_popup(string title, string context)
        {
            PopupNotifier pn = new PopupNotifier();
            pn.Click += new EventHandler(tik);
            pn.Image = Image.FromFile("ico.ico");
            pn.TitleText = title;
            pn.ContentText = context;
            pn.ImageSize = new Size(32, 32);
            pn.Popup();
        }
        string url_s = string.Empty;
        public void tik(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url_s);
        }

        public void msj(ListViewItem lvi, string text)
        {
            if (text != lvi.SubItems[2].Text && checkBox1.Checked && lvi.SubItems[2].Text != "N/A")
            {
              url_s = lvi.SubItems[1].Text;
              Invoke(new force_popup(show_popup), 
              lvi.Text + " adlı kullanıcıdan yeni mesaj!", "Üye Sayfasına Gitmek İçin Tıkla! " 
              + lvi.SubItems[1].Text);
               
            }
        }

        Thread the;
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                foreach (ListViewItem lvi in listView1.Items)
                {
                    the = new Thread(() => cek(lvi));
                    the.Start();
                }
                calis = true;
                button2.Enabled = true;
                button1.Enabled = false;
                türkhackteamToolStripMenuItem.Enabled = false;
                hakkındaToolStripMenuItem.Enabled = true;
            }
            
        }
        public void Kaydet()
        {
            if(listView1.Items.Count > 0)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\data.base"))
                    {
                        foreach (ListViewItem item in listView1.Items)
                        {

                            sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}",
                            item.Text, "|",
                            item.SubItems[1].Text, "|",
                            "N/A", "|",
                            "N/A");
                        }
                    }
                }
                catch (Exception) { }
            }
            
        }

        public void Oku()
        {
            try
            {
                string[] satirlar = File.ReadAllLines(Environment.CurrentDirectory + "\\data.base");
                foreach (string satir in satirlar)
                {
                    string[] aytimlar = satir.Split('|');
                    ListViewItem lv = new ListViewItem(aytimlar[0]);
                    lv.SubItems.Add(aytimlar[1]);
                    lv.SubItems.Add(aytimlar[2]);
                    lv.SubItems.Add(aytimlar[3]);
                    listView1.Items.Add(lv);
                }
            }
            catch (Exception) { }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           Kaydet();  
           Environment.Exit(0);
        }

        private void kaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0 && listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0].Text != "N/A")
                {
                    if (the_listesi.Count > 0) {
                        foreach (KeyValuePair<string, Thread> th in the_listesi)
                        {
                            if (th.Key == listView1.SelectedItems[0].Text)
                            {
                                th.Value.Abort();
                                listView1.Items.Remove(listView1.SelectedItems[0]);
                                Kaydet();
                            }
                            button1.Enabled = true;
                            button2.Enabled = false;
                        }
                    } else { listView1.Items.Remove(listView1.SelectedItems[0]); Kaydet(); }
                    
                }
                else if (listView1.SelectedItems[0].Text == "N/A") { listView1.Items.Remove(listView1.SelectedItems[0]); Kaydet(); }
                
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem("N/A");
            lvi.SubItems.Add(Microsoft.VisualBasic.Interaction.InputBox("URL Yazın","Kullanıcı URL", "https://www.turkhackteam.org/members/798025.html", -1,-1));
            lvi.SubItems.Add("N/A");
            lvi.SubItems.Add("N/A");
            listView1.Items.Add(lvi);
            if(button1.Enabled == false) {
                the = new Thread(() => cek(lvi));
                the.Start();
            }
            Kaydet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0) { 
            foreach (KeyValuePair<string, Thread> th in the_listesi)
            {
               
               th.Value.Abort();
                
            }
            calis = false;
            the_listesi.Clear();
            button2.Enabled = false;
            button1.Enabled = true;
           türkhackteamToolStripMenuItem.Enabled = true;
            hakkındaToolStripMenuItem.Enabled = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Hakkinda().Show();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opacity = 100;
            ShowInTaskbar = true;
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            ShowInTaskbar = false;
        }

        private void türkhackteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Hakkinda().Show();
        }

        private void türkhackteamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://turkhackteam.org/");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
