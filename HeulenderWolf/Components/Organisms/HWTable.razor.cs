using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Organisms
{ 
    public partial class HWTable<TItem> : ComponentBase
    {
        #region PARAMETROS

        [Parameter]
        public RenderFragment<TItem> Colunas { get; set; } = default!;

        [Parameter]
        public RenderFragment<TItem>? Footer { get; set; }

        [Parameter]
        public List<TItem> Dados { get; set; } = default!;
        

        [Parameter]
        public string ColSpan { get; set; } = "10";

        #endregion

        #region PROPRIEDADES

        private TItem? ItemSendoArrastado;
        private int? IndiceDestino;

        #endregion

        #region METODOS

		#endregion
	}
}