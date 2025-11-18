using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Models
{
    public class HWButtonModel
    {
         public string Texto { get; set; } = "Compre agora";
         public string ButttonFontColor { get; set; } = "#fff";
         public string ButtonFontWeight { get; set; } = "700";
         public string? ButtonColor { get; set; } = "#fcb130";
         public bool Outline { get; set; } = false;

    }
}
