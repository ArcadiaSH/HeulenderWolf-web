using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class FAQ : ComponentBase
    {
        #region PARAMETROS
        [Parameter]
        public EventCallback OnClickEvent { get; set; }
        #endregion
    }
}
