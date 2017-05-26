using ibrahimekinci.Plugin.CustomAttributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ibrahimekinci.Plugin.Localization.Public;


namespace ibrahimekinci.Plugin.Address.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelCountry"), CustomRequired, CustomMaxLength(100)]
        public string Name { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelBinaryCode"), CustomRequired, CustomLength(2)]
        public string BinaryCode { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelTripleCode"), CustomRequired, CustomLength(3)]
        public string TripleCode { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelPhoneCode"), CustomRequired, CustomMaxLength(6)]
        public string PhoneCode { get; set; }
        public virtual ICollection<City> City { get; set; }
    }
}