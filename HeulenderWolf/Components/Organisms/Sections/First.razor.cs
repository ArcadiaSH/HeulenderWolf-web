using HeulenderWolf.Models;
using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class First : ComponentBase
    {
        #region PROPRIEDADES
        #region Title
        public string TitleFontColor { get; set; } = "#1c1333";
        public string TitleFontWeight { get; set; } = "900";
        public string TitleFontSize { get; set; } = "3.8rem";
        public string Title { get; set; } = "Seu novo companheiro espera por você!";

        #endregion
        #region Subtitle
        public string SubtitleFontColor { get; set; } = "#999";
        public string SubtitleFontWeight { get; set; } = "";
        public string SubtitleFontSize { get; set; } = "1.5rem";
        #endregion
        public HWButtonModel ButtonModel { get; set; } = new();
        
       


        #endregion

    }
}
