namespace VV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.browser = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.MyBid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlaceBidWhen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(12, 35);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(458, 360);
            this.browser.TabIndex = 0;
            this.browser.Url = new System.Uri("https://www.vakantieveilingen.nl", System.UriKind.Absolute);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bedrag:";
            // 
            // MyBid
            // 
            this.MyBid.Location = new System.Drawing.Point(59, 6);
            this.MyBid.Name = "MyBid";
            this.MyBid.Size = new System.Drawing.Size(89, 20);
            this.MyBid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plaats bod op:";
            // 
            // PlaceBidWhen
            // 
            this.PlaceBidWhen.Location = new System.Drawing.Point(255, 6);
            this.PlaceBidWhen.Name = "PlaceBidWhen";
            this.PlaceBidWhen.Size = new System.Drawing.Size(35, 20);
            this.PlaceBidWhen.TabIndex = 4;
            this.PlaceBidWhen.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "sec voor eind";
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.Location = new System.Drawing.Point(476, 35);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(215, 360);
            this.LogBox.TabIndex = 6;
            this.LogBox.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(609, 11);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(82, 13);
            this.lblTimeLeft.TabIndex = 8;
            this.lblTimeLeft.Text = "0:00:00 - € 0,00";
            this.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 407);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlaceBidWhen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MyBid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browser);
            this.Name = "Form1";
            this.Text = "Vakantieveilingen bieder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MyBid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlaceBidWhen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTimeLeft;
    }
}

