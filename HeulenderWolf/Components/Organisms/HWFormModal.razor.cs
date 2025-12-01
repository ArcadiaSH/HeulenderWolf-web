using HeulenderWolf.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace HeulenderWolf.Components.Organisms
{
    public partial class HWFormModal<TItem> : ComponentBase
    {
        #region PARAMETROS

        [Parameter]
        public string TituloHeader { get; set; } = string.Empty;

        [Parameter]
        public string SubTituloHeader { get; set; } = string.Empty;

        [Parameter]
        public RenderFragment<TItem> ChildContent { get; set; } = default!;

        [Parameter]
        public EventCallback OnSalvarEvent { get; set; }


        #endregion

        #region PROPRIEDADES

        protected string TituloModal => string.IsNullOrEmpty(SubTituloHeader) ? TituloHeader : $"{TituloHeader} - {SubTituloHeader}";

        protected bool IsVisible { get; set; } = false;

        protected TItem Entidade { get; set; } = default!;

        public EditContext EditContext { get; set; } = default!;

        public HWButtonModel BotaoSalvarConfig { get; set; } = new HWButtonModel
        {
            Texto = "Salvar",
            ButttonFontColor = "#fff",
            ButtonFontWeight = "700",
            ButtonColor = "#28a745",
            Outline = false
        };
        public HWButtonModel BotaoCancelarConfig { get; set; } = new HWButtonModel
        {
            Texto = "Cancelar",
            ButttonFontColor = "#fff",
            ButtonFontWeight = "700",
            ButtonColor = "#dc3545",
            Outline = false
        };

        #endregion

        #region METODOS

        public void SetEditContext(EditContext editContext)
        {
            EditContext = editContext;
        }

        public void Show(TItem item = default!)
        {
            IsVisible = true;
            Entidade = item;

            EditContext = new EditContext(Entidade);
        }
        public async Task OnSalvar()
        {
            await OnSalvarEvent.InvokeAsync();

        }

        public void OnVoltar()
        {

            Close();

        }

        public void Close()
        {
            IsVisible = false;
            Entidade = default!;
            EditContext = default!;
        }

        private bool IsModificado()
        {
            return EditContext?.IsModified() ?? false;
        }

        public void ResetModificado()
        {
            EditContext.MarkAsUnmodified();
        }

        #endregion        

    }
}
