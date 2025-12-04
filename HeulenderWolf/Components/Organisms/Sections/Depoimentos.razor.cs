using HeulenderWolf.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class Depoimentos : ComponentBase
    {
        #region PARÂMETROS

        //[Parameter]
        //public PesquisaAvaliacaoPreVisualizacao PreVisualizacaoDeDados { get; set; }

        [Parameter]
        public byte[]? Arquivo { get; set; }

        [Parameter]
        public string? ArquivoNome { get; set; }

        [Parameter]
        public bool Disabled { get; set; } = false;

        [Parameter]
        public EventCallback<(byte[]? Arquivo, string? Nome, bool? IsTipoCurso)> OnArquivoSelecionado { get; set; }

        #endregion

        #region PROPRIEDADES
        private IBrowserFile? ArquivoSelecionado { get; set; }

        private int _fileInputKey = 0;

        //private PesquisaAvalicaoFiltroModel Filtro { get; set; } = new();

        protected bool IsTipoCurso { get; set; } = false;

        private bool _isLoading = false;

        public HWFormModal<HWButtonModel> FormModal { get; set; } = new();
        public HWButtonModel ButtonModel { get; set; } = new();
        #endregion
        public async Task ShowModal()
        {
            FormModal.Show(ButtonModel);
        }

        private async Task OnFileChange(InputFileChangeEventArgs e)
        {
            if (Disabled)
            {
                ResetarFormulario();
                return;
            }

            _isLoading = true;

            ArquivoSelecionado = e.File;
            if (ArquivoSelecionado == null) return;

            using var ms = new MemoryStream();
            await ArquivoSelecionado.OpenReadStream(50 * 1024 * 1024).CopyToAsync(ms);
            ms.Position = 0;

            Arquivo = ms.ToArray();
            ArquivoNome = ArquivoSelecionado.Name;

            //if (!await ProcessarArquivo())
            //{
            //    _isLoading = false;
            //    ResetarFormulario();
            //    return;
            //}

            _isLoading = false;

            await OnArquivoSelecionado.InvokeAsync((Arquivo, ArquivoNome, IsTipoCurso));
        }
        public void ResetarFormulario()
        {
            ResetArquivo();
        }

        private void ResetArquivo()
        {
            ArquivoSelecionado = null;
            _fileInputKey++;
            Arquivo = null;
            ArquivoNome = null;
            StateHasChanged();
        }



    }
}
