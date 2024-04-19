namespace ASP_NET_Razor_Page_Work_DB.Model
{
    public class ElectricalElement
    {
        public int Id { get; set; }
        public string Handl_f { get; set; } = DateTime.UtcNow.ToShortDateString();
        public string BlockName_f { get; set; } = DateTime.UtcNow.ToShortDateString();
        public string? CableName_f { get; set; } 
        public string? CableStart_f { get; set; }
        public string? CableEnd_f { get; set; }
        public string? CableFans_f { get; set; }
        public string? CableDescr_f { get; set; }
        public string BlockX_f { get; set; } = "NULL";
        public string BlockY_f { get; set; } = "NULL";
        public string BlockZ_f { get; set; } = "NULL";
        public string LayerName_f { get; set; } = "NULL";

        public ElectricalElement()
        {
            #region
            //    string[] end = new string[9];
            //    end[0] = "Двигатель";
            //    end[1] = "Клеммная коробка";
            //    end[2] = "Датчик давления";
            //    end[3] = "Датчик температуры";
            //    end[4] = "Греющий кабель";
            //    end[5] = "Насос";
            //    end[6] = "Точка доступа WI-FI";
            //    end[7] = "Соединительная коробка";

            //    string[] start = new string[9];
            //    start[0] = "Шкаф ET3";
            //    start[1] = "Шкаф ET4";
            //    start[2] = "Шкаф ET5";
            //    start[3] = "Шкаф ШС6";
            //    start[4] = "Шкаф ШС7";
            //    start[5] = "Шкаф ЩАВР";
            //    start[6] = "Шкаф ШУН";
            //    start[7] = "Шкаф Связи";

            //    string[] layer = new string[9];
            //    layer[0] = "lay 1";
            //    layer[1] = "lay 2";
            //    layer[2] = "lay 3";
            //    layer[3] = "lay 4";
            //    layer[4] = "lay 5";
            //    layer[5] = "lay 6";
            //    layer[6] = "lay 7";
            //    layer[7] = "lay 8";

            //    Random random = new Random();
            #endregion
            CableName_f = string.Empty;
            CableStart_f = string.Empty;
            CableEnd_f = string.Empty;
            CableFans_f = string.Empty;
            CableDescr_f = string.Empty;
        }
        public ElectricalElement(string handl_f, string blockName_f,
            string? cableName_f, string? cableStart_f, string? cableEnd_f,
            string? cableFans_f, string? cableDescr_f,
            string blockX_f, string blockY_f, string blockZ_f,
            string layerName_f)
        {
     
            Handl_f = handl_f;
            BlockName_f = blockName_f;
            CableName_f = cableName_f;
            CableStart_f = cableStart_f;
            CableEnd_f = cableEnd_f;
            CableFans_f = cableFans_f;
            CableDescr_f = cableDescr_f;
            BlockX_f = blockX_f;
            BlockY_f = blockY_f;
            BlockZ_f = blockZ_f;
            LayerName_f = layerName_f;
        }
        //public ElectricalElement(
        //    string? cableName_f, string? cableStart_f, string? cableEnd_f, string? cableFans_f, 
        //    string? cableDescr_f)
        //{
        //    Handl_f = string.Empty;
        //    BlockName_f = string.Empty;
        //    CableName_f = cableName_f;
        //    CableStart_f = cableStart_f;
        //    CableEnd_f = cableEnd_f;
        //    CableFans_f = cableFans_f;
        //    CableDescr_f = cableDescr_f;
        //    BlockX_f = string.Empty ;
        //    BlockY_f = string.Empty;
        //    BlockZ_f = string.Empty;
        //    LayerName_f = string.Empty;
        //}
        public override string ToString()
        {
            return $" {Id} - {Handl_f} - {BlockName_f} - {CableStart_f} - {CableEnd_f} - {CableFans_f} - " +
                $"{CableDescr_f} - {BlockX_f} - {BlockY_f} - {BlockZ_f}";
        }
    }
}
