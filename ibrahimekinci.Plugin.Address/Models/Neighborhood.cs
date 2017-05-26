using System.ComponentModel.DataAnnotations;
using ibrahimekinci.Plugin.CustomAttributes;
using ibrahimekinci.Plugin.Localization.Public;

namespace ibrahimekinci.Plugin.Address.Models
{
    public class Neighborhood
    {
        [Key]
        public int Id { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelNeighborhood"), CustomRequired, CustomMaxLength(100)]
        public string Name { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelZipCode"), CustomRequired(), CustomMaxLength(20)]
        public string ZipCode { get; set; }

        [CustomRequired()]
        public int AreaId { get; set; }

        public virtual Area Area { get; set; }

    }
}