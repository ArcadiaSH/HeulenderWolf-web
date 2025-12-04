using HeulenderWolf.Models.Sections;

namespace HeulenderWolf.Models
{
    public class ConfiguracaoGeralModel
    {
        public string CorPrincipal { get; set; }
        public string NumeroWhats { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string textoBotao { get; set; }
        public IFormFile Logo { get; set; }
        public string NomeMarca { get; set; }
        public SobreModel SobreNos { get; set; } = new();

    }
}
