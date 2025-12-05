using System.ComponentModel.DataAnnotations;

namespace HeulenderWolf.Models
{
    public class FAQItem
    {
        [Required(ErrorMessage = "A pergunta é obrigatória")]
        [StringLength(500, ErrorMessage = "A pergunta deve ter no máximo 500 caracteres")]
        public string Pergunta { get; set; } = string.Empty;

        [Required(ErrorMessage = "A resposta é obrigatória")]
        [StringLength(2000, ErrorMessage = "A resposta deve ter no máximo 2000 caracteres")]
        public string Resposta { get; set; } = string.Empty;

        public bool IsExpanded { get; set; } = false;

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public int Ordem { get; set; } = 0;
    }
}
