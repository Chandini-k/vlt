﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form1 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-UJ5GD8G0/SQLEXPRESS;Initial Catalog=Buyer;User ID=sa;Password=pass@word1");
        if (FileUpload1.HasFile)
        {
            string strname = FileUpload1.FileName.ToString();
            string itemname = TextBox.
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/upload/") + strname);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Items values('"strname"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Visible = true;
            Label1.Text = "Image Uploaded successfully";
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Plz upload the image!!!!";
        }
    }
}