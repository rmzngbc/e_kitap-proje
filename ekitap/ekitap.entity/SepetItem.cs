namespace ekitap.entity
{
    public class SepetItem
    {
        public int Id { get; set; }
        public int kitapId { get; set; }
        public kitap kitap { get; set; }

        public int SepetId { get; set; }
        public Sepet Sepet { get; set; }
        public int Adet { get; set; }

    }
}