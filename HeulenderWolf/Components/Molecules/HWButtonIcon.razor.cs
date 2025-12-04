using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Molecules
{
    public partial class HWButtonIcon : ComponentBase
    {
        #region PARAMETROS

        [Parameter]
        public string Icone { get; set; } = "bi-gear";

        [Parameter]
        public EventCallback OnClickEvent { get; set; }


        private async Task OnClick()
        {
            await OnClickEvent.InvokeAsync();
        }
        #endregion

    }
}
