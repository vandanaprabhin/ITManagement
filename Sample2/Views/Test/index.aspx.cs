using Microsoft.Reporting.WebForms;
using Sample2.Datasets;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample2.Views.Test
{
    public partial class index : System.Web.Mvc.ViewPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var test = TempData["ID"];



            if ((Convert.ToInt32(test)) == 0)
            {
                ReportViewer2.Visible = false;
            }

            else
            {
                if (!IsPostBack)
                {



                    ReportViewer2.ProcessingMode = ProcessingMode.Local;
                    ReportViewer2.LocalReport.ReportPath = Server.MapPath("~/Reports/Report1.rdlc");
                    DataSet1 dataSet1 = new DataSet1();
                    DataSet2 dataSet2 = new DataSet2();

                    Sample2.Entities entities = new Entities();
                    var company = entities.Companies.ToList();
                    var suppliers = entities.Suppliers.ToList();


                    string ConStr = ConfigurationManager.ConnectionStrings["1AutoWMSConnectionString"].ConnectionString;
                    //  SqlConnection con = new SqlConnection(ConStr);
                    //  con.Open();
                    //  con.Open();

                    //SqlDataAdapter adapt = new SqlDataAdapter("select * from Company where CompanyId = '" + Convert.ToInt32(test) + "'", con);


                    //  SqlDataAdapter adapt = new SqlDataAdapter(companyQuery, con);

                    //adapt.Fill(dataSet1, "Company");


                    //con.Close();

                    var Id = Convert.ToInt32(test);
                    var datasource1 = from b in entities.Companies
                                      where b.CompanyId == Id
                                      select b;

                    var datasource2 = from c in entities.Suppliers
                                      where c.SupplierId == Id
                                      select c;

                    ReportDataSource reportDataSource1 = new ReportDataSource("DataSet1", datasource1.ToList());
                    ReportDataSource reportDataSource2 = new ReportDataSource("DataSet2", datasource2.ToList());

                    ReportViewer2.LocalReport.DataSources.Clear();
                    ReportViewer2.LocalReport.DataSources.Add(reportDataSource1);
                    ReportViewer2.LocalReport.DataSources.Add(reportDataSource2);





                }
                // GridView1.DataSource = test;
                //GridView1.DataBind
            }
        }







        protected void Button1_Click1(object sender, EventArgs e)
        {

        }


    }
}