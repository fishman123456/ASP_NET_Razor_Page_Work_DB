namespace ASP_NET_Razor_Page_Work_DB.Model
{
    public class ElectricalElement
    {
        public int Id { get; set; }
        public string Handl_f { get; set; }
        public string BlockName_f { get; set; }
        public string? CableName_f { get; set; }
        public string? CableStart_f { get; set; }
        public string? CableEnd_f { get; set; }
        public string? CableFans_f { get; set; }
        public string? CableDescr_f { get; set; }
        public string BlockX_f { get; set; }
        public string BlockY_f { get; set; }
        public string BlockZ_f { get; set; }
        public string LayerName_f { get; set; }

        public ElectricalElement()
        {
            CableName_f = string.Empty;
            CableStart_f = string.Empty;
            CableEnd_f = string.Empty;
            CableFans_f = string.Empty;
            CableDescr_f = string.Empty;
        }
        public override string ToString()
        {
            return $" {Id} - {Handl_f} - {BlockName_f} - {CableStart_f} - {CableEnd_f} - {CableFans_f} - " +
                $"{CableDescr_f} - {BlockX_f} - {BlockY_f} - {BlockZ_f}";
        }
    }
}
