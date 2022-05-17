namespace TK_Projekt_2
{
    using System;
    using System.Windows.Controls;
    using System.Windows.Forms;
    using System.Windows.Forms.Integration;

    public partial class MainForm : Form
    {
        private MediaElement uc;

        private bool playing;

        private const string AboutMeLabelText = "Projekt zaliczeniowy\n\nPrzedmiot: Technologie Kognitywne\n\nRok akademicki: 2022\n\nSkład zespołu:\nKarolina Wróbel\nAlicja Wróbel\nWiktor Mendalka";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Create the ElementHost control for hosting the
            // WPF UserControl.
            ElementHost host = new ElementHost
            {
                Dock = DockStyle.Fill
            };

            // Create the WPF UserControl.
            this.uc = new MediaElement
            {
                LoadedBehavior = MediaState.Manual
            };

            // Assign the WPF UserControl to the ElementHost control's
            // Child property.
            host.Child = this.uc;

            // Add the ElementHost control to the form's
            // collection of child controls.
            this.playbackPanel.Controls.Add(host);

            this.aboutLabel.Text = AboutMeLabelText;
            this.Update();
        }

        private void returnVideoButton_Click(object sender, EventArgs e)
        {
            this.videoPanel.Visible = false;
            this.mainPanel.Visible = true;

            stopButton_Click(sender, e);
        }

        private void returnAboutButton_Click(object sender, EventArgs e)
        {
            this.aboutPanel.Visible = false;
            this.mainPanel.Visible = true;
        }

        private void video1Button_Click(object sender, EventArgs e)
        {
            this.ShowVideoPanel(0);
        }

        private void video2Button_Click(object sender, EventArgs e)
        {
            this.ShowVideoPanel(1);
        }

        private void video3Button_Click(object sender, EventArgs e)
        {
            this.ShowVideoPanel(2);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            this.mainPanel.Visible = false;
            this.aboutPanel.Visible = true;
        }

        private void ShowVideoPanel(int index)
        {
            this.mainPanel.Visible = false;
            this.videoPanel.Visible = true;

            var video = VideoData.Videos[index];

            this.uc.Source = video.Uri;
            this.videoInfoLabel.Text = video.Description;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                this.uc.Pause();
                this.startButton.Text = "Odtwórz";
            }
            else
            {
                this.uc.Play();
                this.startButton.Text = "Pauza";
            }

            playing ^= true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            playing = false;

            this.uc.Stop();
            this.startButton.Text = "Odtwórz";
        }
    }
}
