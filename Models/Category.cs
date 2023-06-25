using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rocky.Models
{
    public class Category
    {
        [Key] 
        public int Id { get; set; } //данный столбец - столбец идентификации сущности и первичный ключ. Если есть слово ID, то он будет ключом по умолчанию
        [Required]                                          
        public string Name { get; set; } // имя категории
        [DisplayName("Display Order")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Display Order for category must be greater than 0")]
        public int DisplayOrder { get; set; } //порядок отображения
    }
}
