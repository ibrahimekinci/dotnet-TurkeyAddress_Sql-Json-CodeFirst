using System.ComponentModel.DataAnnotations;
using ibrahimekinci.Plugin.CustomAttributes;
using ibrahimekinci.Plugin.Localization.Public;

namespace ibrahimekinci.Plugin.Address.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelDetail"), CustomMaxLength(300)]
        public string Detail { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelCountry")]
        public int? CountryId { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelCity")]
        public int? CityId { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelCounty")]
        public int? CountyId { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelArea")]
        public int? AreaId { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelNeighborhood")]
        public int? NeighborhoodId { get; set; }

        public virtual Country Country { get; set; }
        public virtual City City { get; set; }
        public virtual County County { get; set; }
        public virtual Area Area { get; set; }
        public virtual Neighborhood Neighborhood { get; set; }
    }
}