using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Molecules
{
    public partial class HWInputColor
    {
        #region PARAMETROS

        [Parameter]
        public int Grid { get; set; } = 12;

        [Parameter]
        public int MaxLength { get; set; } = 255;

        [Parameter]
        public string ForId { get; set; } = string.Empty;

        [Parameter]
        public string Label { get; set; } = string.Empty;

        [Parameter]
        public string Placeholder { get; set; } = string.Empty;

        [Parameter]
        public bool Required { get; set; } = false;

        [Parameter]
        public bool ReadOnly { get; set; } = false;

        [Parameter]
        public bool Disabled { get; set; } = false;

        [Parameter]
        public bool UpdateOnInput { get; set; }

        #endregion

        #region PROPRIEDADES

        protected string RequiredClass => Required ? "required" : string.Empty;

        protected string ClassCss => $"{CssClass} form-control form-control-sm seed-input";

        #endregion

        #region METODOS

        private void OnInput(ChangeEventArgs e)
        {
            if (UpdateOnInput)
            {
                CurrentValueAsString = e?.Value?.ToString() ?? string.Empty;
            }
        }

        private void OnChange(ChangeEventArgs e)
        {
            if (!UpdateOnInput)
            {
                CurrentValueAsString = e?.Value?.ToString() ?? string.Empty;
            }
        }

        #endregion
    }
}
