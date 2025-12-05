using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class Filhotes : ComponentBase
    {
        #region PARAMETROS
        [Parameter]
        public EventCallback OnClickEvent { get; set; }
        #endregion
    }
}
