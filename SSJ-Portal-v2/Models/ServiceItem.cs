namespace SSJ_Portal_v2.Models;

/// <summary>
/// ตัวแทนข้อมูลของแต่ละบริการในระบบ Portal
/// </summary>
public class ServiceItem
{
    /// <summary>
    /// ชื่อของบริการ (เช่น ระบบจองห้องประชุม)
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// คำอธิบายสั้นๆ เกี่ยวกับหน้าที่ของบริการ
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Class ของไอคอนจาก Font Awesome (เช่น fa-solid fa-user)
    /// </summary>
    public string IconClass { get; set; } = "fa-solid fa-circle-info";

    /// <summary>
    /// ลิงก์ปลายทางเมื่อผู้ใช้กดปุ่มเข้าใช้งาน
    /// </summary>
    public string TargetUrl { get; set; } = "#";

    /// <summary>
    /// คลาส Tailwind สำหรับพื้นหลัง Gradient (เช่น from-blue-500 to-cyan-400)
    /// </summary>
    public string GradientStyle { get; set; } = "from-gray-400 to-gray-300";

    /// <summary>
    /// สถานะปัจจุบันของบริการ
    /// </summary>
    public ServiceStatus Status { get; set; } = ServiceStatus.Online;
}

/// <summary>
/// รายการสถานะที่เป็นไปได้ของบริการ
/// </summary>
public enum ServiceStatus
{
    Online,       // พร้อมใช้งาน
    Maintenance  // ปิดปรับปรุง
}