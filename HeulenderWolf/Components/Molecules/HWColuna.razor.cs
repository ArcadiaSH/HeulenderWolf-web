using Microsoft.AspNetCore.Components;
using System.Reflection.Metadata;


namespace HeulenderWolf.Components.Molecules
{
	public partial class HWColuna<TItem> : ComponentBase
	{
		#region PARAMETROS

		[Parameter]
		public string Nome { get; set; } = string.Empty;

		[Parameter]
		public string Descricao { get; set; } = string.Empty;

		[Parameter]
		public string Largura { get; set; } = string.Empty;

		[Parameter]
		public string CssTH { get; set; } = string.Empty;

		[Parameter]
		public string CssTD { get; set; } = string.Empty;

		[Parameter]
		public DateTime? Item { get; set; }

		[CascadingParameter]
		public TItem Dados { get; set; } = default!;

		[Parameter]
		public RenderFragment<TItem> Conteudo { get; set; } = default!;


		#endregion

		#region PROPRIEDADES

		public string CssClassTH => OnCSSClassTH();

		public string CssClassTD => OnCSSClassTD();

		#endregion

		#region METODOS

		protected string OnCSSClassTH()
		{
			return $"{Largura} {CssTH}".Trim();
		}

		protected string OnCSSClassTD()
		{
			return $"{CssTD}".Trim();
		}


        public static object GetValorPropriedade(object obj, string prop)
        {
            var x = obj.GetType().GetProperty(prop);
            var y = x?.GetValue(obj, null);

            return y ?? "";
        }

        #endregion
    }
}
