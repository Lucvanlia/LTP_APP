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
        private void RunScriptAsAdmin(string script)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = false,
                Verb = "runas" // chạy với quyền admin
            };

            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();
                process.StandardInput.WriteLine(script);
                process.StandardInput.WriteLine("exit");

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                MessageBox.Show(output, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!string.IsNullOrEmpty(error))
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {

            string kmsScript;
            using (WebClient client = new WebClient())
            {
                kmsScript = client.DownloadString("https://raw.githubusercontent.com/abbodi1406/KMS_VL_ALL_AIO/refs/heads/master/KMS_VL_ALL_AIO.cmd");
            }
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc muốn tiếp tục chạy script kích hoạt Office?",
                "Chú ý",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
       
            if (dr == DialogResult.Yes)
            {
                string tempFilePath = Path.Combine(Path.GetTempPath(), "KMS_TEMP.cmd");
                File.WriteAllText(tempFilePath, kmsScript, Encoding.UTF8);

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = tempFilePath,
                    UseShellExecute = true,
                    Verb = "runas" // Chạy với quyền quản trị viên
                };

                try
                {
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thực thi script: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

