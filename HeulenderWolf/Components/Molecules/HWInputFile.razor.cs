using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace HeulenderWolf.Components.Molecules
{
    public partial class HWInputFile : ComponentBase
    {
        #region PARAMETROS

        [Parameter]
        public string Class { get; set; } = string.Empty;

        [Parameter]
        public bool Multiple { get; set; } = false;

        [Parameter]
        public string Tipos { get; set; } = string.Empty;

        [Parameter]
        public string Tamanho { get; set; } = string.Empty;

        [Parameter] 
        public EventCallback<InputFileChangeEventArgs> OnInputFileChange { get; set; }

        #endregion

        #region PROPRIEDADES

        public string ClassCss => $"{Class} seed-file-area".Trim();

        public string MultiplosArquivos => Multiple ? "multiple" : string.Empty;

        public string TituloArquivos => $"{(Multiple ? "Arraste e solte um ou mais arquivo aqui" : "Arraste e solte o arquivo aqui")} ou clique para selecionar";

        public string FormatoPermitido => !string.IsNullOrWhiteSpace(Tipos) ? $"Formatos permitidos: {Tipos}" : string.Empty;

        public string TamanhoMaximo => !string.IsNullOrWhiteSpace(Tamanho) ? $"Tamanho máximo para arquivos: {Tamanho}" : string.Empty;

        public string SelecioneArquivo => Multiple ? "Selecionar arquivo(s)" : "Selecionar arquivo";
       
        protected List<IBrowserFile> Arquivos { get; set; } = [];

        #endregion

        #region METODOS

        protected async Task InputFileChange(InputFileChangeEventArgs e)
        {
            if (Multiple)
            {

                IReadOnlyList<IBrowserFile> novosArquivos = e.GetMultipleFiles();

                foreach (IBrowserFile arquivo in novosArquivos)
                {
                    if (!Arquivos.Any(a => a.Name == arquivo.Name && a.Size == arquivo.Size))
                    {
                        Arquivos.Add(arquivo);
                    }
                }
            }
            else
            {
                Arquivos = [e.File];
            }

            if (OnInputFileChange.HasDelegate) 
            {
                await OnInputFileChange.InvokeAsync(e);
            }    
        }
       
        public void RemoverAnexo(IBrowserFile arquivo)
        {
            if (!Arquivos.Contains(arquivo))
            {
                return;
            }

            Arquivos.Remove(arquivo);
            StateHasChanged();
        }

        static string ObterTamanhoFormatado(long bytes)
        {
            const double KB = 1024.0;
            const double MB = KB * 1024;
            const double GB = MB * 1024;

            if (bytes >= GB)
                return $"{bytes / GB:F2} GB";
            else if (bytes >= MB)
                return $"{bytes / MB:F2} MB";
            else if (bytes >= KB)
                return $"{bytes / KB:F2} KB";
            else
                return $"{bytes} bytes";
        }

        private void HandleDragEnter()
        {
            
        }
        private void HandleDragLeave()
        {
            
        } 

        #endregion
    }
}
