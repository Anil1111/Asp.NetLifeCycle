using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
   
      public string PageSteps = string.Empty;

        //Raised after the start stage is complete and before the initialization stage begins.
        protected void Page_PreInit(object sender, EventArgs e)
        {
            PageSteps += "1 - Page_PreInit<br>";

            //Access to page Controls not available in this step
            //Label1.Text = "Step 1";
        }

        
        protected void Page_Init(object sender, EventArgs e)
        {
            PageSteps += "2 - Page_Init<br>";

            Label1.Text = "Step 2";
        }

        
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            PageSteps += "3 - Page_InitComplete<br>";

            Label1.Text = "Step 3";
        }

        //Raised after the page loads view state for itself and all controls, and after it processes postback data that is included with the Request instance.
        protected override void OnPreLoad(EventArgs e)
        {
            PageSteps += "4 - OnPreLoad<br>";

            Label1.Text = "Step 4";
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            PageSteps += "5 - Page_Load<br>";

            Label1.Text = "Step 5";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Step only visible on PostBack
            PageSteps += "6 - btnSubmit_Click<br>";

            Label1.Text = "Step 6";
        }

        //Raised at the end of the event-handling stage.
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            PageSteps += "7 - Page_LoadComplete<br>";

            Label1.Text = "Step 7";
        }

        
        protected override void OnPreRender(EventArgs e)
        {
            PageSteps += "8 - OnPreRender<br>";

            Label1.Text = "Step 8";
        }

        //Raised after each data bound control whose DataSourceID property is set calls its DataBind method.
        protected override void OnPreRenderComplete(EventArgs e)
        {
            PageSteps += "9 - OnPreRenderComplete<br>";

            Label1.Text = "Step 9";
        }


    
        protected override void OnSaveStateComplete(EventArgs e)
        {
            PageSteps += "10 - OnSaveStateComplete<br><hr><br>";

            Label1.Text = "Step 10";
        }

        
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //This last PageSteps addition will not be visible on the page
            PageSteps += "11 - Page_UnLoad<br>";

            //Access to page Controls not available in this step
         //   Label1.Text = "Step 11    -    Not Visible";      
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
        PageSteps += "<br>Hello Btn is called</br>";
        }
}

     
