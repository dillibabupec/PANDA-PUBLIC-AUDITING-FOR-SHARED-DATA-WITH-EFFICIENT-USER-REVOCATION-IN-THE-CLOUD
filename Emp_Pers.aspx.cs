using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class GUI_Emp_Pers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Upload_Click(object sender, EventArgs e)
    {
        DecryptionService obj = new DecryptionService();
        FileInfo obj_info= new FileInfo(File_upload.FileName);
        FileInfo obj_infos=new FileInfo(File_upload1.FileName);
        
        obj.DecryptFile(Server.MapPath("Key\\" + "M_ID003\\" + File_upload.FileName).ToString(), Server.MapPath("M_ID003\\" + "EncryptData\\" + File_upload1.FileName).ToString(), Session["Emp"].ToString());
    }
}