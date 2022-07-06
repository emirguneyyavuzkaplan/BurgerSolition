namespace Burger.Entities
{
    public enum Birim
    {
        Adet,
        Gram,
        Mililitre,
        Düzine,
        Palet
    }

    public class Urun : BaseEntity
    {
        public string ÜrünAdi { get; set; }
        public string? Aciklama { get; set; }
        public decimal? Adet { get; set; }
        public decimal? Fiyat { get; set; }
        public Birim Birim { get; set; } = Birim.Adet;

    }
}
