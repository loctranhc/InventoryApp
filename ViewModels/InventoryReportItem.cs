public class InventoryReportItem
{
    public int STT { get; set; }
    public string MaHang { get; set; }
    public string TenHang { get; set; }
    public int TonTruoc { get; set; }
    public int SoLuongNhap { get; set; }
    public int? SoLuongXuat { get; set; }
    public int TonSau => TonTruoc + SoLuongNhap - SoLuongXuat.GetValueOrDefault();
    public DateTime CreatedTime { get; set; }
}