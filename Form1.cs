using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Volt
{
    public partial class frmapi : Form
    {
        private JObject m_json;
        public frmapi()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            //Incializa List View
            lvwethinfo.View = View.Details;
            lvwethinfo.FullRowSelect = true;
            lvwethinfo.GridLines = true;

            lvwethinfo.Columns.Add("", 100, HorizontalAlignment.Left);
            lvwethinfo.Columns.Add("", 220, HorizontalAlignment.Left);
        }

        private void GetJsonData()
        {
            Uri urlservice = new Uri("http://192.168.0.52/status.json");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlservice);

            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;

            NetworkCredential myNetworkCredential = new NetworkCredential("admin", "voltvolt");
            CredentialCache devcredential = new CredentialCache();
            devcredential.Add(urlservice, "Basic", myNetworkCredential);

            // Set credentials to use for this request.
            request.PreAuthenticate = true;
            request.Credentials = devcredential;

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
               

                if(response.StatusCode.ToString().Equals("OK"))
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                    string pagedata = readStream.ReadToEnd();

                    m_json = JObject.Parse(pagedata);
                    readStream.Close();

                    UpdateListView();
                    UpdateSensors();
                    UpdateStatusTomada();
                }

                response.Close();
                
            }
            catch (Exception ext)
            {
                lblstatus.Text = "Erro.: " + ext.Message;
            }
        }

        private void UpdateListView()
        {
            lvwethinfo.Items.Clear();

            ListViewItem item1 = new ListViewItem("Host", 0);
            item1.SubItems.Add(m_json.GetValue("devhost").ToString());

            ListViewItem item2 = new ListViewItem("MAC Address", 1);
            item2.SubItems.Add(m_json.GetValue("devmac").ToString());

            ListViewItem item3 = new ListViewItem("IP", 2);
            item3.SubItems.Add(m_json.GetValue("devip").ToString());

            ListViewItem item4 = new ListViewItem("Mascara de Subrede", 3);
            item4.SubItems.Add(m_json.GetValue("devmask").ToString());

            ListViewItem item5 = new ListViewItem("Gateway", 4);
            item5.SubItems.Add(m_json.GetValue("devgtw").ToString());

            ListViewItem item6 = new ListViewItem("DNS Primário", 5);
            item6.SubItems.Add(m_json.GetValue("devdns1").ToString());

            ListViewItem item7 = new ListViewItem("DNS Secundário", 6);
            item7.SubItems.Add(m_json.GetValue("devdns2").ToString());

            lvwethinfo.Items.AddRange(new ListViewItem[] { item1, item2,item3,item4,item5,item6,item7 });

        }

        private void SetStatusTomada(int _tomada)
        {
            int b0 = _tomada - 1;
            string strstatus = "poe=" + _tomada.ToString() + "&sts=" + (m_json.GetValue("ac" + b0.ToString()).ToString().Equals("1")?"1":"0") + "&pr=" + (chkreboot.Checked?"1":"0");

            Uri urlreq = new Uri("http://192.168.0.52/outpoe.cgi?" + strstatus);
            HttpWebRequest getrequest = (HttpWebRequest)WebRequest.Create(urlreq);

            getrequest.MaximumAutomaticRedirections = 4;
            getrequest.MaximumResponseHeadersLength = 4;

            

            NetworkCredential myNetworkCredential = new NetworkCredential("admin", "voltvolt");
            CredentialCache devcredential = new CredentialCache();
            devcredential.Add(urlreq, "Basic", myNetworkCredential);

            // Set credentials to use for this request.
            getrequest.PreAuthenticate = true;
            getrequest.Credentials = devcredential;

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)getrequest.GetResponse();
                Stream receiveStream = response.GetResponseStream();

                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                string pagedata = readStream.ReadToEnd();
                
                if(pagedata.Equals("Success!"))
                {
                    UpdateStatusTomada();
                }

                response.Close();
                readStream.Close();
            }
            catch (Exception ext)
            {
                lblstatus.Text = "Erro.: " + ext.Message;
            }
        }

        private void UpdateSensors()
        {
            lbltemp.Text = m_json.GetValue("temp").ToString() + "°C";
            lbluptime.Text = m_json.GetValue("updia").ToString() + "d - " + (m_json.GetValue("uphora").ToString().Length <= 1 ? "0" : "") + m_json.GetValue("uphora").ToString() + ":" + (m_json.GetValue("upmin").ToString().Length <= 1 ? "0" : "") + m_json.GetValue("upmin").ToString();
            lblclock.Text = m_json.GetValue("rtc_hours").ToString() + ":" + m_json.GetValue("rtc_minutes").ToString() + ":" + m_json.GetValue("rtc_seconds").ToString();
            lblcalendario.Text = m_json.GetValue("rtc_days").ToString() + ":" + m_json.GetValue("rtc_months").ToString() + ":" + m_json.GetValue("rtc_years").ToString();
        }

        private void UpdateStatusTomada()
        {
            if (m_json.GetValue("rmac1").ToString().Equals("true"))
            {
                btnt1.Enabled = true;

                if (m_json.GetValue("ac0").ToString().Equals("0"))
                {
                    btnt1.Image = global::API_Volt.Properties.Resources.plug32_green;
                    btnt1.Text = m_json.GetValue("nt1").ToString() + Environment.NewLine + "Ligada";
                }
                else
                {
                    btnt1.Image = global::API_Volt.Properties.Resources.plug32_red;
                    btnt1.Text = m_json.GetValue("nt1").ToString() + Environment.NewLine + "Desligada";
                }
            }
            else
            {
                btnt1.Image = global::API_Volt.Properties.Resources.plug32_disabled;
                btnt1.Enabled = false;
                btnt1.Text = m_json.GetValue("nt1").ToString() + Environment.NewLine + "Desabilitada";
            }

            if (m_json.GetValue("rmac2").ToString().Equals("true"))
            {
                btnt2.Enabled = true;

                if (m_json.GetValue("ac1").ToString().Equals("0"))
                {
                    btnt2.Image = global::API_Volt.Properties.Resources.plug32_green;
                    btnt2.Text = m_json.GetValue("nt2").ToString() + Environment.NewLine + "Ligada";
                }
                else
                {
                    btnt2.Image = global::API_Volt.Properties.Resources.plug32_red;
                    btnt2.Text = m_json.GetValue("nt2").ToString() + Environment.NewLine + "Desligada";
                }
            }
            else
            {
                btnt2.Image = global::API_Volt.Properties.Resources.plug32_disabled;
                btnt2.Enabled = false;
                btnt2.Text = m_json.GetValue("nt2").ToString() + Environment.NewLine + "Desabilitada";
            }

            if (m_json.GetValue("rmac3").ToString().Equals("true"))
            {
                btnt1.Enabled = true;

                if (m_json.GetValue("ac2").ToString().Equals("0"))
                {
                    btnt3.Image = global::API_Volt.Properties.Resources.plug32_green;
                    btnt3.Text = m_json.GetValue("nt3").ToString() + Environment.NewLine + "Ligada";
                }
                else
                {
                    btnt3.Image = global::API_Volt.Properties.Resources.plug32_red;
                    btnt3.Text = m_json.GetValue("nt3").ToString() + Environment.NewLine + "Desligada";
                }
            }
            else
            {
                btnt3.Image = global::API_Volt.Properties.Resources.plug32_disabled;
                btnt3.Enabled = false;
                btnt3.Text = m_json.GetValue("nt3").ToString() + Environment.NewLine + "Desabilitada";
            }

            if (m_json.GetValue("rmac4").ToString().Equals("true"))
            {
                btnt4.Enabled = true;

                if (m_json.GetValue("ac3").ToString().Equals("0"))
                {
                    btnt4.Image = global::API_Volt.Properties.Resources.plug32_green;
                    btnt4.Text = m_json.GetValue("nt4").ToString() + Environment.NewLine + "Ligada";
                }
                else
                {
                    btnt4.Image = global::API_Volt.Properties.Resources.plug32_red;
                    btnt4.Text = m_json.GetValue("nt4").ToString() + Environment.NewLine + "Desligada";
                }
            }
            else
            {
                btnt4.Image = global::API_Volt.Properties.Resources.plug32_disabled;
                btnt4.Enabled = false;
                btnt4.Text = m_json.GetValue("nt4").ToString() + Environment.NewLine + "Desabilitada";
            }

            if (m_json.GetValue("rmac5").ToString().Equals("true"))
            {
                btnt5.Enabled = true;

                if (m_json.GetValue("ac4").ToString().Equals("0"))
                {
                    btnt5.Image = global::API_Volt.Properties.Resources.plug32_green;
                    btnt5.Text = m_json.GetValue("nt5").ToString() + Environment.NewLine + "Ligada";
                }
                else
                {
                    btnt5.Image = global::API_Volt.Properties.Resources.plug32_red;
                    btnt5.Text = m_json.GetValue("nt5").ToString() + Environment.NewLine + "Desligada";
                }
            }
            else
            {
                btnt5.Image = global::API_Volt.Properties.Resources.plug32_disabled;
                btnt5.Enabled = false;
                btnt5.Text = m_json.GetValue("nt5").ToString() + Environment.NewLine + "Desabilitada";
            }

            if (m_json.GetValue("rmac6").ToString().Equals("true"))
            {
                btnt6.Enabled = true;

                if (m_json.GetValue("ac5").ToString().Equals("0"))
                {
                    btnt6.Image = global::API_Volt.Properties.Resources.plug32_green;
                    btnt6.Text = m_json.GetValue("nt6").ToString() + Environment.NewLine + "Ligada";
                }
                else
                {
                    btnt6.Image = global::API_Volt.Properties.Resources.plug32_red;
                    btnt6.Text = m_json.GetValue("nt6").ToString() + Environment.NewLine + "Desligada";
                }
            }
            else
            {
                btnt6.Image = global::API_Volt.Properties.Resources.plug32_disabled;
                btnt6.Enabled = false;
                btnt6.Text = m_json.GetValue("nt6").ToString() + Environment.NewLine + "Desabilitada";
            }

            if (m_json.GetValue("rmac7").ToString().Equals("true"))
            {
                btnt7.Enabled = true;

                if (m_json.GetValue("ac6").ToString().Equals("0"))
                {
                    btnt7.Image = global::API_Volt.Properties.Resources.plug32_green;
                    btnt7.Text = m_json.GetValue("nt7").ToString() + Environment.NewLine + "Ligada";
                }
                else
                {
                    btnt7.Image = global::API_Volt.Properties.Resources.plug32_red;
                    btnt7.Text = m_json.GetValue("nt7").ToString() + Environment.NewLine + "Desligada";
                }
            }
            else
            {
                btnt7.Image = global::API_Volt.Properties.Resources.plug32_disabled;
                btnt7.Enabled = false;
                btnt7.Text = m_json.GetValue("nt7").ToString() + Environment.NewLine + "Desabilitada";
            }

            if (m_json.GetValue("rmac8").ToString().Equals("true"))
            {
                btnt8.Enabled = true;

                if (m_json.GetValue("ac7").ToString().Equals("0"))
                {
                    btnt8.Image = global::API_Volt.Properties.Resources.plug32_green;
                    btnt8.Text = m_json.GetValue("nt8").ToString() + Environment.NewLine + "Ligada";
                }
                else
                {
                    btnt8.Image = global::API_Volt.Properties.Resources.plug32_red;
                    btnt8.Text = m_json.GetValue("nt8").ToString() + Environment.NewLine + "Desligada";
                }
            }
            else
            {
                btnt8.Image = global::API_Volt.Properties.Resources.plug32_disabled;
                btnt8.Enabled = false;
                btnt8.Text = m_json.GetValue("nt8").ToString() + Environment.NewLine + "Desabilitada";
            }

            if (m_json.GetValue("rmac9").ToString().Equals("true"))
            {
                btnt9.Enabled = true;

                if (m_json.GetValue("ac8").ToString().Equals("0"))
                {
                    btnt9.Image = global::API_Volt.Properties.Resources.plug32_green;
                    btnt9.Text = m_json.GetValue("nt9").ToString() + Environment.NewLine + "Ligada";
                }
                else
                {
                    btnt9.Image = global::API_Volt.Properties.Resources.plug32_red;
                    btnt9.Text = m_json.GetValue("nt9").ToString() + Environment.NewLine + "Desligada";
                }
            }
            else
            {
                btnt9.Image = global::API_Volt.Properties.Resources.plug32_disabled;
                btnt9.Enabled = false;
                btnt9.Text = m_json.GetValue("nt9").ToString() + Environment.NewLine + "Desabilitada";
            }

            if (m_json.GetValue("rmac10").ToString().Equals("true"))
            {
                btnt10.Enabled = true;

                if (m_json.GetValue("ac9").ToString().Equals("0"))
                {
                    btnt10.Image = global::API_Volt.Properties.Resources.plug32_green;
                    btnt10.Text = m_json.GetValue("nt10").ToString() + Environment.NewLine + "Ligada";
                }
                else
                {
                    btnt10.Image = global::API_Volt.Properties.Resources.plug32_red;
                    btnt10.Text = m_json.GetValue("nt10").ToString() + Environment.NewLine + "Desligada";
                }
            }
            else
            {
                btnt10.Image = global::API_Volt.Properties.Resources.plug32_disabled;
                btnt10.Enabled = false;
                btnt10.Text = m_json.GetValue("nt10").ToString() + Environment.NewLine + "Desabilitada";
            }

        }

        private void SetEnTomada(int _tomada)
        {
            string strstatus = "poe=" + _tomada.ToString() + "&sts=0&pr=0";

            Uri urlreq = new Uri("http://192.168.0.52/outpoe.cgi?" + strstatus);
            HttpWebRequest getrequest = (HttpWebRequest)WebRequest.Create(urlreq);

            getrequest.MaximumAutomaticRedirections = 4;
            getrequest.MaximumResponseHeadersLength = 4;



            NetworkCredential myNetworkCredential = new NetworkCredential("admin", "voltvolt");
            CredentialCache devcredential = new CredentialCache();
            devcredential.Add(urlreq, "Basic", myNetworkCredential);

            // Set credentials to use for this request.
            getrequest.PreAuthenticate = true;
            getrequest.Credentials = devcredential;

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)getrequest.GetResponse();
                Stream receiveStream = response.GetResponseStream();

                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                string pagedata = readStream.ReadToEnd();

                if (pagedata.Equals("Success!"))
                {
                    UpdateStatusTomada();
                }

                response.Close();
                readStream.Close();
            }
            catch (Exception ext)
            {
                lblstatus.Text = "Erro.: " + ext.Message;
            }
        }

        private void btnconfigeth_Click(object sender, EventArgs e)
        {
            frmconfigeth dlgeth = new frmconfigeth();
            dlgeth.Json = m_json;
            dlgeth.ShowDialog();
            
        }

 
        private void tmrupdate_Tick(object sender, EventArgs e)
        {
            GetJsonData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetStatusTomada(6);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnt1_Click(object sender, EventArgs e)
        {
            SetStatusTomada(1);
        }

        private void btnt2_Click(object sender, EventArgs e)
        {
            SetStatusTomada(2);
        }

        private void btnt3_Click(object sender, EventArgs e)
        {
            SetStatusTomada(3);
        }

        private void btnt4_Click(object sender, EventArgs e)
        {
            SetStatusTomada(4);
        }

        private void btnt5_Click(object sender, EventArgs e)
        {
            SetStatusTomada(5);
        }

        private void btnt7_Click(object sender, EventArgs e)
        {
            SetStatusTomada(7);
        }

        private void btnt8_Click(object sender, EventArgs e)
        {
            SetStatusTomada(8);
        }

        private void btnt9_Click(object sender, EventArgs e)
        {
            SetStatusTomada(9);
        }

        private void btnt10_Click(object sender, EventArgs e)
        {
            SetStatusTomada(10);
        }

        private void btnhaball_Click(object sender, EventArgs e)
        {
            SetEnTomada(12);
        }

        private void btndesaball_Click(object sender, EventArgs e)
        {
            SetEnTomada(13);
        }

        private void btnconfigtomada_Click(object sender, EventArgs e)
        {
            frmconfigtomada dlg = new frmconfigtomada();
            dlg.Json = m_json;
            dlg.ShowDialog();
        }
    }
}
