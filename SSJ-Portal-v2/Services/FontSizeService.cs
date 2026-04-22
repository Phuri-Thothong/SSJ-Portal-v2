namespace SSJ_Portal_v2.Services;

/// <summary>
/// บริการสำหรับจัดการสถานะขนาดตัวอักษรของทั้งแอปพลิเคชัน
/// </summary>
public class FontSizeService
{
    // ขนาดเริ่มต้น
    public string CurrentSize { get; private set; } = "medium";

    // Event สำหรับแจ้งเตือน Component อื่นๆ เมื่อมีการเปลี่ยนขนาด
    public event Action? OnSizeChanged;

    public void SetSize(string size)
    {
        if (CurrentSize != size)
        {
            CurrentSize = size;
            OnSizeChanged?.Invoke(); // แจ้งเตือนผู้ที่ติดตาม (Subscribers)
        }
    }

    /// <summary>
    /// ส่งคืน CSS Class ตามขนาดที่เลือก
    /// </summary>
    public string GetFontSizeClass() => CurrentSize switch
    {
        "small" => "font-small",
        "large" => "font-large",
        _ => "font-medium"
    };
}