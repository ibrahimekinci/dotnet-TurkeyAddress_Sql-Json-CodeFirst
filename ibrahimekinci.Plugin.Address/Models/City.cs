using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using ibrahimekinci.Plugin.Localization.Public;
using ibrahimekinci.Plugin.CustomAttributes;

namespace ibrahimekinci.Plugin.Address.Models
{ 
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelCity"), CustomRequired, CustomMaxLength(100)]
        public string Name { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelPlateNo"), CustomRequired, CustomMaxLength(2)]
        public string PlateNo { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelPhoneCode"), CustomRequired, CustomMaxLength(7)]
        public string PhoneCode { get; set; }

        [CustomRequired]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<County> County { get; set; }

    }
}