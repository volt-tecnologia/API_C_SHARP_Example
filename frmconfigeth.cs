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
using Newtonsoft.Json.Linq;

namespace API_Volt
{
    public partial class frmconfigeth : Form
    {
        private JObject m_json;
        public frmconfigeth()
        {
            InitializeComponent();
            
        }

        public JObject Json { get => m_json; set => m_json = value; }

        private void SetethConfig()
        {
           Uri urlreq = new Uri("http://192.168.0.52/config.htm");
            HttpWebRequest postrequest = (HttpWebRequest)WebRequest.Create(urlreq);

            postrequest.MaximumAutomaticRedirections = 4;
            postrequest.MaximumResponseHeadersLength = 4;
            postrequest.Method = "POST";


            NetworkCredential myNetworkCredential = new NetworkCredential("admin", "voltvolt");
            CredentialCache devcredential = new CredentialCache();
            devcredential.Add(urlreq, "Basic", myNetworkCredential);

            // Set credentials to use for this request.
            postrequest.Accept = "application/x-www-form-urlencoded";

            postrequest.PreAuthenticate = true;
            postrequest.Credentials = devcredential;

            string strpost = string.Format("dhcp=false&mac={0}&host={1}&ip={2}&gw={3}&sub={4}&dns1={5}&dns2={6}",txtmac.Text ,txthost.Text,txtip.Text,txtgtw.Text,txtmask.Text,txtdns1.Text,txtdns2.Text);

            postrequest.ContentType = "application/x-www-form-urlencoded";
            byte[] postdata = Encoding.UTF8.GetBytes(strpost);
            postrequest.ContentLength = postdata.Length;

            try
            {
                HttpWebResponse response;
                Stream datastream = postrequest.GetRequestStream();
                datastream.Write(postdata, 0, postdata.Length);
                datastream.Close();

                response = (HttpWebResponse)postrequest.GetResponse();

                if(response.StatusCode.ToString().Equals("OK"))
                {
                    ResetDevice();  //reinicia o dispositivo
                }

                response.Close();

            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message, "Falha na Requisição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetDevice()
        {
            Uri urlservice = new Uri("http://192.168.0.52/reset.cgi?timeout=1");
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
                Stream receiveStream = response.GetResponseStream();

                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                string pagedata = readStream.ReadToEnd();

                m_json = JObject.Parse(pagedata);

                response.Close();
                readStream.Close();

                
            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message, "Falha na Requisição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetEthInfo()
        {
            txthost.Text = m_json.GetValue("devhost").ToString().Trim();
            txtmac.Text = m_json.GetValue("devmac").ToString();
            txtip.Text = m_json.GetValue("devip").ToString();
            txtmask.Text = m_json.GetValue("devmask").ToString();
            txtgtw.Text = m_json.GetValue("devgtw").ToString();
            txtdns1.Text = m_json.GetValue("devdns1").ToString();
            txtdns2.Text = m_json.GetValue("devdns2").ToString();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if((txthost.TextLength == 0) || (txthost.TextLength > 15))
            {
                MessageBox.Show("Verificar campo Host, tamanho máximo 15 caracteres!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthost.Focus();
                return;
            }

            if(txtip.TextLength == 0)
            {
                MessageBox.Show("Verificar campo IP!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtip.Focus();
                return;
            }

            if (txtmask.TextLength == 0)
            {
                MessageBox.Show("Verificar campo Máscara de Subrede!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmask.Focus();
                return;
            }

            if (txtgtw.TextLength == 0)
            {
                MessageBox.Show("Verificar campo Gateway!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgtw.Focus();
                return;
            }

            if (txtdns1.TextLength == 0)
            {
                MessageBox.Show("Verificar campo DNS Primário!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdns1.Focus();
                return;
            }

            if (txtdns2.TextLength == 0)
            {
                MessageBox.Show("Verificar campo DNS Secundário!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdns2.Focus();
                return;
            }

            SetethConfig();
        }

        private void frmconfigeth_Load(object sender, EventArgs e)
        {
            GetEthInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
