using ibrahimekinci.Plugin.CustomAttributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ibrahimekinci.Plugin.Localization.Public;

namespace ibrahimekinci.Plugin.Address.Models
{
    public class County
    {
        [Key]
        public int Id { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelCounty"), CustomRequired, CustomMinLength(2), CustomMaxLength(50)]
        public string Name { get; set; }

        [CustomRequired()]
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Area> Area { get; set; }

    }
}