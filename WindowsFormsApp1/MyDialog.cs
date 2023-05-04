using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyDialog : Form
    {
        public MyDialog()
        {
            InitializeComponent();
        }
        private string[] parms = new string[]{
        "C:\\Windows\\System32\\DafDnsSd.dll",
        "C:\\Windows\\System32\\dnsapi.dll",
        "C:\\Windows\\System32\\dnscacheugc.exe",
        "C:\\Windows\\System32\\dnscmmc.dll",
        "C:\\Windows\\System32\\dnsext.dll",
        "C:\\Windows\\System32\\dnshc.dll",
        "C:\\Windows\\System32\\dnsrslvr.dll",
        "C:\\Windows\\System32\\KBDNSO.DLL",
        "C:\\Windows\\System32\\Windows.Networking.ServiceDiscovery.Dnssd.dll",
        "C:\\Windows\\System32\\wlidnsp.dll",
        "C:\\Windows\\System32\\bderepair.dll",
        "C:\\Windows\\System32\\repair-bde.exe",
        "C:\\Windows\\System32\\en-US\\repair-bde.exe.mui",
        "C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Chkdsk\\SyspartRepair",
        "C:\\Windows\\System32\\zh-CN\\repair-bde.exe.mui",
        "C:\\Windows\\System32\\migwiz\\dlmanifests\\DNS-Client-DL.man",
        "C:\\Windows\\System32\\migwiz\\dlmanifests\\DNS-Server-Service-DL.man",
        "C:\\Windows\\System32\\migwiz\\DNS-Server-Role-Replacement.man",
        "C:\\Windows\\System32\\migwiz\\DNS-Server-Tools-Replacement.man",
        "C:\\Windows\\System32\\wbem\\dnsclientcim.dll",
        "C:\\Windows\\System32\\systemcpl.dll",
        "C:\\Windows\\System32\\SystemEventsBrokerClient.dll",
        "C:\\Windows\\System32\\SystemEventsBrokerServer.dll",
        "C:\\Windows\\System32\\wbem\\dnsclientcim.mof",
        "C:\\Windows\\System32\\wbem\\dnsclientpsprovider.dll",
        "C:\\Windows\\System32\\wbem\\dnsclientpsprovider.mof",
        "C:\\Windows\\System32\\wbem\\dnsclientpsprovider_Uninstall.mof",
        "C:\\Windows\\System32\\wbem\\zh-CN\\dnsclientcim.dll.mui",
        "C:\\Windows\\System32\\wbem\\zh-CN\\dnsclientcim.mfl",
        "C:\\Windows\\System32\\wbem\\zh-CN\\dnsclientpsprovider.dll.mui",
        "C:\\Windows\\System32\\wbem\\zh-CN\\dnsclientpsprovider.mfl",
        "C:\\Windows\\System32\\wbem\\zh-CN\\dnsclientpsprovider_uninstall.mfl",
        "C:\\Windows\\System32\\zh-CN\\dnsapi.dll.mui",
        "C:\\Windows\\System32\\zh-CN\\dnscmmc.dll.mui",
        "C:\\Windows\\System32\\zh-CN\\dnshc.dll.mui",
        "C:\\Windows\\System32\\zh-CN\\dnsrslvr.dll.mui",
        "C:\\Windows\\System32\\Windows.ApplicationModel.SystemEventsBroker.dll",
        "C:\\Windows\\System32\\SystemSettings.DataModel.dll",
        "C:\\Windows\\System32\\SystemSettings.DeviceEncryptionHandlers.dll",
        "C:\\Windows\\System32\\SystemSettings.Handlers.dll",
        "C:\\Windows\\System32\\SystemSettings.SettingsExtensibility.dll",
        "C:\\Windows\\System32\\SystemSettings.UserAccountsHandlers.dll",
        "C:\\Windows\\System32\\SystemSettingsAdminFlows.dll",
        "C:\\Windows\\System32\\SystemSettingsBroker.dll",
        "C:\\Windows\\System32\\SystemSettingsRemoveDevice.dll",
        "C:\\Windows\\System32\\SystemSettingsThresholdAdminFlowUI.dll",
        "C:\\Windows\\System32\\SystemSupportInfo.dll",
        "C:\\Windows\\System32\\AppVEntSubsystemController.dll",
        "C:\\Windows\\System32\\AppVEntSubsystems64.dll",
        "C:\\Windows\\System32\\AppVFileSystemMetadata.dll",
        "C:\\Windows\\System32\\Windows.Internal.System.UserProfile.dll",
        "C:\\Windows\\System32\\Windows.System.Diagnostics.dll",
        "C:\\Windows\\System32\\Windows.System.Diagnostics.dll",
        "C:\\Windows\\System32\\Windows.System.TraceReporting.Platform.dll",
        "C:\\Windows\\System32\\Windows.System.Launcher.dll",
        "C:\\Windows\\System32\\Windows.System.Profile.HardwareId.dll",
        "C:\\Windows\\System32\\Windows.System.Profile.PlatformDataSettings.dll",
        "C:\\Windows\\System32\\Windows.System.Profile.RetailInfo.dll",
        "C:\\Windows\\System32\\Windows.System.Profile.SystemId.dll",
        "C:\\Windows\\System32\\Windows.System.Profile.SystemManufacturers.dll",
        "C:\\Windows\\System32\\Windows.System.RemoteDesktop.dll",
        "C:\\Windows\\System32\\Windows.System.SystemManagement.dll",
        "C:\\Windows\\System32\\Windows.System.UserDeviceAssociation.dll",
        "C:\\Windows\\System32\\Windows.System.UserProfile.DiagnosticsSettings.dll",
        "C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v7.1A\\Include\\WinDNS.h",
        "C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v7.1A\\Include\\wsdns.h",
        "C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v7.1A\\Lib\\DnsAPI.Lib",
        "C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v7.1A\\Lib\\x64\\DnsAPI.Lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\ServiceDiscovery.Dnssd.h",
        "C:\\Program Files (x86)\\Windows Kits\\10\\ServiceDiscovery.Dnssd.0.h",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Networking.Dnssd.1.h",
        "C:\\Program Files (x86)\\Windows Kits\\10\\ServiceDiscovery.Dnssd.2.h",
        "C:\\Program Files (x86)\\Windows Kits\\10\\10.0.19041.0\\um\\WinDNS.h",
        "C:\\Program Files (x86)\\Windows Kits\\10\\10.0.19041.0\\um\\Wsdns.h",
        "C:\\Program Files (x86)\\Windows Kits\\10\\servicediscovery.dnssd.h",
        "C:\\Program Files (x86)\\Windows Kits\\10\\servicediscovery.dnssd.idl",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\10.0.19041.0\\DnsAPI.Lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\10.0.19041.0\\dnscrcli.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\10.0.19041.0\\dnslib.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\10.0.19041.0\\dnsperf.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\10.0.19041.0\\dnsrpc.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\10.0.19041.0\\dnsrslvr.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\10.0.19041.0\\DnsAPI.Lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\10.0.19041.0\\dnscrcli.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\10.0.19041.0\\dnslib.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\10.0.19041.0\\dnsperf.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\10.0.19041.0\\dnsrpc.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\arm64\\dnsrslvr.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x64\\DnsAPI.Lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x64\\dnscrcli.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x64\\dnslib.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x64\\dnsperf.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x64\\dnsrpc.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x64\\dnsrslvr.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x86\\DnsAPI.Lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x86\\dnscrcli.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x86\\dnslib.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x86\\dnsperf.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x86\\dnsrpc.lib",
        "C:\\Program Files (x86)\\Windows Kits\\10\\Lib\\um\\x86\\dnsrslvr.lib"
        };
        private void output(int Value)
        {
            label4.Text = parms[Value];
            //Console.WriteLine(parms[Value]);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                output(progressBar1.Value - 1);
            }
            else
            {
                timer1.Enabled = false;
                Thread.Sleep(1000);
                this.Hide();
                MyDialog2 dig2 = new MyDialog2();
                dig2.ShowDialog(this);
                dig2.Dispose();

            }
        }
        private void my_Start(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer1.Enabled = true;
        }

        private void myClose(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
