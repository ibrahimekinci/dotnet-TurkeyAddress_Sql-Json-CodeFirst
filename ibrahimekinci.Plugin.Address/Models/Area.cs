
using ibrahimekinci.Plugin.CustomAttributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ibrahimekinci.Plugin.Localization.Public;

namespace ibrahimekinci.Plugin.Address.Models
{ 
    public class Area
    {
        [Key]
        public int Id { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelArea"), CustomRequired, CustomMaxLength(100)]
        public string Name { get; set; }

        [CustomRequired]
        public int CountyId { get; set; }

        public virtual County County { get; set; }
        public virtual ICollection<Neighborhood> Neighborhood { get; set; }
    }
}