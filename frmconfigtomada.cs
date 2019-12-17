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
    public partial class frmconfigtomada : Form
    {
        private JObject m_json;
        public frmconfigtomada()
        {
            InitializeComponent();
        }

        public JObject Json { get => m_json; set => m_json = value; }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtdescricao.Text.Length == 0)
            {
                MessageBox.Show("Verificar campo Descrição", "Falha na Requisição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdescricao.Focus();
                return;
            }

            SendPortRequest();
        }

        private void GetPortInfo()
        {
            int port = cbotomada.SelectedIndex + 1;

            txtdescricao.Text = m_json.GetValue("nt"+port.ToString()).ToString().Trim();
            chken.Checked = (m_json.GetValue("rmac" + port.ToString()).ToString().Equals("true")?true:false);
        }

        private void cbotomada_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPortInfo();
        }

        private void SendPortRequest()
        {
            int sporta = cbotomada.SelectedIndex + 1;
            string sportsts = chken.Checked ? "true" : "false";
            string strpost = string.Format("porta={0}&rmac={1}&nt={2}", sporta, sportsts, txtdescricao.Text.Trim());

            Uri urlreq = new Uri("http://192.168.0.52/output.htm?" + strpost);
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

                response.Close();
                readStream.Close();
            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message, "Falha na Requisição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
