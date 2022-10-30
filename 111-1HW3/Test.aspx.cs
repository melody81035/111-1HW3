using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
    public partial class Test : System.Web.UI.Page {
        string[] sa_cat = new string[2] { "蔬菜", "水果" };
        string[,] sa_2D = new string[2, 2] { { "A菜", "空心菜" }, { "番茄", "火龍果" } };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i_ct = 0; i_ct < sa_cat.Length; i_ct++)
                {
                    ListItem o_L = new ListItem();
                    o_L.Text = o_L.Value = sa_cat[i_ct];

                    ddl_Category.Items.Add(o_L);
                }
                mt_GenSecondList();
            }
        }
        protected void mt_GenSecondList()
        {
            int i_ind = ddl_Category.SelectedIndex;
            ddl_Food.Items.Clear();
            for (int i_ct = 0; i_ct < sa_2D.GetLength(1); i_ct++)
            {
                ListItem o_L = new ListItem();
                o_L.Text = o_L.Value = sa_2D[i_ind, i_ct];

                ddl_Food.Items.Add(o_L);
            }
        }

        protected void ddl_Category_TextChanged(object sender, EventArgs e)
        {
             mt_GenSecondList();
        }
    }

}