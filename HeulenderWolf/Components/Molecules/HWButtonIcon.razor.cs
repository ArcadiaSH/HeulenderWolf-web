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

        public void sla() => OnClickEvent.InvokeAsync();


        private async Task teste()
        {
            Console.WriteLine("CLICOU NO TESTE"); // teste
            await OnClickEvent.InvokeAsync();
        }
        #endregion

    }
}
