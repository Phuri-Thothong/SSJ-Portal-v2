namespace SSJ_Portal_v2.Services
{
    public class AdminService
    {
        // 1. ตัวแปรเก็บสถานะ (เริ่มเป็น false เสมอเพื่อความปลอดภัย)
        private bool _isManagementMode = false;

        public bool IsManagementMode => _isManagementMode;

        // 2. Event สำหรับบอก Component อื่นๆ ว่า "มีการเปลี่ยนโหมดแล้วนะ ให้ Refresh หน้าจอด้วย"
        public event Action? OnModeChanged;

        // 3. ฟังก์ชันสำหรับสลับโหมด
        public void ToggleManagementMode()
        {
            _isManagementMode = !_isManagementMode;
            
            // ส่งสัญญาณแจ้งเตือนไปยังหน้าที่สมัครรับข่าวสารไว้
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnModeChanged?.Invoke();
    }
}