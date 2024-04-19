namespace ASP_NET_Razor_Page_Work_DB.Model
{
    public class ElectricalElement
    {
        public int Id { get; set; }
        public string Handl_f { get; set; }
        public string BlockName_f { get; set; }
        public string? CableName_f { get; set; } = "NULL";
        public string? CableStart_f { get; set; }
        public string? CableEnd_f { get; set; }
        public string? CableFans_f { get; set; }
        public string? CableDescr_f { get; set; } = "NULL";
        public string BlockX_f { get; set; }
        public string BlockY_f { get; set; }
        public string BlockZ_f { get; set; }
        public string LayerName_f { get; set; }

        public ElectricalElement()
        {
            string[] end = new string[9];
            end[0] = "Двигатель";
            end[1] = "Клеммная коробка";
            end[2] = "Датчик давления";
            end[3] = "Датчик температуры";
            end[4] = "Греющий кабель";
            end[5] = "Насос";
            end[6] = "Точка доступа WI-FI";
            end[7] = "Соединительная коробка";

            string[] start = new string[9];
            start[0] = "Шкаф ET3";
            start[1] = "Шкаф ET4";
            start[2] = "Шкаф ET5";
            start[3] = "Шкаф ШС6";
            start[4] = "Шкаф ШС7";
            start[5] = "Шкаф ЩАВР";
            start[6] = "Шкаф ШУН";
            start[7] = "Шкаф Связи";

            string[] layer = new string[9];
            layer[0] = "lay 1";
            layer[1] = "lay 2";
            layer[2] = "lay 3";
            layer[3] = "lay 4";
            layer[4] = "lay 5";
            layer[5] = "lay 6";
            layer[6] = "lay 7";
            layer[7] = "lay 8";

            Random random = new Random();
            Handl_f =random.Next(10).ToString();
            BlockName_f = random.Next(50).ToString();
            CableStart_f = start[random.Next(0, 7)];
            CableEnd_f = end[random.Next(0, 7)];
            BlockX_f = random.Next(0,1000).ToString();
            BlockY_f = random.Next(0,1200).ToString();
            BlockZ_f = random.Next(0, 0).ToString();
            LayerName_f= layer[random.Next(0, 7)];
        }
        public override string ToString()
        {
            return $" {Id} - {Handl_f} - {BlockName_f} - {CableStart_f} - {CableEnd_f} - {CableFans_f} - " +
                $"{CableDescr_f} - {BlockX_f} - {BlockY_f} - {BlockZ_f}";
        }
    }
}
