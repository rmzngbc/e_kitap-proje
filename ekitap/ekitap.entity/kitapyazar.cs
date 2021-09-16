namespace ekitap.entity
{
    public class kitapyazar
    {
        public int yazarId { get; set; }
        public yazar yazar { get; set; }
        public int kitapId { get; set; }
        public kitap kitap { get; set; }
    }
}