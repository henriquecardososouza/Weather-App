using Newtonsoft.Json;
using System.Net;
using Weather_App.Weather.Info;
using System.Text.RegularExpressions;

namespace Weather_App
{
    public partial class FrmMain : Form
    {
        private const string key = "ef0b9bbeb4d546f38d234409230204";
        private string codesFile = Application.StartupPath.Substring(0, Application.StartupPath.IndexOf("\\bin")) + "\\Sources\\WeatherCodes.json";
        private string City { get; set; } = "";
        private string Date { get; set; } = "";
        private WeatherCodes.Rootobject Codes { get; set; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void getWeather()
        {
            using (WebClient web = new())
            {
                this.Date = DateTime.Now.ToString("yyyy-MM-dd");
                this.City = tbBuscar.Text;

                try
                {
                    string url = string.Format("http://api.weatherapi.com/v1/current.json?key={0}&q={1}&aqi=no", FrmMain.key, this.City);
                    var json = web.DownloadString(url);
                    CurrentInfo.Rootobject? currentInfo = JsonConvert.DeserializeObject<CurrentInfo.Rootobject>(json);

                    url = string.Format("http://api.weatherapi.com/v1/astronomy.json?key={0}&q={1}&dt={2}", FrmMain.key, this.City, this.Date);
                    json = web.DownloadString(url);
                    AstronomyInfo.Rootobject? astronomyInfo = JsonConvert.DeserializeObject<AstronomyInfo.Rootobject>(json);

                    if (currentInfo == null)
                    {
                        throw new Exception(null);
                    }

                    if (astronomyInfo == null)
                    {
                        throw new Exception(null);
                    }

                    setInformations(currentInfo, astronomyInfo);
                }

                catch (Exception e)
                {
                    HttpStatusCode? code = null;

                    if (e is WebException we)
                    {
                        if (we.Response != null)
                            code = ((HttpWebResponse)we.Response).StatusCode;
                    }

                    setError(code);
                }
            }

            this.lblBuscar.BackColor = Color.Transparent;
        }

        private void setInformations(CurrentInfo.Rootobject currentInfo, AstronomyInfo.Rootobject astronomyInfo)
        {
            float code = currentInfo.current.condition.code;

            foreach (WeatherCodes.Row c in this.Codes.data.row)
            {
                if (c.code == code)
                {
                    if (currentInfo.current.condition.icon.IndexOf("day") != -1)
                    {
                        this.lblClima.Text = c.day;
                        this.pbIcon.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.IndexOf("\\bin")) + "\\Sources\\Icons\\day\\" + c.icon + ".png");
                        this.pbAstro.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.IndexOf("\\bin")) + "\\Sources\\Icons\\sun.png");
                        this.lblNascer.Text = "Nascer do Sol\n" + astronomyInfo.astronomy.astro.sunrise;
                        this.lblPor.Text = "Pôr do Sol\n" + astronomyInfo.astronomy.astro.sunset;
                        setAstroPosition("day", astronomyInfo);
                    }

                    else
                    {
                        this.lblClima.Text = c.night;
                        this.pbIcon.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.IndexOf("\\bin")) + "\\Sources\\Icons\\night\\" + c.icon + ".png");
                        this.pbAstro.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.IndexOf("\\bin")) + "\\Sources\\Icons\\moon.png");
                        this.lblNascer.Text = "Nascer da Lua\n" + astronomyInfo.astronomy.astro.moonrise;
                        this.lblPor.Text = "Luar\n" + astronomyInfo.astronomy.astro.moonset;
                        setAstroPosition("night", astronomyInfo);
                    }
                }
            }

            this.lblTemp.Text = currentInfo.current.temp_c.ToString("0.00") + " °C";
            this.lblPressao.Text = currentInfo.current.pressure_mb.ToString("0.00");
            this.lblHumidade.Text = currentInfo.current.humidity.ToString();
            this.lblUv.Text = currentInfo.current.uv.ToString("0.00");
            this.lblRajada.Text = currentInfo.current.gust_kph.ToString("0.00");
            this.lblVento.Text = currentInfo.current.wind_kph.ToString("0.00");

            switch (currentInfo.current.wind_dir)
            {
                case "N":
                    {
                        this.lblDirecaoVento.Text = "N: Norte";
                        break;
                    }

                case "NNE":
                    {
                        this.lblDirecaoVento.Text = "NNE: Nor-Nordeste";
                        break;
                    }

                case "NE":
                    {
                        this.lblDirecaoVento.Text = "NE: Nordeste";
                        break;
                    }

                case "ENE":
                    {
                        this.lblDirecaoVento.Text = "ENE: Lés-Nordeste";
                        break;
                    }

                case "E":
                    {
                        this.lblDirecaoVento.Text = "E: Leste";
                        break;
                    }

                case "ESE":
                    {
                        this.lblDirecaoVento.Text = "ESE: Lés-Sudeste";
                        break;
                    }

                case "SE":
                    {
                        this.lblDirecaoVento.Text = "SE: Sudeste";
                        break;
                    }

                case "SSE":
                    {
                        this.lblDirecaoVento.Text = "SSE: Sul-Sudeste";
                        break;
                    }

                case "S":
                    {
                        this.lblDirecaoVento.Text = "S: Sul";
                        break;
                    }

                case "SSW":
                    {
                        this.lblDirecaoVento.Text = "SSO: Sul-Sudoeste";
                        break;
                    }

                case "SW":
                    {
                        this.lblDirecaoVento.Text = "SO: Sudoeste";
                        break;
                    }

                case "WSW":
                    {
                        this.lblDirecaoVento.Text = "OSO: Oés-Sudoste";
                        break;
                    }

                case "W":
                    {
                        this.lblDirecaoVento.Text = "O: Oeste";
                        break;
                    }

                case "WNW":
                    {
                        this.lblDirecaoVento.Text = "ONO: Oés-Noroeste";
                        break;
                    }

                case "NW":
                    {
                        this.lblDirecaoVento.Text = "NO: Noroeste";
                        break;
                    }

                case "NNW":
                    {
                        this.lblDirecaoVento.Text = "NNO: Nor-Noroeste";
                        break;
                    }

                default:
                    {
                        this.lblDirecaoVento.Text = currentInfo.current.wind_dir;
                        break;
                    }
            }

            this.lblWorld.Text = ((currentInfo.location.name + "/" + currentInfo.location.country).Length < 32) ? (currentInfo.location.name + "/" + currentInfo.location.country) : (currentInfo.location.name);

            pnlError.Visible = false;
            pnlTemp.Visible = true;
            pnlItens.Visible = true;
            pnlLocation.Visible = true;
            pnlWind.Visible = true;
            pnlAstro.Visible = true;

            lblLastUpdate.Text = "Ultima Atualização: " + currentInfo.current.last_updated;
        }

        private void setError(HttpStatusCode? code)
        {
            if (code == null)
            {
                lblMessage.Text = "Falha ao obter as infomações";
            }

            else
            {
                switch (code)
                {
                    case HttpStatusCode.BadRequest:
                        {
                            lblMessage.Text = "Cidade não Encontrada";
                            break;
                        }

                    default:
                        {
                            lblMessage.Text = "Serviço não disponível no momento";
                            break;
                        }
                }
            }

            pnlError.Visible = true;
            pnlTemp.Visible = false;
            pnlItens.Visible = false;
            pnlLocation.Visible = false;
            pnlWind.Visible = false;
            pnlAstro.Visible = false;

            lblLastUpdate.Text = "";
        }

        private void setAstroPosition(string time, AstronomyInfo.Rootobject a)
        {
            int barLength = 300;
            int barPosition = 73;

            if (time.Equals("day"))
            {
                string am = a.location.localtime.Substring(11, a.location.localtime.Length - 11);
                string hour = am.Split(":")[0];

                int currentHour = int.Parse(hour);

                am = a.astronomy.astro.sunrise.Substring(0, a.astronomy.astro.sunrise.Length - 3);
                hour = am.Split(":")[0];

                int hourNum = int.Parse(hour);

                am = a.astronomy.astro.sunset.Substring(0, a.astronomy.astro.sunrise.Length - 3);
                hour = am.Split(":")[0];

                int hourNum2 = int.Parse(hour) + 12;

                int finalHour = hourNum2 - hourNum;

                int scale = barLength / finalHour;

                pbAstro.Location = new Point(scale * (currentHour - hourNum) - (pbAstro.Width / 2) + barPosition, pbAstro.Location.Y);
            }

            else
            {
                string am = a.location.localtime.Substring(11, a.location.localtime.Length - 11);
                string hour = am.Split(":")[0];
                int currentHour = int.Parse(hour) + 12;

                am = a.astronomy.astro.moonrise.Substring(0, a.astronomy.astro.moonrise.Length - 3);
                hour = am.Split(":")[0];
                int hourNum = int.Parse(hour);

                am = a.astronomy.astro.moonset.Substring(0, a.astronomy.astro.moonset.Length - 3);
                hour = am.Split(":")[0];
                int hourNum2 = int.Parse(hour) + 12;

                int finalHour = hourNum2 - hourNum;
                int scale = barLength / finalHour;

                pbAstro.Location = new Point(scale * ((currentHour < hourNum) ? (24 - finalHour + hourNum) : (finalHour - hourNum)) - (pbAstro.Width / 2) + barPosition, pbAstro.Location.Y);
            }
        }

        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            this.pnlLineBuscar.BackColor = Color.White;
        }

        private void tbBuscar_Leave(object sender, EventArgs e)
        {
            this.pnlLineBuscar.BackColor = Color.Gray;
        }

        private void lblBuscar_MouseEnter(object sender, EventArgs e)
        {
            this.lblBuscar.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void lblBuscar_MouseLeave(object sender, EventArgs e)
        {
            this.lblBuscar.BackColor = Color.Transparent;
        }

        private void lblBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            this.lblBuscar.Select();

            string message = "";

            if (!this.validateSearch(tbBuscar.Text, out message))
            {
                this.setSearchError(message);
                this.lblBuscar.BackColor = Color.Transparent;
                return;
            }

            getWeather();
        }

        private void lblBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblBuscar_MouseClick(null, null);
            }
        }

        private bool validateSearch(string text, out string message)
        {
            text = text.Trim();

            if (text.Equals(""))
            {
                message = "Empty";
                return false;
            }

            if (!Regex.IsMatch(text, @"[\p{L} ]+$"))
            {
                message = "Not has only letters";
                return false;
            }

            message = "";
            return true;
        }

        private void setSearchError(string message)
        {
            if (message.Equals("Empty"))
            {
                MessageBox.Show("Preencha o campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Utilize apenas letras!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tbBuscar.Text = "";
        }

        private void lblBuscar_Enter(object sender, EventArgs e)
        {
            this.lblBuscar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblBuscar_Leave(object sender, EventArgs e)
        {
            this.lblBuscar.BorderStyle = BorderStyle.None;
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            string obj = File.ReadAllText(this.codesFile);
            this.Codes = JsonConvert.DeserializeObject<WeatherCodes.Rootobject>(obj);

            if (this.Codes != null)
            {

            }
        }
    }
}