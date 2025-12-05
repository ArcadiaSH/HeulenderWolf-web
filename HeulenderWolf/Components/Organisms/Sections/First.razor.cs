using HeulenderWolf.Models;
using HeulenderWolf.Models.Sections;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Reflection;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class First : ComponentBase
    {
        #region PARAMETROS
        [Parameter]
        public EventCallback OnClickEvent { get; set; }
        [CascadingParameter]
        public ConfiguracaoGeralModel ConfiguracaoGeralModel { get; set; }
        #endregion
        #region PROPRIEDADES
        public HWButtonModel ButtonModel { get; set; } = new();
        public FirstModel Model { get; set; } = new();
        public HWFormModal<FirstModel> FormModal { get; set; } = new();
        public IBrowserFile? Img { get; set; }
        #endregion
        #region METODOS
        public async Task ShowModal()
        {
            FormModal.Show(Model);
        }
        public void TesteImagem(InputFileChangeEventArgs img)
        {
            Img = img.File;
        }
        #endregion


    }
}
