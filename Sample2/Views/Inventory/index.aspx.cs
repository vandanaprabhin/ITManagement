using Microsoft.Reporting.WebForms;
using Sample2.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample2.Views.Test
{
    public partial class Inventory : System.Web.Mvc.ViewPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(TempData["Invoice"] == null  && TempData["Location"] == null && TempData["RepackCase"] == null && TempData["Part"] == null && TempData["Code"] == null)
            {
                ReportViewer1.Visible = false;
            }

            else
            {
                if (!IsPostBack)
                {
                    ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reports/RepackInventry.rdlc");
                    DataSet1 dataSet1 = new DataSet1();


                    Sample2.Entities entities = new Entities();
                    var inventory = entities.Inventories.ToList();



                  //  var invoice = TempData["Invoice"].ToString();
                    var location = TempData["Location"].ToString();
                    //var repackCase = TempData["RepackCase"].ToString();
                    //var part = TempData["Part"].ToString();
                    //var code = TempData["Code"].ToString();


                    var locationId = (from b in entities.Locations
                                       where b.LocationCode == location
                                       select b.LocationId).First();

                   

                    var datasource = from b in entities.Inventories
                                     where b.LocationID == locationId
                                     select b;

                  
                    ReportDataSource reportDataSource = new ReportDataSource("DataSet1", datasource.ToList());

                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(reportDataSource);





                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}