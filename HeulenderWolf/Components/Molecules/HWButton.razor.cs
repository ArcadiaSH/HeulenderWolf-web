using HeulenderWolf.Models;
using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Molecules
{
    public partial class HWButton : ComponentBase
    {
        #region PARAMETROS
        [Parameter] public HWButtonModel ButtonConfig { get; set; } = new();
        [Parameter] public EventCallback OnClickEvent { get; set; }

        #endregion

        #region PROPRIEDADE

        #endregion

        #region METODOS
        protected void OnClick()
        {
            OnClickEvent.InvokeAsync();
        }
        #endregion
    }
}
