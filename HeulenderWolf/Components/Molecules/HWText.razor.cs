using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Molecules
{
    public partial class HWButton : ComponentBase
    {
        #region PARAMETROS
        [Parameter] public string Texto { get; set; } = "Compre agora";
        [Parameter] public string Grid { get; set; } = "6";
        [Parameter] public EventCallback Evento { get; set; }
        #endregion

        #region METODOS
        protected void OnClick()
        {
            Evento.InvokeAsync();
        }
        #endregion
    }
}
