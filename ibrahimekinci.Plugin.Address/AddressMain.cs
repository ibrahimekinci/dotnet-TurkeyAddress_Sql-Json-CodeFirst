
using ibrahimekinci.Plugin.Address.Models;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace ibrahimekinci.Plugin.Address
{
    public static class AddressMain
    {
        private static string YolGenel { get; } = @"C:\Projects\ibrahimekinci\ibrahimekinci\ibrahimekinci.Plugin.Address\Import\";
        //private static string _yolGenel;
        //private static string YolGenel
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(_yolGenel))
        //        {
        //            string[] Yol = HttpContext.Current.Server.MapPath("~/").Split('\\');
        //            for (int i = 0; i < Yol.Length - 2; i++)
        //            {
        //                _yolGenel += Yol[i] + "\\";
        //            }
        //            _yolGenel += "ibrahimekinci.Plugin.Address\\Import\\";
        //        }
        //        return _yolGenel;
        //    }
        //}
        public static List<Country> CountryList
        {
            get
            {
                if (!File.Exists(YolGenel + "Country.json")) return null;
                using (var streamReader = new StreamReader(YolGenel + "Country.json"))
                {
                    var jsonData = streamReader.ReadToEnd();
                    var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Country>>(jsonData);
                    return list;
                }
            }
        }

        public static List<City> CityList
        {
            get
            {
                if (!File.Exists(YolGenel + "City.json")) return null;
                using (var streamReader = new StreamReader(YolGenel + "City.json"))
                {
                    var jsonData = streamReader.ReadToEnd();
                    var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<City>>(jsonData);
                    return list;
                }
            }
        }

        public static List<County> CountyList
        {
            get
            {
                if (!File.Exists(YolGenel + "County.json")) return null;
                using (var streamReader = new StreamReader(YolGenel + "County.json"))
                {
                    var jsonData = streamReader.ReadToEnd();
                    var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<County>>(jsonData);
                    return list;
                }
            }
        }

        public static List<Area> AreaList
        {
            get
            {
                if (!File.Exists(YolGenel + "Area.json")) return null;
                using (var streamReader = new StreamReader(YolGenel + "Area.json"))
                {
                    var jsonData = streamReader.ReadToEnd();
                    var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Area>>(jsonData);
                    return list;
                }
            }
        }

        public static List<Neighborhood> NeighborhoodList
        {
            get
            {
                if (!File.Exists(YolGenel + "Neighborhood.json")) return null;
                using (var streamReader = new StreamReader(YolGenel + "Neighborhood.json"))
                {
                    var jsonData = streamReader.ReadToEnd();
                    var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Neighborhood>>(jsonData);
                    return list;
                }
            }
        }
    }
}
