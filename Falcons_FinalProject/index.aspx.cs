using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Falcons_FinalProject
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cdmClickForAnswer_Click(object sender, EventArgs e)
        {
            elmorels calculate = new elmorels();
            string SoultionSelector = ddlSolutionSelector.SelectedValue;
            string BasicCalc = "Basic Calculator";
            string Sudoku = "Sudoku Solver";
            if (SoultionSelector == BasicCalc)
            {
                int number = calculate.Calculate("2+1");
                lblShowSolution.Text = "The Basic Calculator added up 2+1 which equals " + number.ToString();
            }
            else
            {
            if(SoultionSelector == Sudoku)
                {
                    lblShowSolution.Text = "Sudoku solution is";
                }
            }
        }
    }
}