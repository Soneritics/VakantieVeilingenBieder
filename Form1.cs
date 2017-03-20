using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VV
{
    public partial class Form1 : Form
    {
        private Timer t;

        public Form1()
        {
            InitializeComponent();
            t = new Timer() { Interval = 250 };
            t.Tick += CheckForBidding;
        }

        private List<String> logs = new List<String>();

        private async void log(string text)
        {
            logs.Insert(0, text);
            LogBox.Lines = logs.ToArray();
        }

        private void placeBid(int bid)
        {
            browser.Document.GetElementById("jsActiveBidInput").SetAttribute("value", bid.ToString());
            browser.Document.GetElementById("jsActiveBidButton").InvokeMember("Click");
        }

        private bool wonTheAuction()
        {
            var htmlCode = String.Empty;

            try
            {
                htmlCode = browser.Document.Body.InnerHtml;
            } catch (Exception e)
            {
                log("Exception: " + e.Message);
            }

            return !htmlCode.Contains("Win jij de volgende veiling?");
        }

        private void CheckForBidding(object sender, EventArgs e)
        {
            var secsLeft = 0;
            var timeString = "00:00:00";
            var currentBid = 0;
            var htmlCode = String.Empty;

            try
            {
                htmlCode = browser.Document.Body.InnerHtml;
            } catch (Exception ex)
            {
                return;
            }

            // Time
            var match = Regex.Match(htmlCode, "<div class=\"relative time-container\">(.*)</div>", RegexOptions.Multiline);
            if (match.Success)
            {
                var timeMatches = Regex.Matches(match.Value, "<span class=\"time-value\">(\\d*)(<span|<\\/span)", RegexOptions.Multiline);
                if (timeMatches.Count == 3)
                {
                    var h = (timeMatches[0] as Match).Groups[1].Value;
                    var m = (timeMatches[1] as Match).Groups[1].Value;
                    var s = (timeMatches[2] as Match).Groups[1].Value;
                    timeString = $"{h}:{m}:{s}";

                    secsLeft = (int.Parse(h) * 3600) + (int.Parse(m) * 60) + int.Parse(s);
                }
            }

            // Price
            match = Regex.Match(htmlCode, "jsMainLotCurrentBid\">(\\d*)</span>");
            if (match.Success)
            {
                currentBid = int.Parse(match.Groups[1].Value);
            }

            // Update UI
            lblTimeLeft.Text = $"{timeString} - € {currentBid},00";

            // Actions
            if (secsLeft == int.Parse(PlaceBidWhen.Text))
            {
                t.Stop();

                var myBid = int.Parse(MyBid.Text);
                if (currentBid >= myBid)
                {
                    log($"No bid placed, as your bid is too low (current bid: {currentBid})");
                } else
                {
                    placeBid(myBid);
                    log("Bid placed");
                }

                System.Threading.Thread.Sleep(1000);
                t.Start();
            } else if (secsLeft == 0)
            {
                t.Stop();
                log("Auction ended.");
                System.Threading.Thread.Sleep(1000);

                if (wonTheAuction())
                {
                    log("Looks like you won the auction!");
                    log("Stopping bidding");
                } else
                {
                    browser.Refresh();
                    log("Refreshing page..");
                    t.Start();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var start = (sender as Button).Text == "Start";

            if (start) {
                (sender as Button).Text = "Stop";
                t.Start();
                log("Started");
            } else {
                (sender as Button).Text = "Start";
                t.Stop();
                log("Stopped");
            }
        }
    }
}
