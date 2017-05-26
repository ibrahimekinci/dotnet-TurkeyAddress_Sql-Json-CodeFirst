using ibrahimekinci.Plugin.CustomAttributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ibrahimekinci.Plugin.Localization.Public;


namespace ibrahimekinci.Plugin.Address.Models
{
    public class CountryExtra
    {
        [Key]
        public int CountryId { get; set; }
        [Display(ResourceType = typeof(Lang), Name = "LabelImageUrl")]
        public string ImageUrl { get; set; }

        [Display(ResourceType = typeof(Lang), Name = "LabelIconHtml")]
        public string IconHtml { get; set; }
    }
}