using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ben10DownloadAutomater.Ben10DownloadAutomater;
using OpenQA.Selenium;

namespace Ben10DownloadAutomater
{
    public partial class Dashboard : Form
    {
        Automater automater;
        public Dashboard()
        {
            InitializeComponent();
            automater = new Automater();
        }
        static int globalSize = 10;
        int[] episodeNumbers = new int[globalSize];
        int counter = 0;
        string[] finalUrls = new string[globalSize];
        private void getLinks_Click(object sender, EventArgs e)
        {
            string url = urlBox.Text;            
            string all = "";
            for(int i = 0;i<finalUrls.Length;i++)
            {         
                if (episodeNumbers[i]<10)
                {
                    finalUrls[i] = url.Substring(0, 31) + "0" + seasonNumberBox.Text + "E0" + episodeNumbers[i];
                }
                else
                {
                    finalUrls[i] = url.Substring(0, 31) + "0" + seasonNumberBox.Text + "E" + episodeNumbers[i];
                }
                
                all += finalUrls[i] + "\n";
            }
            MessageBox.Show(finalUrls[0]);
            backgroundWorker1.RunWorkerAsync();
        }

        private void EpisodeNumbersBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EpisodeNumbersBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                if(counter<10)
                {
                    try
                    {
                        int k = Int32.Parse(EpisodeNumbersBox.Text);
                        if (!episodeNumbers.Contains<int>(k))
                        {
                            episodeNumbers[counter] = k;
                            EpisodeNumbersBox.Text = "";
                            episodeListLabel.Text += episodeNumbers[counter] + "\n";
                            counter++;
                        }
                        else
                        {
                            MessageBox.Show("Number Already Exists");
                        }
                    }
                    catch (Exception e1)
                    {
                        Console.WriteLine(e1);
                    }      
                }
                else
                {
                    MessageBox.Show("array full");
                }
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            episodeListLabel.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            automater.killEdgePrograms();
            //automater.runWorker(finalUrls[0]);
            string fileName = "Season " + seasonNumberBox.Text + " Links.txt";
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
            for(int i = 0;i<episodeListLabel.Text.Length;i++)
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(automater.runWorker(finalUrls[i]));
                }
            }
        }
    }
}
