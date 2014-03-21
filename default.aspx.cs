using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DilDeneme
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        private void TranslateText()
        {
            string appId = "<Vf/AEaHym/fzxX19jwote9qzJ9Exr63RE+wRNls9Eho>";
            string fromLang = "tr";
            string translatedText = "";
            string tobetranslated = txttext.Text;
            string toLang = ddltolang.SelectedValue.ToString();
            if (tobetranslated == "")
            {

            }
            else
            {
                string uri = "http://api.microsofttranslator.com/v2/Http.svc/Translate?appId=" + appId + "&text=" + tobetranslated + "&from=" + fromLang + "&to=" + toLang;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                WebResponse response = request.GetResponse();
                Stream strm = response.GetResponseStream();
                StreamReader reader = new System.IO.StreamReader(strm);
                translatedText = reader.ReadToEnd();
                Response.Write("The translated text is: '" + translatedText + "'.");
                response.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TranslateText();
        }
    }
}