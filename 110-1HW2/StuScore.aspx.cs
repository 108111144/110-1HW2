using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW2
{
    public partial class StuScore : System.Web.UI.Page
    { 
        public class Scores {
        public string s_Id;
        public float f_ChiS;
        public float f_MathS;
        public float f_EngS;
    }

    
        protected void Page_Load(object sender, EventArgs e)
        {
        StuScore o_Stu = new StuScore();
        o_Stu.s_Id = "A123456789";
        o_Stu.f_ChiS = 62f;
        o_Stu.f_MathS = 73f;
        o_Stu.f_EngS = 84f;
        //s_Id= 值, f_ChiS= 值, f_MathS= 值, f_EngS= 值
        Response.Write("s_Id=" + o_Stu.s_Id + "," +
            "f_ChiS= " + o_Stu.f_Chis.Tostring() + ","+ 
            "f_Maths = " + o_Stu.f_Maths.Tostring() + ","+
            "f_ChiS= " + o_Stu.f_Chis.Tostring() );
    }
}
}