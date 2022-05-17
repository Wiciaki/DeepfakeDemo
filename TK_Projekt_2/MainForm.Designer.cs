namespace TK_Projekt_2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.videoPanel = new System.Windows.Forms.Panel();
            this.videoInfoLabel = new System.Windows.Forms.Label();
            this.playbackPanel = new System.Windows.Forms.Panel();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.returnVideoButton = new System.Windows.Forms.Button();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.returnAboutButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.video3Button = new System.Windows.Forms.Button();
            this.video2Button = new System.Windows.Forms.Button();
            this.video1Button = new System.Windows.Forms.Button();
            this.videoPanel.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoPanel
            // 
            this.videoPanel.Controls.Add(this.videoInfoLabel);
            this.videoPanel.Controls.Add(this.playbackPanel);
            this.videoPanel.Controls.Add(this.stopButton);
            this.videoPanel.Controls.Add(this.startButton);
            this.videoPanel.Controls.Add(this.returnVideoButton);
            this.videoPanel.Location = new System.Drawing.Point(12, 12);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(364, 426);
            this.videoPanel.TabIndex = 0;
            this.videoPanel.Visible = false;
            // 
            // videoInfoLabel
            // 
            this.videoInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.videoInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoInfoLabel.Location = new System.Drawing.Point(17, 320);
            this.videoInfoLabel.Name = "videoInfoLabel";
            this.videoInfoLabel.Size = new System.Drawing.Size(335, 20);
            this.videoInfoLabel.TabIndex = 2;
            this.videoInfoLabel.Text = "Informacje o filmie";
            this.videoInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playbackPanel
            // 
            this.playbackPanel.Location = new System.Drawing.Point(3, 32);
            this.playbackPanel.Name = "playbackPanel";
            this.playbackPanel.Size = new System.Drawing.Size(358, 295);
            this.playbackPanel.TabIndex = 1;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(199, 386);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(77, 386);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Odtwórz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // returnVideoButton
            // 
            this.returnVideoButton.Location = new System.Drawing.Point(3, 3);
            this.returnVideoButton.Name = "returnVideoButton";
            this.returnVideoButton.Size = new System.Drawing.Size(75, 23);
            this.returnVideoButton.TabIndex = 0;
            this.returnVideoButton.Text = "Wróć";
            this.returnVideoButton.UseVisualStyleBackColor = true;
            this.returnVideoButton.Click += new System.EventHandler(this.returnVideoButton_Click);
            // 
            // aboutPanel
            // 
            this.aboutPanel.Controls.Add(this.aboutLabel);
            this.aboutPanel.Controls.Add(this.returnAboutButton);
            this.aboutPanel.Location = new System.Drawing.Point(12, 12);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(364, 426);
            this.aboutPanel.TabIndex = 1;
            this.aboutPanel.Visible = false;
            // 
            // aboutLabel
            // 
            this.aboutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(74, 87);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(226, 225);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Projekt zaliczeniowy\r\n\r\nPrzedmiot: Technologie Kognitywne\r\n\r\nRok akademicki: 2022" +
    "\r\n\r\nSkład zespołu:\r\nKarolina Wróbel\r\nAlicja Wróbel\r\nWiktor Mendalka";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnAboutButton
            // 
            this.returnAboutButton.Location = new System.Drawing.Point(3, 3);
            this.returnAboutButton.Name = "returnAboutButton";
            this.returnAboutButton.Size = new System.Drawing.Size(75, 23);
            this.returnAboutButton.TabIndex = 0;
            this.returnAboutButton.Text = "Wróć";
            this.returnAboutButton.UseVisualStyleBackColor = true;
            this.returnAboutButton.Click += new System.EventHandler(this.returnAboutButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.mainMenuLabel);
            this.mainPanel.Controls.Add(this.aboutButton);
            this.mainPanel.Controls.Add(this.video3Button);
            this.mainPanel.Controls.Add(this.video2Button);
            this.mainPanel.Controls.Add(this.video1Button);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(364, 426);
            this.mainPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kliknij i sprawdź!\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zastanawiałeś się kiedyś, jak WYGLĄDA znana poezja\r\nczytana USTAMI jej własnego a" +
    "utora?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.Location = new System.Drawing.Point(39, 32);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(293, 33);
            this.mainMenuLabel.TabIndex = 4;
            this.mainMenuLabel.Text = "Wirtualna Biblioteka";
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(98, 357);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(176, 23);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "O nas";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // video3Button
            // 
            this.video3Button.Location = new System.Drawing.Point(98, 289);
            this.video3Button.Name = "video3Button";
            this.video3Button.Size = new System.Drawing.Size(176, 23);
            this.video3Button.TabIndex = 2;
            this.video3Button.Text = "Maria Pawlikowska-Jasnorzewska";
            this.video3Button.UseVisualStyleBackColor = true;
            this.video3Button.Click += new System.EventHandler(this.video3Button_Click);
            // 
            // video2Button
            // 
            this.video2Button.Location = new System.Drawing.Point(98, 260);
            this.video2Button.Name = "video2Button";
            this.video2Button.Size = new System.Drawing.Size(176, 23);
            this.video2Button.TabIndex = 1;
            this.video2Button.Text = "Juliusz Słowacki";
            this.video2Button.UseVisualStyleBackColor = true;
            this.video2Button.Click += new System.EventHandler(this.video2Button_Click);
            // 
            // video1Button
            // 
            this.video1Button.Location = new System.Drawing.Point(98, 231);
            this.video1Button.Name = "video1Button";
            this.video1Button.Size = new System.Drawing.Size(176, 23);
            this.video1Button.TabIndex = 0;
            this.video1Button.Text = "Cyprian Kamil Norwid";
            this.video1Button.UseVisualStyleBackColor = true;
            this.video1Button.Click += new System.EventHandler(this.video1Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.videoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Edukacyjny deepfake";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.videoPanel.ResumeLayout(false);
            this.aboutPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.Label videoInfoLabel;
        private System.Windows.Forms.Panel playbackPanel;
        private System.Windows.Forms.Button returnVideoButton;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Button returnAboutButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button video3Button;
        private System.Windows.Forms.Button video2Button;
        private System.Windows.Forms.Button video1Button;
        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

