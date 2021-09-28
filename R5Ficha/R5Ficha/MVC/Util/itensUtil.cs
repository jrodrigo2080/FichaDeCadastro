using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R5Ficha.MVC.Util
{
    public class itensUtil
    {

        public static void configuraCores(MaterialSkin.Controls.MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue300, 
                Primary.Blue300, 
                Primary.Blue200,
                Accent.LightBlue400, 
                TextShade.WHITE);
        }
    }
    
}
