using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;

namespace IssueObserver
{
    using Worker;

    public partial class Window : Form
    {
        private Observer _observer;

        public Window()
        {
            InitializeComponent();
        }

        private async void btnConfig_Click(object sender, EventArgs e)
        {
            if (dlgConfig.ShowDialog() != DialogResult.OK) return;

            using StreamReader reader = new(dlgConfig.OpenFile());
            FileIniDataParser parser = new();
            IniData iniData = parser.ReadData(reader);
            try
            {
                _observer = await LoadObserver(iniData);
                txtConfig.Text = dlgConfig.SafeFileName;
                btnWatch.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static async Task<Observer> LoadObserver(IniData data)
        {
            int interval = int.Parse(data["Observer"]["Interval"]);
            Target target = new(data["Target"]);
            Fetcher fetcher = new(target);
            await fetcher.Authorize(data["Authorization"]["Token"]);
            Mailer mailer = new(data["Mailer"]);
            Observer observer = new(interval, fetcher, mailer);

            return observer;
        }

        private async void btnWatch_Click(object sender, EventArgs e)
        {
            if (_observer.Enabled)
            {
                _observer.Stop();
                btnConfig.Enabled = true;
                btnWatch.Text = "Watch";
            }
            else
            {
                btnConfig.Enabled = false;
                btnWatch.Enabled = false;
                await _observer.Watch();
                btnWatch.Text = "Unwatch";
                btnWatch.Enabled = true;
            }
        }
    }
}
