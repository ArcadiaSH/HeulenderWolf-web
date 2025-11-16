using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Molecules
{
    public partial class HWCard : ComponentBase
    {
        #region PARAMETRO
        [Parameter] public RenderFragment? CardBody { get; set; }
        [Parameter] public bool Pequeno { get; set; }
        [Parameter] public string? CSSColor { get; set;}
        #endregion

    }
}
