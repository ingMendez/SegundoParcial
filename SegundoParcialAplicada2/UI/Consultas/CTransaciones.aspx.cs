
using BLL;
using Entities;
using Microsoft.Reporting.WebForms;
using SegundoParcialAplicada2.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SegundoParcialAplicada2.UI.Consultas
{
    public partial class CTransaciones : System.Web.UI.Page
    {
   
   
         protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DesdeTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                HastaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                LlenaReport();
            }
        }

        public void LlenaReport()
        {
            MyReportViewer.ProcessingMode = ProcessingMode.Local;
            MyReportViewer.Reset();
            MyReportViewer.LocalReport.ReportPath = Server.MapPath(@"~\UI\Reportes\ListadoTransacciones.rdlc");
            MyReportViewer.LocalReport.DataSources.Clear();
            MyReportViewer.LocalReport.DataSources.Add(new ReportDataSource("TransaccionDS", Utils.FTransacciones()));
            MyReportViewer.LocalReport.Refresh();
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        protected void buscarLinkButton_Click(object sender, EventArgs e)
        {
            int id = ToInt(CriterioTextBox.Text);
            int index = ToInt(FiltroDropDownList.SelectedIndex);
            DateTime desde = Utils.ToDateTime(DesdeTextBox.Text);
            DateTime hasta = Utils.ToDateTime(HastaTextBox.Text);
            ConsultaGridView.DataSource = Utils.FiltrarTransacciones(index, CriterioTextBox.Text, desde, hasta);
            ConsultaGridView.DataBind();

            criterioLabel.Text = FiltroDropDownList.Text.ToString();
        }

       

        public static int ToInt(string valor)
        {
            int retorno = 0;
            int.TryParse(valor, out retorno);

            return retorno;
        }
    }
}

