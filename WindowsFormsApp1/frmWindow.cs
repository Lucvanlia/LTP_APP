using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.IO;
using System.IO.Compression;
using System.Net;
namespace WindowsFormsApp1
{
    public partial class frmWindow : Form
    {
        public frmWindow()
        {
            InitializeComponent();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("cmd", "/c slmgr /xpr");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thực hiện lệnh.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string GetInstalledOfficeVersion()
        {
            string officeInfo = FindOfficeInUninstallKey(RegistryView.Registry64);
            if (string.IsNullOrEmpty(officeInfo))
            {
                officeInfo = FindOfficeInUninstallKey(RegistryView.Registry32);
            }

            return officeInfo;
        }

        private string FindOfficeInUninstallKey(RegistryView view)
        {
            using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, view))
            {
                using (RegistryKey uninstallKey = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"))
                {
                    if (uninstallKey != null)
                    {
                        foreach (string subKeyName in uninstallKey.GetSubKeyNames())
                        {
                            using (RegistryKey subKey = uninstallKey.OpenSubKey(subKeyName))
                            {
                                string displayName = subKey?.GetValue("DisplayName") as string;
                                if (!string.IsNullOrEmpty(displayName) && displayName.Contains("Microsoft Office"))
                                {
                                    return displayName;
                                }
                            }
                        }
                    }
                }
            }

            return null;
        }
        private void btnOffice_Check_Click(object sender, EventArgs e)
        {
            string version = GetInstalledOfficeVersion();

    if (!string.IsNullOrEmpty(version))
    {
        MessageBox.Show($"Bạn đang sử dụng: {version}", "Thông tin Office", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    else
    {
               
        MessageBox.Show("Không tìm thấy Office trên máy này.", "Thông tin Office", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
        }

        private string path_activefile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "kms.zip");

        private void btnActive_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Hãy đảm bảo rằng đã tắt tưởng lửa trước khi ấn","Lưu ý",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                string extractPath = @"C:\TempKMS";

                try
                {
                    // 1. Giải nén file
                    if (File.Exists(path_activefile))
                    {
                        // Xóa thư mục cũ nếu đã tồn tại
                        if (Directory.Exists(extractPath))
                            Directory.Delete(extractPath, true);

                        ZipFile.ExtractToDirectory(path_activefile, extractPath);
                    }

                    // 2. Chạy file bên trong (ví dụ kms.exe)
                    string exePath = Path.Combine(extractPath, "KMSAuto++.exe");
                    if (File.Exists(exePath))
                    {
                        Process process = new Process();
                        process.StartInfo.FileName = exePath;
                        process.StartInfo.UseShellExecute = true;
                        process.Start();
                        process.WaitForExit(); // Đợi quá trình kết thúc
                    }

                    // 3. Xoá thư mục sau khi xong
                    if (Directory.Exists(extractPath))
                    {
                        Directory.Delete(extractPath, true);
                    }

                    MessageBox.Show("Kích hoạt và xoá tệp thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }    
            
        }
        
        private string GoogleInstallpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "google.exe");

        private void btnInGoogle_Click(object sender, EventArgs e)
        {
            if (File.Exists(GoogleInstallpath))
            {
                Process.Start(GoogleInstallpath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file google.exe", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

